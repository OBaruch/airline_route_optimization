# Airline Route Optimization

A Windows Forms desktop application, written in C# for the .NET Framework, that manages a small airline's flights and passengers and applies classic graph algorithms (Dijkstra, Kruskal and Prim) to a network of cities to find optimal routes by **cost** and by **flight time**.

> **Note on the original project name.** The Visual Studio solution, project, namespace and executable still carry the name chosen when the project was first created. The author has since publicly apologized for that choice; the statement is preserved in [`docs/original/original-readme.md`](docs/original/original-readme.md) and discussed in [`docs/naming-note.md`](docs/naming-note.md). File and folder names were **not** renamed, so that the original Visual Studio solution still opens as it was built.

---

## Project Overview

The application models an airline network as a **directed weighted graph**:

- every **city** is a node, identified by a single uppercase letter (`A`–`Z`, `Ñ`) and placed at pixel coordinates on a world map;
- every **flight** is an edge `origin → destination` with two weights: **cost** (in pesos) and **time** (in minutes);
- every flight has a **30-seat aircraft** in which passengers can reserve seats.

On top of that model the application offers flight administration (add, delete, search, sort), seat reservation, passenger administration (search, sort, delete), a map view of the network, and route analysis with Dijkstra, Kruskal and Prim.

## Project Context

| | |
|---|---|
| **Classification** | Academic / University Project (coursework) |
| **Course** | *Algoritmia* (Algorithms), second semester (**inferred**, see below) |
| **Stage** | "Etapa 6" (stage 6) of an incremental course project (**inferred**) |
| **Original tooling** | Visual Studio 2017, .NET Framework 4.6.1 (**confirmed**) |
| **Assembly copyright year** | 2017 (**confirmed** from compiled metadata) |
| **Uploaded to GitHub** | February 2021 (**confirmed** from git history) |

The repository contains no assignment statement, report or instructions document. The academic context comes from the absolute build paths that Visual Studio left in `obj/Debug/Al Qaeda Fying.csproj.FileListAbsolute.txt`, which include:

```
C:\Users\...\Documents\Universidad\Universidad\Semestre 2\AlgoritmiaANAYA\Proyecto\Al Qaeda Fying - Etapa6\...
```

i.e. *University → Semester 2 → Algoritmia (ANAYA) → Project → Stage 6*. "ANAYA" most likely refers to the instructor or course group; this cannot be confirmed. The original commit message also describes the upload as "the last version of the airline flight administrator". See [`docs/project-context.md`](docs/project-context.md) for all evidence.

## Problem Statement

Given a set of cities connected by one-way flights, each with a monetary cost and a duration, the program should:

1. let an administrator maintain the flight catalog and the passengers booked on each flight;
2. represent the network as a graph and draw it on a map;
3. compute the **cheapest** and **fastest** routes from a chosen city to every reachable city (Dijkstra);
4. compute a minimum set of connections that keeps every city connected, minimizing **total cost** (Kruskal) or **total time** (Prim).

## Objective

Based on the code and the course folder name, the objective was to **apply data structures and algorithms studied in an algorithms course** (custom list classes, quicksort, prefix search, adjacency-list graphs, Dijkstra, Kruskal, Prim and binary serialization) inside a complete, usable desktop application.

## Repository Structure

```
airline_route_optimization/
├── README.md                     ← this file
├── LICENSE                       ← Apache License 2.0 (original)
├── .gitignore
├── src/
│   ├── Al Qaeda Fying.sln        ← Visual Studio 2017 solution (original, unchanged)
│   └── Al Qaeda Fying/           ← C# project (original, unchanged)
│       ├── *.cs                  ← domain classes, data structures, algorithms, forms
│       ├── *.Designer.cs / *.resx← Windows Forms designer code and embedded images
│       ├── ClassDiagram1.cd      ← Visual Studio class diagram
│       ├── bin/Debug/            ← historical compiled build + runtime data (Vuelos.bin, Grafo.bin, icons)
│       └── obj/Debug/            ← historical intermediate build artifacts
└── docs/
    ├── project-context.md        ← origin, evidence, timeline
    ├── architecture.md           ← components, data model, persistence, flow
    ├── code-overview.md          ← file-by-file description
    ├── algorithms.md             ← how Dijkstra, Kruskal, Prim, quicksort and search are implemented
    ├── user-interface.md         ← description of each window and its features
    ├── naming-note.md            ← note on the original project name
    ├── possible-improvements.md  ← observations NOT applied to the code
    └── original/
        └── original-readme.md    ← the README that existed before this reorganization
```

The whole Visual Studio solution was moved as a unit into `src/`, so the relative path from the `.sln` to the `.csproj` is unchanged. Build outputs in `bin/` and `obj/` were kept in place because `bin/Debug/` also holds the runtime data files and icons the program loads from its working directory.

## Original Implementation

This repository preserves the original implementation of the project. The source code has intentionally not been refactored or modernized in order to retain the historical context and original development approach. The source code represents the original implementation developed during my university studies.

Identifiers, comments and UI text are in Spanish, exactly as written at the time (e.g. `ClassVuelo` = flight, `ClassPasajero` = passenger, `Grafo` = graph, `Arista` = edge, `Ady` = adjacency, `Ciudad` = city, `costo` = cost, `tiempo` = time).

