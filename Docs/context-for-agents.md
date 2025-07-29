🔗 Contexto de conversación: [ChatGPT - Diseño desde Cero](https://chatgpt.com/g/g-p-685ff79c67a48191a56aaf3db17032d8-diseno-desde-cero/c/6888d6a2-dd28-832f-93c6-ba21ee15f029)

# 🤖 Contexto para Agentes de IA

Este proyecto es una API REST en .NET 8 que expone recursos de una base de datos SQL Server existente mediante un enfoque Database First.

## 💡 Objetivo

Brindar endpoints RESTful para una aplicación frontend construida en React. Se aplica arquitectura por capas para facilitar mantenimiento, extensibilidad y comprensión por humanos y agentes de IA.

## 🔧 Tecnologías

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core (Database First)
- AutoMapper
- FluentValidation
- Serilog
- Swagger

## 📁 Estructura

- `Api/`: contiene los controladores, middlewares y configuración de la API.
- `Application/`: lógica de negocio, validaciones, DTOs, mapeos.
- `Domain/`: entidades generadas desde la base de datos existente.
- `Infrastructure/`: acceso a datos y configuración de servicios externos.
- `Docs/`: documentación técnica y explicativa, incluyendo este archivo.

## 🧠 Notas para IA

- Toda entidad tiene su correspondiente DTO para desacoplar la API.
- FluentValidation está aplicado en los servicios de `Application/Validators`.
- AutoMapper es usado para mapear entre entidades y DTOs.
- Serilog está configurado en `Infrastructure/Logging`.

## ⚠️ Instrucciones para modificaciones automáticas

- No modificar entidades de `Domain/` directamente (se regeneran desde la DB).
- Cualquier lógica debe ir en `Services`, nunca en el controlador.
- Las validaciones deben implementarse como `AbstractValidator<T>` en `Validators/`.
