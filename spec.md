# Specification

> **Artifact type:** Specification (the *what*)
> **Derived from:** [`intent.md`](intent.md) · **Implemented by:** `src/` (original, as-built) · **Work plan:** [`plan.md`](plan.md)
> **Status:** As-built (reverse-engineered) · **Version:** 1.0

This is an **as-built specification**. It was reverse-engineered from the original source code, designer files, embedded resources and compiled binaries. It describes what the application **does**, not what it should do, so documented defects are recorded as they are (section 7) and not "corrected" into requirements.

It serves two purposes:

1. a precise, testable description of the original application for readers and reviewers;
2. a behavioral contract for any future work that wants to reproduce or port the application without losing fidelity. Such work is out of scope for this repository; see [`intent.md`](intent.md#5-non-goals).

### Conventions

- Requirement IDs: `FR-` functional, `BR-` business rule, `DR-` data, `NFR-` non-functional/constraint, `RR-` repository.
- **Evidence** points to the file (under `src/Al Qaeda Fying/`) or artifact that supports the requirement.
- **Certainty:** **C** = Confirmed from code, **I** = Inferred (e.g. from compiled strings), **U** = Unknown.
- Acceptance criteria use *Given / When / Then* and are written so they could be checked manually against the historical executable.
- UI strings are quoted in the original Spanish.

---

## 1. Scope

| In scope | Out of scope |
|---|---|
| Flight catalog administration | Multi-user access, networking, databases |
| Seat reservation (one 30-seat cabin per flight) | Payments, ticketing, pricing rules |
| Passenger administration | Real geography (cities are letters placed on a map image) |
| Map visualization of the route network | Schedules, dates, aircraft types |
| Route optimization: Dijkstra (cost, time), Kruskal (cost), Prim (time) | Automated tests, installers beyond ClickOnce |

## 2. Glossary

| Term (code) | Meaning |
|---|---|
| Vuelo (`ClassVuelo`) | One-way flight between two cities with a cost and a time |
| Ruta | Route code that identifies a flight, `SK1` + origin + destination |
| Pasajero (`ClassPasajero`) | Passenger booked on one seat of one flight |
| Ciudad / Nodo | City and graph node |
| Ady / Arista | Adjacency (edge) in the graph / explicit edge used by MST algorithms |
| Costo | Monetary cost in *Pesos* |
| Tiempo | Duration in minutes (*Min*) |
| ARM | *Árbol de recubrimiento mínimo*: minimum spanning tree |

## 3. Actors

| Actor | Description | Certainty |
|---|---|---|
| Operator | Any user of the desktop application: views flights, books seats, manages passengers, views the map, runs algorithms | C |
| Administrator | An operator who knows the password; can add and delete flights | C |

## 4. Business Rules

| ID | Rule | Evidence | Cert. |
|---|---|---|---|
| BR-01 | A city is identified by exactly **one uppercase letter** `A`–`Z` or `Ñ`. | `FormMainVuelos.textBoxOrigen_TextChanged`, `textBoxDestino_TextChanged` | C |
| BR-02 | A flight's origin and destination must be different. | same handlers | C |
| BR-03 | The route code is `"SK1" + origin + destination` and cannot be edited by the user. | `ClassVuelo` constructor; `textBoxRuta.Enabled = false` | C |
| BR-04 | Route codes must be unique; typing an existing one is rejected. | `FormMainVuelos.textBoxRuta_TextChanged` | C |
| BR-05 | Cost and time are non-negative integers entered as digits only. | `textBoxCosto_KeyPress`, `textBoxTimpo_KeyPress` | C |
| BR-06 | Adding or deleting a flight requires the administrator password `123`. | `FormMainVuelos` | C |
| BR-07 | Every flight has **30 seats**, numbered 1–30. | `FormGraficoDelAvion` | C |
| BR-08 | A seat can be held by at most one passenger; occupied seats cannot be selected. | `FormGraficoDelAvion.InicializaAsiento` | C |
| BR-09 | Passenger names are letters and spaces only and are stored in uppercase; age is digits only. | `FormRegistoPasajero` key handlers | C |
| BR-10 | Flights are **directed**: a flight `A → B` does not imply `B → A`. | `Grafo` constructor | C |
| BR-11 | Each city has a fixed position (x, y) on the map, chosen by the user when the city first appears. | `FormMainVuelos.buttonAgregarV_Click`, `FormGrafo` | C |

## 5. Functional Requirements

### 5.1 Start-up and persistence

**FR-01 Load data at start-up** · Cert. **I** · Evidence: compiled strings `Vuelos.bin`, `Grafo.bin`, `BinaryFormatter`, `Deserialize`; `FormMainVuelos(ListaVuelos, Grafo)`
- *Given* `Vuelos.bin` and `Grafo.bin` exist in the working directory, *when* the application starts, *then* the flight list and graph are restored and the main window lists the stored flights.

**FR-16 Save data** · Cert. **I** · Evidence: compiled strings `Serialize`, `FileStream`
- *Given* changes were made during a session, *when* the main window is closed, *then* the flight list (with passengers) and the graph are written back to the binary files.

### 5.2 Flights (`FormMainVuelos`)

**FR-02 List flights** · Cert. **C**
- *When* the main window opens, *then* every flight is shown as one row with route, origin, destination, time and cost (`ClassVuelo.ToString`).

**FR-03 Search flights** · Cert. **C** · Evidence: `ListaVuelos.busquedaCoincidencias`
- Filter modes: *Ruta* (default, **prefix** match), *Origen* (exact), *Destino* (exact).
- *Given* a filter mode, *when* the user types, *then* the list updates on every keystroke to the matching flights.
- *When* the search box becomes empty, *then* the full list is shown again.
- *When* the filter mode changes, *then* the search text, selection and sort selection are cleared.

**FR-04 Sort flights** · Cert. **C** · Evidence: `ListaVuelos.quicksort*`
- Keys: *Costo*, *Tiempo*, *Origen*, *Destino*; ascending; quicksort.
- *Given* the list is filtered, *when* a sort key is chosen, *then* only the filtered subset is sorted and shown.

**FR-05 Add flight** · Cert. **C** · Evidence: `buttonAgregarV_Click` and the `*_TextChanged` handlers
- *Given* origin, destination, time and cost are filled, the route is auto-generated and the password is `123`, *then* *Agregar* is enabled.
- *When* *Agregar* is pressed, *then* the flight is appended to the list and any active sort is re-applied.
- *Given* the origin (or destination) city does not exist in the graph, *when* the flight is added, *then* the map opens in "AGREGA CIUDAD ORIGEN" (or "DESTINO") mode, and the clicked point becomes the new city's position (FR-15).
- *Then* a directed edge origin → destination with the flight's cost and time is added to the graph, and the form fields are cleared.

**FR-06 Delete flight** · Cert. **C** · Evidence: `buttonEliminarVuelo_Click`
- *Given* a flight is selected and the password is `123`, *when* *Eliminar Vuelo* is pressed, *then* its edge is removed, cities left with no incoming or outgoing edges are removed, and the flight is removed from the list.
- *Given* the password is not `123`, *then* the message "SIN PERMISO DE ADMINISTRADOR. 'INGRESA LA CONTRASEÑA'" is shown and nothing changes.

### 5.3 Seats and passengers

**FR-07 Seat map** · Cert. **C** · Evidence: `FormGraficoDelAvion`
- *Given* a flight is selected, *when* *Ver vuelo seleccionado* is pressed, *then* a 30-seat cabin is shown with the route code; occupied seats are maroon and disabled.
- *When* a free seat is clicked, *then* *Reservar Asiento* becomes enabled for that seat number.

**FR-08 Register passenger** · Cert. **C** · Evidence: `FormRegistoPasajero`
- *Then* the flight's route, origin, destination, cost ("… Pesos"), time ("… Min") and seat are shown, not editable.
- *Given* first names, last names and age are filled, *then* *Reservar* is enabled.
- *When* *Reservar* is pressed, *then* the passenger is added to the flight's passenger list, a confirmation naming the seat is shown, and both the registration and seat windows close.
- *When* *Cambiar Asiento* is pressed, *then* the user returns to the seat map without booking.

**FR-09 Passenger list** · Cert. **C** · Evidence: `FormPasajeros`, `ListaPasajeros`
- *Then* all passengers of all flights are listed with route, name, age and seat.
- Filter (prefix, on every keystroke) by *Nombre/s* (default), *Apellido/s*, *Asiento*, *Edad*; letter-only or digit-only input according to the mode.
- Sort ascending by *Nombre* (first letter), *Ruta* (origin letter) or *Asiento*; sorting an empty list shows "No hay elmentos para ordenar".
- *When* a passenger is selected and *Eliminar Pasajero* is pressed, *then* they are removed from their flight and from the list, and the active sort is re-applied.

### 5.4 Map and algorithms (`FormGrafo`)

**FR-10 Map view** · Cert. **C**
- *When* *Mapa* is pressed, *then* the world map shows each city as a pin with its letter and each flight as an arrow labeled "X -> Y Costo: $c" and "Timepo: t Min".

**FR-11 Delete city** · Cert. **C** · Evidence: `buttonBorrarCiudad_Click`
- *Given* a city is selected, *when* *Eliminar* is pressed and the warning is accepted, *then* every flight with that city as origin or destination is removed from the list and the graph, orphaned cities are removed, and the map is redrawn.

**FR-12 Optimal routes (Dijkstra)** · Cert. **C** · Evidence: `DijkstraCosto`, `DijkstraTiempo`
- *Given* an origin city and *Costo* or *Tiempo* is selected, *when* *Ruta Optima (Dijkstra)* is pressed, *then* one line per reachable city is listed in the form `total<-city<-…<-origin`, with the minimum total cost or time along directed flights.
- Unreachable cities are omitted.

**FR-13 Minimum cost interconnection (Kruskal)** · Cert. **C** · Evidence: `buttonCostosKruskal_Click`
- *When* *Costo (KRUSKAL)* is pressed, *then* a minimum spanning tree or forest by cost is computed, ignoring flight direction; its route codes, individual costs ("$ c") and total cost are listed, and its edges are highlighted in red on the map.

**FR-14 Minimum time interconnection (Prim)** · Cert. **C** · Evidence: `buttonTiemposPrim_Click`, `ListaAristas.seleccionFactibel`
- *Given* a start city is selected, *when* *Tiempo (PRIM)* is pressed, *then* a minimum spanning tree by time is grown from that city, ignoring direction; its route codes, individual times ("t Min") and total time are listed and highlighted in red.

**FR-15 Coordinate picking** · Cert. **C**
- *Given* the map was opened to place a new city, *when* the user clicks the map, *then* "Punto almacenado" is shown, the point is stored and the map closes.
- *In* this mode, selecting a city in the list shows "CREANDO CIUDAD 'ACCESO DENEGADO'".

## 6. Data Requirements

| ID | Requirement | Cert. |
|---|---|---|
| DR-01 | A flight stores origin, destination, cost, time, route code and its own passenger list. | C |
| DR-02 | A passenger stores first names, last names, age, seat and a reference to their flight. | C |
| DR-03 | The graph stores nodes (city name + x, y), directed adjacencies with cost and time weights, and per-node Dijkstra state. | C |
| DR-04 | All persisted types are `[Serializable]` and saved with .NET `BinaryFormatter` to `Vuelos.bin` (flight list) and `Grafo.bin` (graph). | I |
| DR-05 | The included data files contain test values only (3 flights, 1 passenger), see [`docs/architecture.md`](docs/architecture.md#contents-of-the-included-data-files). | C |

## 7. Known Deviations (as-built defects)

The implementation behaves as follows, differently from what the UI implies. These are **documented, not fixed** (see [`docs/possible-improvements.md`](docs/possible-improvements.md) for details).

| ID | Affects | Observed behavior |
|---|---|---|
| KD-01 | FR-07 | When seat 22 is occupied, seat **23** is disabled and seat 22 stays clickable. |
| KD-02 | FR-09 | Passenger filtering stops at the first passenger whose field is shorter than the query. |
| KD-03 | FR-03 | A route search longer than 5 characters throws an exception. |
| KD-04 | FR-12 | A city whose shortest distance equals the sum of all edge weights is reported as unreachable. |
| KD-05 | FR-14 | On a disconnected network, placeholder edges ("Inicio Vacio ERROR" / "Destino Vacio EEROR") appear in the result. |
| KD-06 | FR-01 | The project cannot be rebuilt because `Program.cs` and `Properties/` are missing from the repository. |

## 8. Non-Functional Requirements and Constraints

| ID | Requirement | Cert. |
|---|---|---|
| NFR-01 | Platform: Windows, .NET Framework 4.6.1, Windows Forms, single executable. | C |
| NFR-02 | Offline, single-user, in-memory data; no database or network. | C |
| NFR-03 | UI language: Spanish. | C |
| NFR-04 | Runtime assets `pin.ico`, `marca.ico` and the data files are resolved from the working directory. | C / I |
| NFR-05 | Distribution through ClickOnce with signed manifests. | C |
| NFR-06 | Intended scale: a handful of cities and flights (O(V²) Dijkstra, linear MST helpers). | C |

## 9. Repository Requirements

These apply to the repository layer, not to the application.

| ID | Requirement | Verification |
|---|---|---|
| RR-01 | Files under `src/` are never modified; moves must be 100% similarity renames. | `git diff --stat <base> -- src/` is empty for new changes |
| RR-02 | Original documents are preserved unchanged under `docs/original/`. | Byte comparison against history |
| RR-03 | Every documentation claim is Confirmed, Inferred, Unknown, or traceable to a file. | Review checklist in [`plan.md`](plan.md#6-definition-of-done) |
| RR-04 | No tooling or infrastructure the original project did not have. | Review |
| RR-05 | Documentation is in English with relative links that resolve. | Link check in review |
| RR-06 | Commit messages and documents describe the change itself, not the tools used to produce it. | Review |

## 10. Traceability

| Outcome (`intent.md`) | Covered by |
|---|---|
| O-1 Understand from README | README, FR-02…FR-15 summaries |
| O-2 Preserve original | RR-01, RR-02 |
| O-3 Labeled claims | Certainty column throughout, RR-03 |
| O-4 Testable specification | Sections 4–8 of this document |
| O-5 Explicit plan | [`plan.md`](plan.md) |
| O-6 Name contextualized | [`docs/naming-note.md`](docs/naming-note.md) |
