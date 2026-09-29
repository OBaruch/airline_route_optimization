# Intent

> **Artifact type:** Intent (the *why*)
> **Related:** [`spec.md`](spec.md) (the *what*) · [`plan.md`](plan.md) (the *how*)
> **Status:** Active · **Owner:** repository author

This file records **why** this repository exists and what any change to it must achieve. It is the top of the chain *intent → spec → plan → change*: the specification and the plan are derived from it, and any human or AI-assisted contribution should be checked against it before it is proposed.

---

## 1. Context

This repository contains a **Windows Forms desktop application written in C# (.NET Framework 4.6.1)**. It was developed as a course project for a second-semester *Algoritmia* (Algorithms) class, most likely in 2017, and uploaded to GitHub in February 2021. The application manages an airline's flights, seats and passengers and applies graph algorithms (Dijkstra, Kruskal, Prim) to a network of cities. See [`docs/project-context.md`](docs/project-context.md) for the evidence.

The repository has two layers with different intents:

| Layer | What it is | Intent |
|---|---|---|
| **Original implementation** (`src/`) | The code, project files, build output and data as delivered | **Preserve** it exactly. It is a historical record. |
| **Repository layer** (`README.md`, `docs/`, these SDLC files) | Organization, documentation and specifications added later | **Explain** the original work so it can be understood today |

## 2. Original Product Intent (historical, reconstructed)

*Derived from the code and course context; there is no assignment document. Certainty: inferred.*

- **Problem:** an airline with one-way flights between cities, each with a cost and a duration, needs to administer its flights and passengers and to decide how to connect its cities efficiently.
- **Learning goal:** apply the data structures and algorithms of an introductory algorithms course (custom lists, quicksort, prefix search, adjacency-list graphs, shortest paths, minimum spanning trees, serialization) inside a complete, interactive application.
- **Users:** a single operator or administrator using a desktop PC; flight changes are protected by a simple password.

## 3. Repository Intent (current)

**Turn an undocumented legacy upload into a clear, honest, navigable portfolio piece without altering the original work.**

### Target audiences

1. **Portfolio reviewers** (recruiters, engineers): understand in minutes what was built, with which technologies and in what context.
2. **The author**: keep an accurate record of their own early work.
3. **Future contributors, human or AI agents**: have precise, machine-readable boundaries on what may and may not be changed.

### Desired outcomes

| ID | Outcome |
|---|---|
| O-1 | Anyone can explain what the application does from the README alone. |
| O-2 | The original source code, project files, binaries and data stay byte-for-byte identical. |
| O-3 | Every factual claim in the documentation is labeled **Confirmed**, **Inferred** or **Unknown**, or is directly traceable to a file. |
| O-4 | The observable behavior of the original application is captured as a testable specification ([`spec.md`](spec.md)). |
| O-5 | Work on the repository follows an explicit, reviewable plan with guardrails ([`plan.md`](plan.md)). |
| O-6 | The sensitive original project name is acknowledged and contextualized, not hidden or amplified ([`docs/naming-note.md`](docs/naming-note.md)). |

## 4. Principles

1. **Modernize the repository, not the project.** Organization, documentation and presentation may follow current practice; the implementation may not.
2. **Preservation over cleanup.** When in doubt, keep a file and explain it.
3. **Evidence over assumption.** Do not invent context, commands, versions or features. Unknown stays *Unknown*.
4. **Proportionality.** No infrastructure (CI, containers, package managers, linters) that the original project did not have.
5. **Human in the loop.** Every change is proposed as a pull request and approved by the author. AI-generated content is reviewed like any other contribution.
6. **Traceability.** Every requirement in `spec.md` links to evidence, and every task in `plan.md` links to an outcome in this file.

## 5. Non-Goals

- Fixing bugs, refactoring, reformatting or modernizing the C# code.
- Recreating the missing `Program.cs` / `Properties/` files inside `src/`.
- Making the project build or run on modern .NET.
- Renaming the original solution, project, namespace or folders.
- Adding CI/CD, Docker, test frameworks or other tooling.
- Presenting the project as recent or production-grade.

## 6. Constraints

- `src/` is **read-only** for all contributors (see the guardrails in [`plan.md`](plan.md#5-guardrails-for-contributors-and-ai-agents)).
- Documentation is written in **English**. Original identifiers and UI strings stay in Spanish and are quoted as such.
- Files are moved with `git mv` so history is preserved.

## 7. Success Criteria

The intent is met when:

- [x] `git diff <original-commit> -M -- src/` shows only renames with 100% similarity (verified for the reorganization in PR #5).
- [x] The README covers overview, context, structure, technologies, how it works, running status and history.
- [x] Missing files, later modifications and contradictions are disclosed.
- [x] Intent, specification and plan exist and cross-reference each other.
- [ ] The author has reviewed `spec.md` and confirmed or corrected the inferred items (see the open questions below).

## 8. Open Questions

| ID | Question | Why it matters |
|---|---|---|
| Q-1 | What did the original assignment for stage 6 ("Etapa 6") require? | Would allow a confirmed `docs/assignment.md` and turn inferred requirements into confirmed ones |
| Q-2 | Is the original `Program.cs` recoverable from a local backup? | It would confirm the persistence behavior (FR-01, FR-16 in `spec.md`) |
| Q-3 | Should the 2026 change to the Dijkstra files (`ac7a049`) be kept or documented as a separate "post-course" variant? | Affects what "original implementation" means for those two files |
| Q-4 | Are screenshots of the running application available? | Would make `docs/user-interface.md` verifiable |

## 9. Decision Log

| Date | Decision | Rationale |
|---|---|---|
| 2026-09 | Move the whole solution into `src/` unchanged, keeping `bin/` and `obj/` | The `.sln` → `.csproj` relative path stays valid, and `bin/Debug/` holds runtime data and icons |
| 2026-09 | Keep the original project name in files and code | Renaming requires editing code and configuration, which contradicts principle 1 |
| 2026-09 | Do not revert the 2026 Dijkstra modification | Preservation of the current state; disclosed in the documentation instead |
| 2026-09 | Adopt intent → spec → plan artifacts | Gives humans and AI agents an explicit, reviewable contract before any change |
