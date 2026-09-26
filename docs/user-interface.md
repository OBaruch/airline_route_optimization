# User Interface

The application has five windows. All UI text is in Spanish; English translations are given here. This description is based on the form designer files (`*.Designer.cs`), the event handlers and the images embedded in the `.resx` files. No screenshots of the running application were included in the original repository.

## 1. Main Window — Flights (`FormMainVuelos`)

Title: **"Vuelos Al Qaeda Flying"**. It has a background image and a logo, both embedded in `FormMainVuelos.resx`.

| Area | Controls | Behavior |
|---|---|---|
| Flight list | `listBoxVuelos` with header *Ruta · Origen · Destino · Tiempo · Costo* | Shows every flight. Selecting one enables *Ver vuelo seleccionado* (view selected flight) and *Eliminar Vuelo* (delete flight) |
| *Búsqueda de vuelos* (flight search) | Radio buttons *Ruta / Origen / Destino* and a text box | Filters as you type |
| *Ordenamiento* (sorting) | Radio buttons *Costo / Tiempo / Origen / Destino* | Sorts the current (full or filtered) list with quicksort |
| *Administrar Vuelos* (manage flights) | *Ruta, Origen, Destino, Tiempo, Costo, Password*, *Agregar* (add) | Adds a flight. Enabled only with all fields filled and password `123` |
| Navigation | *Ver vuelo seleccionado*, *Lista de pasajeros*, *Mapa* | Opens the seat map, the passenger list or the map |

Input validation, shown in message boxes:

- origin and destination: one letter only (*"SOLO SE PERMITE UN CARACTER"*), letters only, and not equal to each other (*"EL ORIGEN NO PUEDE SER IGUAL AL DESTINO"*);
- time and cost: digits only (*"SOLO SE PERMITEN NUMEROS"*);
- duplicate route codes are rejected (*"NO SE PUEDE DUPLICAR EL NOMBRE DE UN VUELO"*);
- deleting without the password shows *"SIN PERMISO DE ADMINISTRADOR. 'INGRESA LA CONTRASEÑA'"*.

## 2. Seat Map (`FormGraficoDelAvion`)

The background is a top view of an aircraft cabin labeled **"ECONOMY CLASS"** with **30 numbered seats** (1–10 in the top row, 11–20 and 21–30 in the two lower rows), plus the legend *Asiento ocupado* (occupied, maroon) and *Asiento disponible* (available, grey).

- A button sits on each seat. Occupied seats are maroon and disabled.
- The label *"Vuelo: "* shows the route code.
- Choosing a free seat enables *Reservar Asiento* (reserve seat); *Atras* (back) returns to the main window.

## 3. Passenger Registration (`FormRegistoPasajero`)

- Pre-filled, non-editable fields: route, origin, destination, cost (*"… Pesos"*), time (*"… Min"*) and seat number.
- Editable fields: *Nombre/s* (first names), *Apellidos* (last names), both converted to uppercase and letters/spaces only; *Edad* (age), digits only.
- *Reservar* (reserve) is enabled once all three fields are filled. It confirms with *"'NAME' se a reservado exitosmente el asiento N"*.
- *Cambiar Asiento* (change seat) returns to the seat map.

## 4. Passenger List (`FormPasajeros`)

- List header: *RUTA · NOMBRE_APELLIDO · EDAD · ASIENTO* (route, name_surname, age, seat); all passengers of all flights are shown.
- *Búsqueda de pasajeros* (passenger search): filter by *Nombre/s*, *Apellido/s*, *Asiento* or *Edad*.
- *Ordenamiento* (sorting): by name, route or seat.
- *Eliminar Pasajero* (delete passenger) is enabled when a passenger is selected; *Regresar* (return) closes the window.

## 5. Map and Route Analysis (`FormGrafo`)

- The drawing panel uses a **world map** screenshot (embedded in `FormGrafo.resx`) as its background. Each city is a pin with its letter, and each flight is an arrow labeled with cost and time.
- A text box at the top shows the current mode: *MAPA* (map), *AGREGA CIUDAD ORIGEN* (add origin city) or *AGREGA CIUDAD DESTINO* (add destination city).
- In the two "add city" modes, clicking the map stores the point (*"Punto almacenado"*) and closes the window. Selecting a city in the list is blocked (*"CREANDO CIUDAD 'ACCESO DENEGADO'"*).
- In map mode:
  - *Selecciona una Ciudad* + *Eliminar*: deletes the city and all its flights after a warning that the change cannot be undone;
  - *Interconectividad* (interconnectivity) → *Costo (KRUSKAL)* and *Tiempo (PRIM)*: minimum spanning trees by cost or time, drawn in red with per-edge values and a *Total*;
  - *Ruta Optima (Dijkstra)* with *Costo* / *Tiempo*: shortest paths from the selected origin city to every reachable city.

## Typical Session

1. Open the application. The flight list is loaded from `Vuelos.bin`.
2. Enter the password `123` and the flight data, then click *Agregar*. If a city is new, click its position on the map.
3. Select a flight → *Ver vuelo seleccionado* → pick a seat → *Reservar Asiento* → enter the passenger data → *Reservar*.
4. Open *Lista de pasajeros* to search, sort or delete passengers.
5. Open *Mapa* to view the network and run Dijkstra, Kruskal or Prim.
