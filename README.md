# TiendaAPI

API REST desarrollada con ASP.NET Core 8 y Entity Framework Core, conectada a SQL Server. Permite gestionar productos de una tienda mediante operaciones CRUD completas.

## Tecnologías utilizadas

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- C#

## Endpoints

| Método | Ruta | Descripción |
|--------|------|-------------|
| GET | /api/productos | Obtener todos los productos |
| GET | /api/productos/{id} | Obtener producto por ID |
| POST | /api/productos | Crear nuevo producto |
| PUT | /api/productos/{id} | Actualizar producto |
| DELETE | /api/productos/{id} | Eliminar producto |

## Configuración

1. Clona el repositorio
2. Copia `appsettings.example.json` a `appsettings.json`
3. Actualiza la cadena de conexión con tu servidor SQL Server
4. Ejecuta el proyecto con Visual Studio
