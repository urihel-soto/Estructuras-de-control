# Estructuras-de-control
## Proyecto: Prototipo de Consola - Cooperativa 

## 1. Integrantes del Equipo
- **Génesis Altagracia de la Cruz Perozo** | Matrícula: 26-SISN-2-051
- **Dalbert Yordani Hernández Alcántara** | Matrícula: 26-EISN-2-014
- **Emmanuel Javier Mercedes** | Matrícula: 26-EISN-2-023
- **Urihel Soto De Peña** | Matrícula: 26-EISN-2-032
- **Yokenddy Amparo Silvestre** | Matrícula: 26-EISN-2-002
- **Antoni Ramírez Mercedes** | Matrícula: 26-EISN-2-019

---

## 2. Descripción del Proyecto
Este proyecto consiste en una aplicación de consola desarrollada en C# para la cooperativa **"Ahorro Seguro"**, orientada a modernizar dos procesos manuales mediante un menú principal interactivo que permite elegir entre dos funcionalidades clave[cite: 3, 4]:

1. **Cajero Automático:** Simulación de acceso seguro mediante PIN con validación de hasta 3 intentos, consulta de saldo, depósitos y retiros de efectivo con validación de múltiplos y límites de saldo[cite: 3].
2. **Simulador de Préstamo:** Cálculo de cuotas fijas mensuales y generación de una tabla de amortización detallada según la categoría del socio y su tasa de interés correspondiente[cite: 3].

---

## 3. Ejercicio 1: Cajero Automático

### Datos de Entrada
- **PIN de seguridad:** Clave de 4 dígitos ingresada por el usuario[cite: 3].
- **Opción del menú del cajero:** Selección entre consultar saldo, depositar, retirar o salir[cite: 3].
- **Monto a depositar:** Cantidad numérica a ingresar a la cuenta[cite: 3].
- **Monto a retirar:** Cantidad numérica a extraer de la cuenta[cite: 3].

### Datos que Procesa
- **Validación de PIN:** Compara el PIN ingresado con el PIN maestro definido en el código (máximo 3 intentos; si se agotan, la cuenta se bloquea)[cite: 3].
- **Gestión de Saldo (Saldo inicial: RD$ 10,000.00):**[cite: 3]
  - **Depósito:** Valida que el monto ingresado sea mayor que cero y incrementa el saldo[cite: 3].
  - **Retiro:** Valida que el monto sea mayor que cero, no supere el saldo disponible y sea múltiplo exacto de RD$ 100[cite: 3].
- **Conteo de Transacciones:** Registra la cantidad total de depósitos y retiros exitosos realizados durante la sesión[cite: 3].

### Datos de Salida
- Confirmaciones de operaciones (depósitos/retiros) o mensajes explicativos en caso de error/validación.
- Saldo actual formateado en moneda.
- Resumen final al salir: cantidad de depósitos realizados, cantidad de retiros realizados y saldo final de la cuenta[cite: 3].

---

## 4. Ejercicio 2: Simulador de Préstamo

### Datos de Entrada
- **Monto del préstamo:** Valor entre RD$ 5,000.00 y RD$ 500,000.00[cite: 3].
- **Plazo:** Período entre 6 y 60 meses[cite: 3].
- **Categoría del socio:** Letra correspondiente a la categoría (`A`, `B` o `C`)[cite: 3].
- **Confirmación de reinicio:** Respuesta (`S` / `N`) para indicar si desea realizar otra simulación[cite: 3].

### Datos que Procesa
- **Validación estricta de rangos:** Si el monto, el plazo o la categoría son inválidos, la aplicación vuelve a solicitar el dato utilizando bucles repetitivos y `int.TryParse` / `double.TryParse`[cite: 3, 4].
- **Asignación de Tasa Anual e Interés Mensual ($i$):**[cite: 3]
  - Categoría **A:** 12% anual ($i = 0.12 / 12$)[cite: 3].
  - Categoría **B:** 15% anual ($i = 0.15 / 12$)[cite: 3].
  - Categoría **C:** 18% anual ($i = 0.18 / 12$)[cite: 3].
- **Cálculo de Cuota Fija Mensual:** Aplica la fórmula de amortización:
  $$\text{Cuota} = \text{Monto} \cdot \frac{i(1+i)^n}{(1+i)^n - 1}$$[cite: 3]
- **Generación de la Tabla de Amortización:** Desglose mes a mes utilizando ciclos iterativos para calcular el interés del período, el abono a capital y el balance final remanente[cite: 3].

### Datos de Salida
- Tasa de interés aplicada según la categoría elegida[cite: 3].
- Tabla completa de amortización mostrando mes por mes: número de cuota, monto de la cuota, interés, abono a capital y saldo restante[cite: 3].
- Resumen acumulado de totales pagados (Total amortizado a capital e Intereses totales abonados)[cite: 3].

---

## 5. Tecnología Utilizada
- **Lenguaje de Programación:** C# (.NET Console Application)[cite: 3].
- **Estructuras de Control:** `if`, `else if`, `else`, `switch`, `for`, `while` y `do-while`[cite: 3].
- **Manejo y Validación de Datos:** `int.TryParse()` / `double.TryParse()` para captura limpia de consola sin excepciones[cite: 4].
- **Control de Versiones:** Git y GitHub[cite: 3, 4].

---

## 6. Capturas del Programa

### Ejercicio 1: Cajero Automático
- **Caso Exitoso:** *(Insertar imagen de inicio de sesión con PIN correcto, depósitos/retiros válidos y resumen final)*[cite: 4]
- **Caso de Error / Validación:** *(Insertar imagen del bloqueo por 3 intentos fallidos de PIN o de un retiro inválido por saldo insuficiente / monto no múltiplo de 100)*[cite: 4]

### Ejercicio 2: Simulador de Préstamo
- **Caso Exitoso:** *(Insertar imagen con ingreso de datos válidos, cálculo de cuota mensual y la tabla de amortización con totales)*[cite: 4]
- **Caso de Error / Validación:** *(Insertar imagen con reintento al ingresar un monto fuera de rango o categoría no válida)*[cite: 4]

---
*(Nota: Las capturas de pantalla están agregadas en la sección correspondiente del informe / repositorio).*[cite: 4]
