# Sistema de Gestión de Farmacia

##  Especificaciones del Sistema (Spec Driven Development)

### 1. Objetivos del Proyecto
* Desarrollar una aplicación de escritorio (.NET) para automatizar el control de inventario y ventas de una farmacia.
* Garantizar un manejo seguro de los datos de medicamentos y clientes.

### 2. Requisitos Funcionales (Lo que debe hacer el software)
* **Gestión de Inventario (CRUD):** El sistema debe permitir registrar, editar, listar y eliminar medicamentos (Nombre, Lote, Fecha de vencimiento, Stock, Precio).
* **Control de Ventas:** Registrar transacciones en tiempo real, restar productos del inventario y generar un comprobante/recibo.
* **Alertas de Stock:** El sistema debe notificar visualmente si un medicamento tiene menos de 10 unidades disponibles.

### 3. Modelo de Datos (Estructura interna)
* Para la búsqueda eficiente de medicamentos por nombre o código, se implementará una estructura de datos indexada (por ejemplo, un árbol binario de búsqueda o tablas hash).

### 4. Interfaz de Usuario (UI)
* Panel principal con pestañas: Inventario, Ventas y Reportes.
