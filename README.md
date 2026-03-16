# TruequeU Marketplace API
## Módulo: Chat, Reportes y Moderación

Este módulo implementa el sistema de comunicación y moderación dentro de la plataforma **TruequeU**. Permite que los usuarios interactúen a través de chats asociados a publicaciones, reporten comportamientos indebidos y que los administradores moderen el contenido.

### Arquitectura

El módulo sigue una **arquitectura en capas** típica de ASP.NET:

* **Controllers**: Exponen los endpoints de la API.
* **Services**: Contienen la lógica de negocio.
* **Interfaces**: Definen los contratos de los servicios.
* **Models**: Representan las entidades de la base de datos.
* **Entity Framework Core**: Gestiona la persistencia de datos mediante migraciones.

### Modelos involucrados

El sistema utiliza las siguientes entidades:

* **Chat**: Conversación asociada a una publicación.
* **Message**: Mensajes enviados dentro de un chat.
* **Report**: Reportes realizados por usuarios sobre publicaciones o usuarios.
* **ModerationAction**: Acciones de moderación realizadas por administradores.
* **User**: Usuario del sistema.
* **Listing**: Publicación dentro del marketplace.

### Funcionalidades implementadas

#### Sistema de Chat

* Crear un chat entre comprador y vendedor.
* Enviar mensajes dentro de un chat.
* Obtener todos los mensajes de un chat.

#### Sistema de Reportes

* Permite a los usuarios reportar:

  * publicaciones
  * otros usuarios
* Cada reporte contiene:

  * motivo
  * comentario
  * estado del reporte

#### Sistema de Moderación

Los administradores pueden:

* ocultar publicaciones
* suspender usuarios
* registrar acciones de moderación en la base de datos

### Endpoints principales

#### Chat

Crear chat

POST /api/chat/start

Parámetros:

* listingId
* buyerId
* sellerId

Enviar mensaje

POST /api/chat/send

Parámetros:

* chatId
* senderId
* content

Obtener mensajes de un chat

GET /api/chat/{chatId}

---

#### Reportes

Crear reporte

POST /api/report

Parámetros:

* reporterId
* listingId (opcional)
* reportedUserId (opcional)
* reason
* comment

Obtener todos los reportes

GET /api/report

---

#### Moderación

Ocultar publicación

POST /api/moderation/hide-listing

Suspender usuario

POST /api/moderation/suspend-user

### Base de datos

La persistencia de datos se maneja con **Entity Framework Core**.
Las tablas se generan mediante **migraciones** a partir de los modelos definidos en el proyecto.

Para crear la base de datos:

1. Crear migración

```
Add-Migration InitialCreate
```

2. Aplicar migración

```
Update-Database
```

Esto generará automáticamente las tablas y relaciones en la base de datos SQL Server.

### Notas técnicas

Durante el desarrollo se resolvió un conflicto de **Multiple Cascade Paths** en SQL Server configurando algunas relaciones con:

```
DeleteBehavior.Restrict
```

Esto evita ciclos de eliminación en cascada entre entidades relacionadas.

### Estado del módulo

El módulo se encuentra **completamente implementado a nivel de backend** e integrado con la base de datos mediante Entity Framework Core.
Las pruebas completas dependen de la existencia de usuarios y publicaciones creadas por otros módulos del sistema.
