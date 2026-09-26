# Project Context

This document gathers the evidence available in the repository about where the project came from, and states how certain each point is.

- **Confirmed**: directly supported by files or code in the repository.
- **Inferred**: a reasonable deduction from the repository, not stated explicitly.
- **Unknown**: cannot be determined from the repository.

## Summary

| Item | Value | Certainty |
|---|---|---|
| Project type | Academic / University Project (course project) | Inferred (strong evidence) |
| Institution | A university; name not recorded | Unknown |
| Semester | Second semester ("Semestre 2") | Inferred (strong evidence) |
| Course | *Algoritmia* (Algorithms) | Inferred (strong evidence) |
| Instructor / group | "ANAYA" appears next to the course name; most likely the instructor's surname | Inferred (weak) |
| Delivery stage | "Etapa6" (stage 6 of an incremental project) | Inferred (strong evidence) |
| Application domain | Airline flight, seat and passenger administration with route optimization | Confirmed |
| Language / platform | C#, .NET Framework 4.6.1, Windows Forms | Confirmed |
| IDE | Visual Studio 2017 (solution format "Visual Studio 15") | Confirmed |
| Year of development | 2017, according to the assembly copyright metadata | Inferred (VS templates put the creation year in the copyright) |
| First published | 20 February 2021 on GitHub | Confirmed |
| Assignment statement / rubric | Not included in the repository | Unknown |
| Grade / evaluation | Not included | Unknown |

## Evidence

### Build paths (strongest evidence)

`src/Al Qaeda Fying/obj/Debug/Al Qaeda Fying.csproj.FileListAbsolute.txt` is a file Visual Studio generates automatically. It lists the absolute paths of files produced by every build. It records **three** locations where the project was built:

1. `C:\Users\mmbar\source\repos\Al Qaeda Fying\...` (the default Visual Studio repos folder)
2. `C:\Users\mmbar\OneDrive\Documentos\C#\Al Qaeda Fying\...`
3. `C:\Users\mmbar\Documents\Universidad\Universidad\Semestre 2\AlgoritmiaANAYA\Proyecto\Al Qaeda Fying - Etapa6\...`

The third path places the project under *University → Semester 2 → Algoritmia (ANAYA) → Project → stage 6*. "Etapa 6" suggests the course project was delivered in stages and this is the sixth (and, per the upload commit message, last) one.

### Assembly metadata

The compiled `Al Qaeda Fying.exe` has `LegalCopyright = "Copyright © 2017"` and version `1.0.0.0`. Visual Studio fills this with the year the project was created, so development most likely started in 2017.

### Commit messages

The upload commit (`563cf0b`, 2021-02-20) reads:

> Uploaded the last version of the airline flight administrator.

This confirms the author's own description of the program as an "airline flight administrator" and that the uploaded state is the final version.

### Code content

The code covers a broad set of topics typical of an introductory algorithms course:

- custom list classes derived from `List<T>` (`ListaVuelos`, `ListaPasajeros`, `ListaAristas`);
- hand-written recursive **quicksort** over several keys;
- hand-written **prefix search**;
- an **adjacency-list graph** (`Grafo`, `Nodo`, `Ady`, `Ciudad`);
- **Dijkstra** (by cost and by time), **Kruskal** and **Prim**;
- object **serialization** to binary files.

The `Nodo` class has an unused `Primkruskal` string field and a `setPrimKruskal` method, and the project contains an unused `EDijkstra` class. These look like remains of earlier stages of the incremental project (inferred).

### Language

All identifiers, comments, message boxes and UI text are in Spanish. Costs are shown in "Pesos", which suggests a Spanish-speaking country that uses the peso (inferred; the country is unknown).

## Contradictions and Gaps

- **Project files missing from version control.** `Al Qaeda Fying.csproj` compiles `Program.cs`, `Properties\AssemblyInfo.cs`, `Properties\Resources.Designer.cs`, `Properties\Settings.Designer.cs` and includes `Properties\Resources.resx` and `Properties\Settings.settings`, but none were ever committed. The compiled executable confirms that `Program` (with `Main`) existed. Its exact contents are unknown.
- **Data file names.** The executable contains the strings `Vuelos.bin`, `Vuelo.bin`, `Grafo.bin` and ` Grafo.bin` (with a leading space). Only `Vuelos.bin` and `Grafo.bin` exist in `bin/Debug/`. Whether the variants are typos, unused paths or deliberate cannot be determined without `Program.cs`.
- **Development year vs. publication year.** The metadata suggests 2017; the repository was created in 2021. This is consistent with the project being uploaded years after it was written.

## Repository Timeline

| Date | Commit | Description |
|---|---|---|
| 2021-02-20 | `584abe8` | Initial commit (LICENSE, placeholder README) |
| 2021-02-20 | `afe5f67` | Upload of `bin/Debug` and `obj/Debug` at the repository root |
| 2021-02-20 | `5c955bf`, `0d46a70` | Those root-level `bin/` and `obj/` folders deleted |
| 2021-02-20 | `563cf0b` | Upload of the full project folder (`Al Qaeda Fying/`) — "the last version of the airline flight administrator" |
| 2021-02-20 | `585ba26` | Upload of the solution file (`Al Qaeda Fying.sln`) |
| 2025-03-12 | `a391f3c` | README replaced with the author's apology for the project name (now in [`original/original-readme.md`](original/original-readme.md)) |
| 2026-02-02 | `ac7a049` / `0afdc10` | "Optimize Dijkstra graph processing": `DijkstraCosto.cs` and `DijkstraTiempo.cs` modified and merged |
| — | *this change* | Repository reorganized into `src/` and `docs/` and documented; no source file content changed |

### About the 2026 change to the Dijkstra files

Commit `ac7a049` is the only change to source code after the original 2021 upload. It:

- added two dictionaries (`nodeIndex`, `nodeElementMap`) to `DijkstraCosto` and `DijkstraTiempo`;
- replaced `g.getListaNodos().IndexOf(nAdy)` with a dictionary lookup when relaxing edges;
- replaced the inner linear search used to rebuild paths in `resFinal()` with a dictionary lookup;
- switched some index-based loops to `foreach`, and reset `infinito` at the start of `iniVecDij()`;
- changed line endings on the edited lines.

The algorithm and the output format stayed the same. Because the goal of this reorganization is to preserve the code as it is, that change was **not** reverted. The 2021 versions are available in history:

```bash
git show 563cf0b:"Al Qaeda Fying/DijkstraCosto.cs"
git show 563cf0b:"Al Qaeda Fying/DijkstraTiempo.cs"
```

## Scope

The delivered application is a single-user, offline desktop program with in-memory data structures and binary-file persistence. It has no database, networking, authentication beyond a hard-coded password, or automated tests. This fits the scope of a second-semester algorithms course project.
