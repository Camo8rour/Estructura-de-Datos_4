# 🌳 **Árboles Binarios de Búsqueda - Visualización y Recorridos** 🖥️

## 🎯 Descripción

Tiene como objetivo ayudar a comprender mejor la teoría de los **Árboles Binarios de Búsqueda (ABB)** mediante una aplicación en **C#** con **Windows Forms**. A través de dos escenarios interactivos, el usuario podrá visualizar, diseñar y recorrer un árbol binario de búsqueda, observando cómo cambian los datos al aplicar distintos tipos de recorrido.

## 🛠️ Requisitos y Funcionalidades

### 🚪 **Interfaz de Acceso y Seguridad**
- **Pantalla de inicio** con los siguientes datos:
  - Nombre de la aplicación.
  - Nombre del estudiante.
  - Fecha de realización del proyecto.
  - **Contraseña** enmascarada (valor: **unad**).

Al ingresar la contraseña correcta, el usuario accede a un **menú principal** para seleccionar uno de los dos escenarios.

### 🧠 **Escenarios Interactivos**

#### 1️⃣ **Escenario 1: Visualización y Recorridos de un Árbol Binario de Búsqueda (ABB)**

Este escenario permite al usuario **diseñar** un árbol binario de búsqueda y realizar los siguientes **recorridos**:

**Datos para crear el árbol (ver imagen 3):**
- Se utiliza un conjunto de datos iniciales que el usuario debe ingresar en la interfaz gráfica para formar el árbol.

**Opciones del menú:**
- **Gráfica**: Muestra la visualización gráfica del árbol binario de búsqueda que el usuario ha diseñado.
- **Recorridos**: Se despliega un submenú con tres tipos de recorrido:
  - **Preorden**: Muestra los datos de este recorrido debajo de la gráfica.
  - **Inorden**: Muestra los datos de este recorrido, que, en el caso de un ABB, es una secuencia ordenada de menor a mayor.
  - **Postorden**: Muestra los datos de este recorrido debajo de la gráfica.
- **Regresar**: Regresa al **menú principal**.

Es importante que el nodo raíz de la gráfica represente el primer dato del recorrido en **preorden**.

#### 2️⃣ **Escenario 2: Creación de un Árbol Binario a partir de los Recorridos**

Este escenario permite al usuario **crear un árbol binario de búsqueda** a partir de tres secuencias de recorridos: **preorden**, **inorden** y **postorden**. 

**Datos para construir el árbol:**
- **Preorden:** 50, 17, 12, 9, 14, 23, 19, 72, 54, 67, 76
- **Inorden:** 9, 12, 14, 17, 19, 23, 50, 54, 67, 72, 76
- **Postorden:** 9, 14, 12, 19, 23, 17, 67, 54, 76, 72, 50

**Opciones del menú:**
- **Gráfica**: Muestra la visualización gráfica del árbol binario de búsqueda generado a partir de los tres recorridos.
- **Recorridos**: Muestra las tres secuencias de recorridos (**preorden**, **inorden**, **postorden**) de los datos suministrados.
- **Regresar**: Regresa al **menú principal**.

---

## 🧑‍💻 **Cómo Funciona la Aplicación**

1. **Pantalla de Acceso:**
   - El usuario deberá ingresar la **contraseña** enmascarada (**unad**).
   - Tras ingresar la contraseña correcta, se le redirige al **menú principal**.

2. **Escenario 1 (Árbol Binario de Búsqueda):**
   - El usuario crea el árbol con los datos suministrados y puede visualizar la estructura del árbol.
   - Se permite elegir entre los **tres recorridos** para ver cómo cambian los nodos de acuerdo con el tipo de recorrido seleccionado.
   - Los datos de los recorridos se muestran debajo de la gráfica del árbol.

3. **Escenario 2 (Árbol a partir de Recorridos):**
   - El árbol binario de búsqueda se crea a partir de los tres recorridos proporcionados: **preorden**, **inorden** y **postorden**.
   - El árbol generado se muestra gráficamente, y los tres recorridos se despliegan al seleccionar la opción correspondiente.

4. **Menú Principal:**
   - Desde el menú, el usuario puede acceder a los dos escenarios y navegar entre las opciones de gráficos y recorridos.
   - Siempre puede **regresar al menú principal** desde cualquier escenario.
