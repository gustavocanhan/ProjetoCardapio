# Projeto Cardápio

Este repositório reúne meu **primeiro projeto completo integrando 3 camadas**:

- **API ASP.NET Core** (backend + banco de dados)
- **Sistema Desktop em C# (Windows Forms)** para cadastro e manutenção
- **Frontend Web em Next.js** para visualização do cardápio

A ideia principal foi praticar uma arquitetura de sistema real: **uma API central**, um cliente de **administração** (desktop) e um cliente de **consulta** (web).

---

## 🎯 Objetivo do projeto

Este projeto foi criado para aprender e demonstrar, na prática:

- Criação de API REST com ASP.NET Core
- Persistência com Entity Framework Core + MySQL
- Integração entre aplicações diferentes consumindo a mesma API
- Organização por camadas (dados, regras e interface)
- Construção de frontend moderno com Next.js

Em resumo: foi um laboratório completo para treinar desenvolvimento full stack com .NET + React/Next.

---

## 🧱 Estrutura do repositório

```txt
ProjetoCardapio/
├── API/
│   └── Cardapio.Api/              # API ASP.NET Core + EF Core + MySQL
├── Sistema/
│   └── SistemaCardapio/           # Sistema desktop Windows Forms (C#)
└── Frontend/
    └── cardapiofrontend/          # Frontend web Next.js
```

---

## ⚙️ Tecnologias utilizadas

### Backend (API)
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- Pomelo MySQL Provider
- Swagger

### Sistema Desktop
- C#
- Windows Forms
- .NET `net10.0-windows` (conforme projeto atual)

### Frontend
- Next.js 16
- React 19
- TypeScript
- Tailwind CSS

### Banco de dados
- MySQL

---

## 🔌 Como os sistemas se integram

1. A **API** expõe endpoints de categorias e itens.
2. O **Sistema Desktop** consome a API para cadastrar/editar/excluir categorias e itens.
3. O **Frontend** consome a mesma API para exibir os dados em formato de cardápio com filtros e busca.

Assim, tanto desktop quanto web compartilham o mesmo backend e a mesma base de dados.

---

## 📦 Pré-requisitos

Antes de rodar, instale:

- [Git](https://git-scm.com/)
- [.NET SDK 8](https://dotnet.microsoft.com/download)
- [.NET SDK 10 (preview, opcional para o sistema desktop)](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Node.js 20+](https://nodejs.org/)
- [MySQL Server 8+](https://dev.mysql.com/downloads/mysql/)

> Observação: o projeto desktop está em `net10.0-windows`, então ele roda em ambiente Windows.

---

## ⬇️ Como clonar o repositório

```bash
git clone <URL_DO_SEU_REPOSITORIO>
cd ProjetoCardapio
```

---

## 🗄️ Configuração do banco (MySQL)

Crie o banco:

```sql
CREATE DATABASE cardapiodb;
```

A API usa uma connection string em `appsettings.json`. Ajuste usuário e senha de acordo com seu MySQL.

Arquivo:

- `API/Cardapio.Api/Cardapio.Api/appsettings.json`

Exemplo atual:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=cardapiodb;User=root;Password=1234;"
}
```

### Popular com dados iniciais (seed)

Existe um arquivo pronto com inserts:

- `Sistema/SistemaCardapio/SistemaCardapio/seed_cardapio_completo.txt`

Basta executar esse script no seu MySQL após criar as tabelas/migrations.

---

## 🔐 Variáveis de ambiente (.env)

### Frontend (obrigatório)

No diretório `Frontend/cardapiofrontend`, crie o arquivo `.env.local`:

```env
NEXT_PUBLIC_API_URL=http://localhost:5254/api
```

> Sem essa variável, o frontend não inicia corretamente.

### API (opcional, recomendado)

Hoje a API está lendo connection string direto de `appsettings.json`.
Se quiser evoluir para ambiente mais seguro, você pode mover a conexão para variável de ambiente ou User Secrets.

---

## ▶️ Como rodar o projeto completo

Abra **3 terminais** (API, desktop e frontend).

### 1) Rodar a API

```bash
cd API/Cardapio.Api/Cardapio.Api
dotnet restore
dotnet ef database update
dotnet run
```

API padrão: `http://localhost:5254`

Swagger (desenvolvimento):

- `http://localhost:5254/swagger`

### 2) Rodar o sistema desktop (Windows Forms)

No Windows:

```bash
cd Sistema/SistemaCardapio/SistemaCardapio
dotnet restore
dotnet run
```

O desktop usa a URL da API definida em:

- `Sistema/SistemaCardapio/SistemaCardapio/App.config`

Chave:

```xml
<add key="ApiBaseUrl" value="http://localhost:5254/api/" />
```

### 3) Rodar o frontend (Next.js)

```bash
cd Frontend/cardapiofrontend
npm install
npm run dev
```

Acesse:

- `http://localhost:3000`

---

## 📚 Endpoints principais da API

### Categorias
- `GET /api/Categorias`
- `GET /api/Categorias/{publicId}`
- `POST /api/Categorias`
- `PUT /api/Categorias/{publicId}`
- `DELETE /api/Categorias/{publicId}`

### Itens
- `GET /api/Item`
- `GET /api/Item/{publicId}`
- `POST /api/Item`
- `PUT /api/Item/{publicId}`
- `DELETE /api/Item/{publicId}`

---

## 🧠 Fluxo de uso sugerido

1. Suba a API e garanta conexão com MySQL.
2. Cadastre categorias e itens pelo sistema desktop.
3. Abra o frontend para visualizar o cardápio.
4. Use filtro por categoria e busca para encontrar itens.

---

## 🚀 Próximas melhorias (ideias)

- Autenticação (JWT) para proteger cadastros
- Upload de imagens dos itens

---

## 👨‍💻 Autor

- Gustavo Canhan

Projeto desenvolvido como estudo prático de integração entre backend, desktop e frontend.
