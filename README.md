# API-Rest-Net
Proyecto con código de prueba de NET con librerías estándares

## Librerías, patrones y arquitecturas utilizadas

- Entity Framework
- Entity Framework SQLite (Se puede reemplazar por SQL Server, pero elegí Lite porque así se puede correr sin conectar con servidores)
- Fluent
- AutoMapper
- ApiController
- Patrón Repository
- Patrón Service
- Migraciones de base de datos
- Unit of Work

## Capa de datos

### Sub-capa de modelos

La sub-capa o capa de modelos, sólo se tienen las clases de:
- POCOs (Plain Old CLR Objects)
- Configuración de POCOs

### Sub-capa de repositorios

Contiene:

- Archivo de contexto de base de datos.
- Unit of Work.
- Interfaces e implementaciones de repositorios.

## Capa de dominio

- Servicios
- Automapper

## Capa de presentación

- Controladores Rest
- Validadores
