# Merge resolution notes

If a merge tool reports conflicts for legacy paths such as:
- `Al Qaeda Fying/DijkstraCosto.cs`
- `Al Qaeda Fying/DijkstraTiempo.cs`

those files were renamed and moved into the current project layout:
- `src/AirBaruch/DijkstraCosto.cs`
- `src/AirBaruch/DijkstraTiempo.cs`

Resolve the conflict by applying the changes to the new locations above and keeping the renamed paths removed. This repository intentionally no longer contains the legacy directory name.
