# Calculadora De Windows
## Introducción
Este repositorio esta destinado a mostrar poder de la Programación Orientada a Objetos (POO), mostrando una calculadora similar a la de nos ofrece Windows, incluyendo un historial con las ultimas operaciones realizadas
## Entorno de Desarrollo y de Ejecución
### Entorno de Desarrollo
Este proyecto posee las siguientes caracteristicas de desarrollo:
* A nivel código, este proyecto fue Desarrollado en Visual Studio 2019
* A nivel base de datos, se utilizó SQL Server
* Inicialmente, este proyecto fue desarrollado en VB.net Windows Forms, y esta abierto a otros lenguajes
### Entorno de Ejecución
* Este proyecto esta probando en Windows 10

### Limitaciones en esta versión
* Solo tiene las operaciones elementales (Suma, Resta, Multiplicación y División)
* Los números tienen que ser ingresados vía mouse

## Instalación y Uso
Requisitos:
* Tener SQL Server
* Tener Windows 10
### Instalación
1. Correr el script de creación de la base de datos ( *./Scripts Base de Datos/Scripts Master* )
2. Correr el script de creación de la tabla de historial ( *./Scripts Base de Datos/Scripts HistorialEjecucion* )
3. Configurar el archivo app.config con el Conection String correspondiente
4. Ejecutar el programa (*Calculadora.exe*)

#### Uso
1. Ejecutar el programa (*Calculadora.exe*)
2. Digitar el primer número
3. Seleccionar la operación a realizar
4. Digitar el segundo número
5. Presionar el botón =
## Diagramas
### Diagrama de Clases
![alt text](https://github.com/webber0/CalculadoraDeWindows/blob/main/Diagramas/Diagrama%20de%20Clases.png?raw=true)
### Diagrama de Arquitectura