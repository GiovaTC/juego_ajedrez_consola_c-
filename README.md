# Juego de Ajedrez en Consola

## Reglas del Juego

El ajedrez es un juego de estrategia que se juega en un tablero de 8x8 casillas. Cada jugador tiene 16 piezas: 8 peones, 2 torres, 2 caballos, 2 alfiles, 1 reina y 1 rey.

### Movimientos de las piezas:
- **Peón**: Avanza una casilla hacia adelante (dos casillas en su primer movimiento). Captura en diagonal.
- **Torre**: Se mueve en líneas rectas, horizontal o verticalmente, sin saltar piezas.
- **Caballo**: Se mueve en forma de "L" (dos casillas en una dirección y luego una en perpendicular). Puede saltar sobre otras piezas.
- **Alfil**: Se mueve en diagonal sin saltar piezas.
- **Reina**: Se mueve en cualquier dirección (horizontal, vertical o diagonal) sin saltar piezas.
- **Rey**: Se mueve una casilla en cualquier dirección.

## Cómo jugar en la consola

1. **Inicio del juego**: Se muestra el tablero con las piezas en su posición inicial.
2. **Ingresar movimientos**: El usuario introduce la posición de origen y destino en notación algebraica (ejemplo: `e2 e4`).
3. **Validación de movimientos**: El sistema verifica si el movimiento es válido según las reglas del ajedrez.
4. **Movimiento de la pieza**: Si el movimiento es válido, la pieza se mueve; si no, se muestra un mensaje de error.
5. **Repetir**: El juego continúa hasta que un jugador haga jaque mate o abandone.

## Notación Algebraica
Cada casilla se representa con una letra (a-h) y un número (1-8), por ejemplo:
- `e2` representa la casilla en la columna "e" y fila "2".
- `e4` representa la casilla en la columna "e" y fila "4".

## Condiciones Especiales
- **Capturas**: Una pieza se captura si en su destino hay una pieza del oponente.
- **Jaque**: Si el rey está amenazado, el jugador debe protegerlo.
- **Jaque Mate**: El juego termina si el rey está en jaque y no puede moverse a una posición segura.
- **Tablas**: Ocurre en caso de falta de movimientos legales o repetición de posiciones.

## Movimientos Posibles para Cada Pieza

### Peón
- Avanza una casilla hacia adelante si está libre.
- Avanza dos casillas en su primer movimiento.
- Captura en diagonal una casilla.

### Torre
- Se mueve en línea recta en cualquier dirección horizontal o vertical.
- No puede saltar sobre otras piezas.

### Caballo
- Se mueve en "L": dos casillas en una dirección y una en perpendicular.
- Puede saltar sobre otras piezas.

### Alfil
- Se mueve en diagonal cualquier cantidad de casillas.
- No puede saltar sobre otras piezas.

### Reina
- Se mueve en cualquier dirección (horizontal, vertical o diagonal) cualquier cantidad de casillas.
- No puede saltar sobre otras piezas.

### Rey
- Se mueve una casilla en cualquier dirección.
- No puede moverse a una casilla en jaque.

## Ejemplo de Jugadas

1. **Apertura clásica**:
   - `e2 e4` (El peón de rey avanza dos casillas)
   - `e7 e5` (El peón de las negras responde en espejo)
   - `g1 f3` (El caballo blanco se desarrolla)
   - `b8 c6` (El caballo negro se desarrolla)

2. **Ataque simple**:
   - `e2 e4`
   - `d7 d5`
   - `e4 d5` (Captura del peón negro por el blanco)
   - `d8 d5` (La reina negra captura el peón blanco)

3. **Jaque Mate en 4 movimientos (Mate del loco)**:
   - `f2 f3`
   - `e7 e5`
   - `g2 g4`
   - `d8 h4` (Jaque mate con la reina negra)

¡Disfruta el juego de ajedrez en consola!

---

© 2025 Nombre del Autor. Todos los derechos reservados.
