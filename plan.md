# Plan

> **Artifact type:** Plan (the *how*)
> **Derived from:** [`intent.md`](intent.md) (the *why*) and [`spec.md`](spec.md) (the *what*)
> **Status:** Phases 0–2 done · Phase 3 proposed, not approved

This plan describes how work on this repository is carried out: the phases, the tasks and their status, the guardrails every contributor (human or AI agent) must follow, and how each change is verified before it is merged.

---

## 1. Approach

The repository follows an **intent → spec → plan → change** loop:

```
intent.md  ──►  spec.md  ──►  plan.md  ──►  small PR  ──►  human review  ──►  merge
   ▲                                                             │
   └───────────── decisions and open questions feed back ────────┘
```

1. **Intent** fixes the goals and non-goals. A change that does not serve an outcome (`O-n`) is out of scope.
2. **Spec** describes the original behavior and the repository requirements (`RR-n`) a change must respect.
3. **Plan** breaks the work into small tasks, each linked to an outcome and each verifiable.
4. **Change** is delivered as a focused pull request, reviewed and merged by the author. Nothing is merged without human approval.

Because the source code is frozen, every change here is **documentation or organization**. The loop keeps those changes honest (no invented facts) and safe (no edits to `src/`).

## 2. Current State

| Area | State |
|---|---|
| Source code | Frozen in `src/` (original 2021 upload; the Dijkstra files carry the 2026 change `ac7a049`) |
| Build | Not reproducible (`Program.cs`, `Properties/` missing); historical binaries in `src/Al Qaeda Fying/bin/Debug/` |
| Documentation | README + `docs/` (context, architecture, code overview, algorithms, UI, naming note, improvements) |
| SDLC artifacts | `intent.md`, `spec.md`, `plan.md` (this file) |

## 3. Phases and Tasks

Status: ✅ done · 🟡 proposed · ⛔ rejected by design (non-goal)

### Phase 0 — Discovery ✅

| Task | Outcome | Status |
|---|---|---|
| Inventory every file (code, project, binaries, data, resources) | O-1 | ✅ |
| Recover context from build paths, assembly metadata, commit history | O-3 | ✅ |
| Decode serialized data (`Vuelos.bin`, `Grafo.bin`) and embedded images | O-1 | ✅ |
| Identify missing files, later modifications and contradictions | O-3 | ✅ |

### Phase 1 — Repository reorganization ✅ (PR #5)

| Task | Outcome | Status |
|---|---|---|
| Move the solution and project, unchanged, into `src/` with `git mv` | O-2 | ✅ |
| Preserve the previous README as `docs/original/original-readme.md` | O-2, O-6 | ✅ |
| Write README and `docs/*` with confirmed/inferred/unknown labels | O-1, O-3 | ✅ |
| Record bugs and improvement ideas separately, not applied | O-2 | ✅ |
| Add a minimal `.gitignore` for new build artifacts | O-2 | ✅ |

### Phase 2 — Intent, specification and plan ✅ (this change)

| Task | Outcome | Status |
|---|---|---|
| Write `intent.md` (goals, non-goals, principles, open questions, decisions) | O-5 | ✅ |
| Write `spec.md` as an as-built specification with acceptance criteria and evidence | O-4 | ✅ |
| Write `plan.md` with phases, guardrails, verification and definition of done | O-5 | ✅ |
| Link the three artifacts from the README | O-1 | ✅ |

### Phase 3 — Optional follow-ups 🟡 (require the author's approval)

| Task | Outcome | Depends on | Status |
|---|---|---|---|
| Add `docs/assignment.md` if the original assignment is found | O-3 | Q-1 | 🟡 |
| Confirm or correct the inferred requirements FR-01, FR-16, DR-04 if `Program.cs` is recovered; store it under `docs/original/`, **not** in `src/` | O-3, O-4 | Q-2 | 🟡 |
| Decide how to present the 2026 Dijkstra change (keep as is, or document it as a post-course variant) | O-2 | Q-3 | 🟡 |
| Add screenshots of the historical executable running on Windows to `docs/` | O-1 | Q-4 | 🟡 |
| Author reviews `spec.md` and signs off the "Inferred" items | O-3, O-4 | — | 🟡 |

