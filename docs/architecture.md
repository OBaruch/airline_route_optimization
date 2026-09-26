# Architecture

The application is a single-project **Windows Forms** program. There are no separate layers, services or assemblies. The structure below comes from the code, the `.csproj` and the Visual Studio class diagram (`src/Al Qaeda Fying/ClassDiagram1.cd`).

## Component Overview

```
                       ┌──────────────────────────┐
                       │ Program (Main)           │  ← not in repository (inferred)
                       │ loads/saves *.bin files  │
                       └────────────┬─────────────┘
                                    │ ListaVuelos lv, Grafo g
                                    ▼
                       ┌──────────────────────────┐
                       │ FormMainVuelos           │  flights: list, search, sort,
                       │ (main window)            │  add/delete (password)
                       └──┬──────────┬─────────┬──┘
                          │          │         │
            ┌─────────────┘          │         └──────────────┐
            ▼                        ▼                        ▼
┌───────────────────────┐ ┌───────────────────────┐ ┌───────────────────────┐
│ FormGraficoDelAvion   │ │ FormPasajeros         │ │ FormGrafo             │
│ 30-seat cabin map     │ │ all passengers:       │ │ map + graph drawing,  │
└──────────┬────────────┘ │ search, sort, delete  │ │ Dijkstra / Kruskal /  │
           ▼              └───────────────────────┘ │ Prim, delete city,    │
┌───────────────────────┐                           │ pick coordinates      │
│ FormRegistoPasajero   │                           └───────────────────────┘
│ passenger data entry  │
└───────────────────────┘
```

All windows are opened as modal dialogs (`ShowDialog()`) and receive references to the **same** `ListaVuelos` and `Grafo` instances, so every change is made directly on the shared in-memory objects.

## Data Model

### Flight and passenger domain

```
ListaVuelos : List<ClassVuelo>
    └── ClassVuelo  (origen, destino, costo, tiempo, ruta = "SK1"+origen+destino)
            └── ListaPasajeros : List<ClassPasajero>
                    └── ClassPasajero (nombres, apellidos, edad, asiento, vueloDelPasajero)
```

- A flight is identified by its **route code** `SK1` + origin letter + destination letter (e.g. `SK1ME`).
- Each passenger keeps a back-reference to their flight.
- The list classes add domain operations (prefix search, quicksort by several keys) on top of `List<T>`.

### Graph

```
Grafo
 ├── listaNodos : List<Nodo>
 │      └── Nodo
 │           ├── ciudad   : Ciudad (nombre, x, y)       ← position on the map in pixels
 │           ├── listaAdy : List<Ady>                   ← outgoing edges
 │           │      └── Ady (n: Nodo, ponderacionCosto, ponderacionTiempo)
 │           ├── elemento : ElementoDijkstra            ← per-node Dijkstra state
 │           └── Primkruskal : string                   ← unused (see code-overview)
 └── lv : ListaVuelos                                   ← list the graph was built from
```

- The graph is **directed**: one `Ady` per flight, stored on the origin node.
- Every edge carries **two weights**, cost and time, so one graph serves both "by cost" and "by time" algorithms.
- `Arista` / `ListaAristas` are a separate **edge-list** representation (origin, destination, both weights) built on demand for Kruskal and Prim.
- `ElementoDijkstra` stores the tentative distance (`peso`), predecessor (`proveniente`) and the "settled" flag (`definitivo`) **inside each node**, so a Dijkstra run mutates the shared graph state (it is reset at the start of every run).

### Keeping the two structures in sync

The flight list and the graph are two separate structures kept in sync by hand in the UI code:

| Action | Flight list | Graph |
|---|---|---|
| Add flight (`FormMainVuelos.buttonAgregarV_Click`) | `lv.Add(vuelo)` | Creates missing origin/destination nodes (asking for map coordinates through `FormGrafo`), then adds an `Ady` to the origin |
| Delete flight (`FormMainVuelos.buttonEliminarVuelo_Click`) | `lv.Remove(...)` | Removes the matching `Ady`, then removes nodes left with no incoming or outgoing edges |
| Delete city (`FormGrafo.buttonBorrarCiudad_Click`) | Removes every flight whose origin or destination is the city | Removes the corresponding `Ady` entries and orphaned nodes |

The `Grafo(ListaVuelos)` constructor can also rebuild a graph from a flight list. The Kruskal/Prim code uses it to build the result trees, and Prim uses it to work on a copy of the network.

## Persistence

Persistence is **inferred** from the compiled executable, because `Program.cs` is not in the repository:

- The executable references `BinaryFormatter`, `FileStream`, `Serialize` and `Deserialize`, and contains the strings `Vuelos.bin`, `Vuelo.bin`, `Grafo.bin` and ` Grafo.bin`.
- All model classes that make up the object graph are marked `[Serializable]` (`ClassVuelo`, `ClassPasajero`, `ListaVuelos`, `ListaPasajeros`, `Grafo`, `Nodo`, `Ady`, `Ciudad`, `ElementoDijkstra`, `DijkstraCosto`, `DijkstraTiempo`).
- `src/Al Qaeda Fying/bin/Debug/` contains `Vuelos.bin` (a serialized `ListaVuelos`) and `Grafo.bin` (a serialized `Grafo`).

The most likely flow is: `Main` deserializes both files, opens `FormMainVuelos(lv, g)`, and serializes them back after the window closes. This matches the `FormMainVuelos(ListaVuelos lv, Grafo g)` constructor and the `getListaVuelos()` accessor, but cannot be confirmed.

### Contents of the included data files

Decoding the files shows a small **test dataset**:

| Route | Origin | Destination | Cost | Time |
|---|---|---|---|---|
| `SK1ME` | M | E | 65432 | 123 |
| `SK1MY` | M | Y | 23 | 123 |
| `SK1GY` | G | Y | 34 | 234 |

There is also one test passenger (`POCHO` / `SDFSDFS`, age 23, seat 20) linked to a flight `F → G` that is no longer in the list. `Grafo.bin` contains nodes `M`, `E`, `G`, `Y`. These look like leftover test values from development, not a meaningful dataset.

## Rendering

`FormGrafo` draws the network directly onto a `Panel` whose background image is a world map embedded in `FormGrafo.resx`:

- cities: `pin.ico` icon plus the city letter at `(x, y)` (`marca.ico` is prepared for an alternative node style but that call is commented out);
- flights: black arrows (`AdjustableArrowCap`) labeled `A -> B Costo: $… / Timepo: … Min`;
- Kruskal/Prim result: thick semi-transparent red lines drawn under the normal graph.

Drawing uses `panel1.CreateGraphics()` from both the `Paint` handler and button handlers.

## External Resources

| Resource | Location | Used by |
|---|---|---|
| World map background | `FormGrafo.resx` (`panel1.BackgroundImage`) | `FormGrafo` |
| Cabin seat plan (30 seats, "Economy class") | `FormGraficoDelAvion.resx` | `FormGraficoDelAvion` |
| Logo and window background | `FormMainVuelos.resx` | `FormMainVuelos` |
| `pin.ico`, `marca.ico` | `bin/Debug/` (loaded by relative path) | `FormGrafo.DibujarNodos` |
