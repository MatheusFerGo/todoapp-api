📝 TodoApp API (Estudo)

Este é um projeto de estudo para praticar C#, .NET 8, DDD, SOLID e boas práticas de arquitetura.
A aplicação é uma API simples de gerenciamento de tarefas (to-do list), servindo como base para aprender desde a organização do código até o deploy.

🚀 Tecnologias utilizadas

C# (.NET 8)

ASP.NET Core Web API

Swagger (documentação e testes da API)

Arquitetura DDD (Domain-Driven Design)

Princípios SOLID

Visual Studio 2022

📂 Estrutura do Projeto
TodoApp.sln
├── TodoApp.Domain       # Entidades e regras de negócio
├── TodoApp.Application  # Casos de uso (use cases)
├── TodoApp.Infrastructure # Infraestrutura (ex: persistência)
└── TodoApp.API          # Camada de apresentação (endpoints REST)

⚡ Como rodar o projeto localmente

Clone o repositório:

git clone https://github.com/seu-usuario/todoapp-api.git
cd todoapp-api


Abra a solução no Visual Studio 2022 ou rode via CLI:

dotnet build
dotnet run --project TodoApp.API


Acesse a API:

API base: https://localhost:7198

Swagger: https://localhost:7198/swagger

✅ Funcionalidades atuais

 Estrutura inicial da API

 Swagger configurado

 CRUD de tarefas (to-do items)

 Integração com banco de dados (via Supabase)

 Deploy em ambiente cloud

🎯 Objetivo

Este projeto não é destinado para produção.
O foco é estudo e aprendizado prático em:

Arquitetura de software (DDD e SOLID)

Boas práticas no desenvolvimento em C#

Construção de APIs RESTful

Deploy em ambiente real (Supabase + GitHub Actions futuramente)

📌 Próximos passos

Implementar casos de uso (Create, Update, Delete, List To-do Items)

Configurar persistência com Supabase

Criar front-end para consumir a API

✍️ Autor: [Seu Nome Aqui]
📖 Propósito: Projeto de estudo em arquitetura, APIs e deploy.
