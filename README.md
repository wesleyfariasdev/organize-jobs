# 🗂️ Organize Jobs

Organize Jobs é uma aplicação desenvolvida em .NET com o objetivo de ajudar profissionais autônomos e contratados a **organizar seus trabalhos, tarefas, projetos e empresas contratantes**, de forma prática e inteligente.

## 🚀 Funcionalidades

- 📁 **Cadastro de Empresas**
  - Tipo de contratação (PJ ou CLT)
  - Valor/hora pago por cada empresa
  - Relatório de atividades para prestação de contas (especialmente útil para PJ)

- 📋 **Gestão de Projetos e Tarefas**
  - Criação e acompanhamento de projetos por empresa
  - Tarefas com prioridade, status e tempo estimado
  - Organização de atividades por nível de urgência

- 📊 **Relatórios de Atividades**
  - Registro detalhado de ações realizadas por empresa
  - Geração de relatório para comprovação de horas trabalhadas

- ⚙️ **Outras funcionalidades previstas**
  - Cache de dados para otimização de performance (ex: Redis, MemoryCache)
  - Autenticação/autorização de usuários (em planejamento)

## 🧱 Arquitetura

O projeto segue o padrão **Clean Architecture**, promovendo separação de responsabilidades e escalabilidade.

**Camadas principais:**

- `Domain` – Entidades e regras de negócio
- `Application` – Services, DTOs, interfaces
- `Infrastructure` – Repositórios, banco de dados, serviços externos
- `Api` – Camada de apresentação (REST API)
- `Web` – Frontend desenvolvido com **Blazor**

## 💾 Tecnologias Utilizadas

- ✅ **.NET 8**
- ✅ **ASP.NET Core Web API**
- ✅ **Blazor WebAssembly**
- ✅ **SQL Server** como banco de dados
- ✅ **Entity Framework Core**
- ✅ **Clean Architecture**
- ✅ **Docker** (configurações futuras)
- ✅ **Cache** com Redis ou MemoryCache (em implementação)

