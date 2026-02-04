# Amazon Clone - Fullstack Project

Este es un proyecto de práctica que es un clon de Amazon. Mi objetivo es implementar una arquitectura robusta, escalable y mantenible utilizando las últimas tecnologías de .NET y React.

## 🚀 Estado del Proyecto
- **Backend:** En desarrollo (Implementando servicios base y autenticación).
- **Frontend:** Pendiente (Próximamente con React).

---

## 🏗️ Arquitectura: Clean Architecture
El backend está construido siguiendo los principios de **Clean Architecture**, separando las responsabilidades en capas para facilitar las pruebas y el mantenimiento:

- **Domain:** Entidades, excepciones y lógica de negocio pura.
- **Application:** Casos de uso, interfaces de servicios y **MediatR** para el manejo de comandos y consultas (CQRS).
- **Infrastructure:** Implementación de persistencia (Entity Framework Core), servicios externos (Stripe) y configuración de base de datos.
- **API:** Controladores, Middlewares y configuración del contenedor de dependencias (ASP.NET Core 10).



---

## 🛠️ Tecnologías Utilizadas

### Backend
* **Lenguaje:** C# (.NET 9/10)
* **Framework:** ASP.NET Core Web API
* **Autenticación:** ASP.NET Core Identity (JWT para manejo de sesiones)
* **Patrones:** CQRS con **MediatR**
* **Pagos:** **Stripe API** para el flujo de checkout.
* **Base de Datos:** SQL Server / Entity Framework Core.
* **Correos:** MailKit / SendGrid para notificaciones.

### Frontend (Próximamente)