### Rejected by design ⛔

Fixing bugs, refactoring, porting to modern .NET, recreating `Program.cs` inside `src/`, renaming the project, and adding CI, containers or test frameworks. See [`intent.md`](intent.md#5-non-goals).

## 4. Work Breakdown Rules

- **One concern per pull request** (e.g. "add screenshots", not "add screenshots and rewrite the README").
- **Small diffs:** a reviewer should be able to read the entire change.
- **Evidence first:** before writing a claim, point to the file, commit or binary that supports it. If there is none, label it *Unknown*.
- **Update the chain:** a new fact that changes the intent, spec or plan is reflected in those files in the same PR.

## 5. Guardrails for Contributors and AI Agents

These rules apply to every contributor, including AI coding agents that read this repository. They are written to be unambiguous.

### Allowed

- Create or edit Markdown files at the repository root and under `docs/`.
- Add new original material (documents, screenshots) under `docs/` or `docs/original/`.
- Move files **only** with `git mv`, and only outside `src/` unless the whole solution moves as a unit.
- Edit `.gitignore` to ignore *new* generated files.

### Forbidden

- Modifying, reformatting, re-encoding or normalizing line endings of **any file under `src/`** (code, `.csproj`, `.sln`, `.resx`, binaries, data).
- Deleting any original file, including build output and data.
- Adding build, CI, container, lint, format or test tooling.
- Stating inferred information as confirmed, or inventing commands, versions, dependencies or credentials.
- Renaming the original project, namespace or folders.
- Pushing directly to `main`; all changes go through a reviewed pull request.

### When unsure

Stop and ask the author. Record the question in [`intent.md`](intent.md#8-open-questions) instead of guessing.

## 6. Definition of Done

A change is done when **all** of the following hold:

- [ ] It serves at least one outcome in `intent.md` and references it in the PR description.
- [ ] `src/` is untouched: `git diff --stat origin/main -- src/` prints nothing (for moves, `git diff -M --name-status` shows only `R100`).
- [ ] Every new factual statement is labeled Confirmed / Inferred / Unknown or cites a file or commit.
- [ ] Relative Markdown links resolve to existing files.
- [ ] `intent.md`, `spec.md` and `plan.md` are updated if the change affects them (phase status, decisions, open questions).
- [ ] The PR is reviewed and merged by the author.

## 7. Verification Commands

Run from the repository root before opening a pull request:

```bash
# 1. The original implementation is unchanged (must print nothing)
git diff --stat origin/main -- src/

# 2. Any file moves are pure renames (every line should start with R100)
git diff -M --name-status origin/main | grep '^R'

# 3. Relative links in Markdown point to existing files
grep -oE '\]\(([^)#]+)' README.md intent.md spec.md plan.md docs/*.md \
  | sed -E 's/^([^:]+):\]\(/\1 /' \
  | while read -r file link; do
      case "$link" in http*) continue;; esac
      [ -e "$(dirname "$file")/$link" ] || echo "Broken link in $file: $link"
    done
```

## 8. Risks

| Risk | Impact | Mitigation |
|---|---|---|
| Documentation drifts into claims the code does not support | Loss of credibility | Evidence-first rule, certainty labels, review checklist |
| An automated agent "helpfully" fixes or formats code in `src/` | Historical record altered | Forbidden-changes list above; verification command 1 |
| Line-ending or encoding changes on checkout/commit alter `src/` | Silent diffs in original files | Verification command 1 before every PR |
| Inferred behavior (persistence) is wrong | Misleading spec | Marked **I**; open question Q-2 |
| The original project name causes offense | Reputational | Acknowledged in `docs/naming-note.md`; the repository is presented under a neutral name |