> **Exception recorded in git history.** In February 2026, before this reorganization, commit `ac7a049` ("Optimize Dijkstra graph processing") changed `DijkstraCosto.cs` and `DijkstraTiempo.cs` (it replaced linear `IndexOf` lookups with dictionaries). Every other source file is exactly as uploaded in February 2021. The 2021 version of those two files can be inspected with `git show 563cf0b:"Al Qaeda Fying/DijkstraCosto.cs"`. This reorganization did not modify either version. Details in [`docs/project-context.md`](docs/project-context.md#repository-timeline).

## Technologies

Confirmed from the project and solution files:

- **C#** (Visual Studio 2017 / C# 7 syntax, e.g. expression-bodied accessors)
- **.NET Framework 4.6.1**
- **Windows Forms** (`System.Windows.Forms`) and **GDI+** (`System.Drawing`, `System.Drawing.Drawing2D`) for the UI and map drawing
- **BinaryFormatter** (`System.Runtime.Serialization.Formatters.Binary`) for saving and loading data
- **ClickOnce** publishing (signed manifests, `app.publish/` output)
- **Visual Studio Class Designer** (`ClassDiagram1.cd`)

No third-party libraries or NuGet packages are used.

## How It Works

1. **Start-up** *(inferred: `Program.cs` is not in the repository, see below)*: the entry point loads a flight list (`ListaVuelos`) and a graph (`Grafo`) from binary files in the working directory (`Vuelos.bin`, `Grafo.bin`) and opens the main window `FormMainVuelos`.
2. **Flight administration** (`FormMainVuelos`): flights are listed, searched (by route prefix, origin or destination) and sorted (by cost, time, origin, destination) with hand-written quicksort. Adding or deleting a flight requires the administrator password. When a new flight introduces an unknown city, the map opens so the user can click where the city should be placed.
3. **Seat reservation** (`FormGraficoDelAvion` → `FormRegistoPasajero`): a 30-seat cabin diagram shows occupied seats in maroon; choosing a free seat opens a form for first name, last name and age.
4. **Passenger administration** (`FormPasajeros`): all passengers from all flights are listed, can be searched by prefix (first name, last name, seat, age), sorted (name, route, seat) and deleted.
5. **Map and route analysis** (`FormGrafo`): cities are drawn as pins over a world map with arrows labeled with cost and time. For a selected city the user can run:
   - **Dijkstra by cost or by time**: optimal path to every reachable city, displayed as `total<-destination<-…<-origin`;
   - **Kruskal (cost)**: a minimum spanning tree/forest over the network, highlighted in red with the total cost;
   - **Prim (time)**: a minimum spanning tree grown from the selected city, highlighted in red with the total time.
   Deleting a city removes it and every flight that touches it.
6. **Shutdown** *(inferred)*: data is serialized back to the `.bin` files.

See [`docs/architecture.md`](docs/architecture.md) and [`docs/algorithms.md`](docs/algorithms.md).

## Inputs and Outputs

| Kind | Where | Notes |
|---|---|---|
| Interactive input | Windows Forms controls | Flight data, passwords, passenger data, map clicks |
| Persistent data | `src/Al Qaeda Fying/bin/Debug/Vuelos.bin`, `Grafo.bin` | .NET `BinaryFormatter` files; contain a few test flights (`SK1ME`, `SK1MY`, `SK1GY`) and one test passenger |
| Runtime assets | `src/Al Qaeda Fying/bin/Debug/pin.ico`, `marca.ico` | Map pins, loaded by relative path |
| Embedded images | `*.resx` | World map background, cabin seat plan, logo, window background |
| Output | Screen (list boxes, map drawing) | No reports or files other than the `.bin` data are produced |

## Running the Project

The repository does not contain enough information to give a verified, working build procedure:

- `Program.cs`, `Properties/AssemblyInfo.cs`, `Properties/Resources.*` and `Properties/Settings.*` are referenced by `Al Qaeda Fying.csproj` but **were never committed**, so the project **cannot be compiled as-is**. The compiled executable confirms that a `Program` class with a `Main` method existed.
- A historical Debug build is included: `src/Al Qaeda Fying/bin/Debug/Al Qaeda Fying.exe`. It targets **Windows** and **.NET Framework 4.6.1**. Because it loads `pin.ico`, `marca.ico`, `Vuelos.bin` and `Grafo.bin` using relative paths, it would need to run with `bin/Debug/` as its working directory. This has not been verified as part of this reorganization.
- The administrator password used to enable "add flight" and "delete flight" is hard-coded in `FormMainVuelos.cs` as `123`.

No commands, versions or dependencies beyond those confirmed above are implied.

## Documentation

- [Project context and evidence](docs/project-context.md)
- [Architecture](docs/architecture.md)
- [Code overview](docs/code-overview.md)
- [Algorithms](docs/algorithms.md)
- [User interface](docs/user-interface.md)
- [Note on the project name](docs/naming-note.md)
- [Possible improvements (not applied)](docs/possible-improvements.md)
- [Original README](docs/original/original-readme.md)

## Historical Note

This repository was later reorganized and documented to improve readability and preserve the historical context of the original project. The original source code remains unchanged. The reorganization only moved files into `src/` and `docs/`, added Markdown documentation and a `.gitignore`, and kept every original file, including compiled binaries and build artifacts.

## License

Distributed under the Apache License 2.0; see [`LICENSE`](LICENSE).
