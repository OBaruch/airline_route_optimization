# Possible Improvements

> **None of the items below were applied.** The source code is kept exactly as originally written to preserve the historical implementation. This list only records observations made while documenting the project, as a reference for anyone studying or reviving the code.

Each item names the file and the observed behavior. Items marked **(bug)** describe behavior that can be traced in the code. The others are design or maintainability notes.

## Build and Project

1. **Missing entry point and properties.** `Program.cs` and the `Properties/` files are referenced by the `.csproj` but were never committed, so the project does not compile. A new `Program.cs` would need to reproduce loading and saving `Vuelos.bin` / `Grafo.bin` and starting `FormMainVuelos(lv, g)`.
2. **Committed build output.** `bin/` and `obj/` are under version control. They were kept here on purpose, but a maintained project would normally ignore them and copy `pin.ico`, `marca.ico` and the data files to the output folder through the `.csproj`.
3. **Committed signing key.** `Al Qaeda Fying_TemporaryKey.pfx` is a Visual Studio-generated temporary ClickOnce certificate. Private keys should not normally be versioned.
4. **Target framework.** .NET Framework 4.6.1 is out of support. A port would target a current .NET version with Windows Forms.

## Security and Persistence

5. **Hard-coded administrator password** `"123"` in `FormMainVuelos.cs`, compared in plain text in several handlers.
6. **`BinaryFormatter`** (used by the missing `Program.cs`) is obsolete and unsafe for untrusted input in modern .NET. JSON or a small database would replace it.
7. **Redundant state in the saved graph.** `Grafo` stores both the node list and the `ListaVuelos` it was built from, and the flight list is also saved separately, so the two files can drift apart.

## Correctness

8. **(bug) Seat 22 disables seat 23.** `FormGraficoDelAvion.InicializaAsiento`: `if (nAsi == 22) { buttonAsiento22.BackColor = …; buttonAsiento23.Enabled = false; }`. When seat 22 is booked it still looks occupied, but seat 22 stays clickable and seat 23 is disabled.
9. **(bug) Passenger search stops early.** `ListaPasajeros.busquedaCoincidenciasNomApel`: when the query is longer than the current passenger's field, the code uses `break` instead of `continue`, so later passengers are never checked.
10. **(bug) Route search can throw.** `ListaVuelos.busquedaCoincidencias` (option 1) indexes `getRuta()[j]` without checking the route length, so a query longer than the 5-character route code throws `IndexOutOfRangeException`.
11. **(bug) Dijkstra "infinity" sentinel.** `infinito` is the sum of all edge weights, and a node counts as unreachable when its weight equals that value. The relaxation test is strict (`<`), so a node whose shortest distance equals the total edge weight is reported as unreachable. For example, in a network with the single flight `A → B`, `B` is never reached from `A`.
12. **(bug) Prim on a disconnected network.** `ListaAristas.seleccionFactibel` returns a placeholder edge between dummy nodes (`"Inicio Vacio ERROR"` / `"Destino Vacio EEROR"`) when no edge crosses the cut. These placeholder edges then appear in the Prim result instead of an explicit "graph not connected" message.
13. **Start node matched by first character.** `DijkstraCosto/DijkstraTiempo.Inicio(char)` matches the city by the first character of the selected name. This works because cities are single letters, but it would break with longer names.
14. **Sorting by first character only.** The passenger name, origin and destination quicksorts compare only the ASCII code of one character, so ties are left unordered.
15. **Unchecked parsing.** `Int32.Parse` is used on text boxes (age, cost, time). Input is restricted to digits, but very long numbers overflow.
16. **Cancelled coordinate picking.** When a new city is added and the map window is closed without clicking, the node is still created, with coordinates derived from the default `(0, 0)` point.

## UI and Rendering

17. **Drawing with `CreateGraphics()`** in `FormGrafo` instead of the `PaintEventArgs.Graphics` of the `Paint` event. Drawings can disappear when the window repaints, and pens, brushes, fonts and icons are created on each draw without being disposed.
18. **Icons loaded from the working directory** (`new Icon("pin.ico")`) on every draw. The program fails if it is started from another directory.
19. **`Thread.Sleep(1000)` on the UI thread** after storing a map point freezes the window for one second.
20. **Spelling in UI strings**, e.g. "Busqeuda", "exitosmente", "elmentos", "Timepo", "FILTAR".

## Maintainability

21. **Duplicated algorithm classes.** `DijkstraCosto` and `DijkstraTiempo` differ only in the weight they read. A single class with a weight selector would remove the duplication.
22. **Repeated UI logic.** The enable-the-Add-button check is repeated in six handlers, the radio-button reset lambda in eight places across two forms, and the 30 seat buttons are handled with 30 near-identical `if` lines. Loops over a control array would shorten this.
23. **Synchronization logic in forms.** Adding and removing flights, adjacencies and nodes is written directly inside button handlers in two different forms (`FormMainVuelos`, `FormGrafo`). A model/service class would keep the flight list and the graph consistent in one place.
24. **Dead code.** `EDijkstra`, `Nodo.Primkruskal`/`setPrimKruskal`, `Grafo.imprime`, `Grafo.Clone`, the empty event handlers and the Class Designer stub properties (`get => default(...)`) are unused.
25. **Algorithmic efficiency.** Dijkstra is O(V²) (no priority queue), Kruskal uses linear component lookups instead of union-find, and Prim rescans the whole candidate list at every step. This is fine for a handful of cities but would not scale.
26. **Mixed languages and naming.** Spanish identifiers with occasional typos (`getNodoDestinon`, `getPonderacionTimepo`, `seleccionFactibel`, `eiminarAdy`, `serReiniciado`) would be normalized in a maintained codebase.
27. **No automated tests.** The data structures and algorithms have no UI dependencies (apart from their `[Serializable]` attributes), so unit tests would be easy to add.
