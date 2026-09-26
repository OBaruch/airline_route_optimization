# Algorithms

This document explains how the algorithms are implemented in the original code. It describes the code as written, including its quirks. Known limitations are collected in [possible-improvements.md](possible-improvements.md).

## Graph Representation

- **Nodes** (`Nodo`) are cities, named by a single uppercase letter.
- **Edges** (`Ady`) are one-way flights stored in the origin node's adjacency list.
- Every edge has **two weights**: `ponderacionCosto` (cost) and `ponderacionTiempo` (time in minutes).
- For Kruskal and Prim, the adjacency lists are converted into an **edge list** (`ListaAristas` of `Arista`).

## Dijkstra (by cost / by time)

**Files:** `DijkstraCosto.cs`, `DijkstraTiempo.cs`, `ElementoDijkstra.cs`
**Triggered from:** `FormGrafo` → "Ruta Optima (Dijkstra)" with the *Costo* or *Tiempo* radio button.

Single-source shortest paths on the **directed** graph, starting from the city selected in the list.

```
init:
    infinito ← sum of all edge weights in the graph
    for each node v: peso[v] ← infinito, proveniente[v] ← null, definitivo[v] ← false
    peso[start] ← 0

loop:
    e ← unsettled element with the smallest peso           (linear scan)
    settle e; pesoDefi ← peso[e]
    for each outgoing edge (e → w, weight):
        if w not settled and weight + pesoDefi < peso[w]:
            peso[w] ← weight + pesoDefi; proveniente[w] ← e
    stop when every unsettled element has peso == infinito

output, for each node with peso ≠ infinito:
    "peso<-node<-predecessor<-…<-start"
```

- **Complexity:** O(V²) because the minimum is found by a linear scan (no priority queue).
- **"Infinity"** is not `int.MaxValue`. It is the sum of all edge weights of the graph, an upper bound on any simple path.
- The Dijkstra state lives inside each node (`Nodo.getElementoD()`), so the graph object is mutated and reset on each run.
- The **start node** is found by comparing the city name with the *first character* of the selected item. City names are single letters, so this matches.
- Example output line: `57<-Y<-M<-A` means the best total from `A` to `Y` is 57, going `A → M → Y`.

The two classes are identical except for the weight they read. As noted in the [project context](project-context.md#about-the-2026-change-to-the-dijkstra-files), both files were modified in 2026 to use dictionaries for node lookups. The algorithm and output did not change.

## Kruskal (by cost)

**Where:** `FormGrafo.buttonCostosKruskal_Click`
**Triggered from:** "Costo (KRUSKAL)".

Builds a minimum spanning tree (or forest) that minimizes the **total cost**. Edge direction is ignored, which matches the code comment *"Convertir el grafo en NO dirigido (NO NESESARIO)"* ("convert the graph to undirected (NOT NECESSARY)").

```
candidates ← every edge of the graph as an Arista
sort candidates by cost ascending (ListaAristas.quicksortCosto)
CC ← one component per city (a List<string> holding the city name)

for each candidate edge (u → v) in order:
    if more than one component remains:
        i ← index of component containing u
        j ← index of component containing v
        if i ≠ j:
            merge component j into component i
            add flight (u → v) to the result
```

- Components are plain lists of city names, searched linearly, instead of a union-find structure. The search uses labeled `goto` statements to break out of nested loops.
- The result edges become a new `ListaVuelos` and then a new `Grafo` (`ARM`, *árbol de recubrimiento mínimo* = minimum spanning tree). Its nodes get the original map coordinates and it is drawn as thick red lines under the original graph.
- The route codes, individual costs and the **total cost** are shown in the list boxes.
- The method creates a copy `new Grafo(lv)` and then immediately overwrites it with `grafoDirigido = g`, so Kruskal reads the live graph. It does not modify it.

## Prim (by time)

**Where:** `FormGrafo.buttonTiemposPrim_Click` and `ListaAristas.seleccionFactibel`
**Triggered from:** "Tiempo (PRIM)" after selecting a city.

Grows a minimum spanning tree that minimizes the **total flight time**, starting from the selected city. Edge direction is ignored.

```
G' ← new Grafo(lv)                               (fresh copy built from the flight list)
candidates ← every edge of G' sorted by time ascending
S ← { selected city }
while |tree| < |nodes(G')| - 1:
    edge ← first candidate with exactly one endpoint in S     (seleccionFactibel)
    add edge to tree
    add its endpoint that is not yet in S to S
```

- Because the candidates are sorted once, "first crossing edge in sorted order" is the lightest edge crossing the cut, which is the Prim selection rule, implemented with a linear scan per step (O(V·E)).
- If no crossing edge exists (disconnected network, or no city selected), `seleccionFactibel` returns a placeholder edge between two dummy nodes named `"Inicio Vacio ERROR"` and `"Destino Vacio EEROR"`. The loop still terminates because the tree grows by one edge per iteration, but those placeholder edges show up in the results.
- The result is converted into flights and a `Grafo`, given the original coordinates, drawn in red, and listed with individual times and the **total time**.

## Quicksort

**Where:** `ListaVuelos`, `ListaPasajeros`, `ListaAristas`

All sorts use the same recursive, in-place quicksort pattern:

```
quicksort(list, first, last):
    pivot ← key(list[(first+last)/2])
    i ← first; j ← last
    do:
        while key(list[i]) < pivot: i++
        while key(list[j]) > pivot: j--
        if i ≤ j: swap(list[i], list[j]); i++; j--
    while i ≤ j
    if first < j: quicksort(list, first, j)
    if i < last:  quicksort(list, i, last)
```

Sort keys available:

| List | Keys |
|---|---|
| `ListaVuelos` | cost, time, origin (ASCII of first char), destination (ASCII of first char) |
| `ListaPasajeros` | first name (ASCII of first letter only), route (ASCII of 4th character = origin letter), seat |
| `ListaAristas` | cost, time |

String keys are compared only by their **first relevant character**, so names that start with the same letter are not ordered among themselves.

## Prefix Search

**Where:** `ListaVuelos.busquedaCoincidencias`, `ListaPasajeros.busquedaCoincidenciasNomApel`

Incremental search runs on every keystroke (`TextChanged`). For prefix fields (route, first name, last name, seat, age) each item is compared character by character against the typed text, and it matches when all typed characters match. Origin and destination use exact equality. The filtered result is kept (`lvF`, `lpCF`) so later sorts can run on the filtered subset.
