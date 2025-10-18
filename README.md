# 💹 Investment Advisor API

API desenvolvida em **C# com ASP.NET Core e Entity Framework**, focada em gerenciamento de um cadastro de **tipos de investimento**.

## 🚀 Tecnologias
- ASP.NET Core Web API
- Entity Framework Core
- LINQ
- Swagger (documentação automática)
- **SQLite** (banco de dados em arquivo, `investment.db`)

## 📂 Estrutura
- `**Models/**` → Entidades do sistema (ex: `Investment.cs`)
- `**Controllers/**` → Endpoints da API (ex: `InvestmentController.cs`)
- `**Services/**` → Lógica de negócios (ex: `InvestmentService.cs`)
- `**Data/**` → Contexto e persistência (ex: `ApiDbContext.cs`)

## 🔗 Endpoints principais
| Método | Rota | Descrição |
|--------|------|------------|
| GET | /api/Investment | Lista todos os investimentos |
| GET | /api/Investment/{id} | Busca investimento por ID |
| POST | /api/Investment | Cadastra novo investimento |
| PUT | /api/Investment/{id} | Atualiza investimento |
| DELETE | /api/Investment/{id} | Remove investimento |

## 🧠 LINQ
Utilizado no **InvestmentService** para todas as consultas ao banco de dados, como `FirstOrDefaultAsync` e `ToListAsync`.

## 🧩 Diagrama da Arquitetura
```text
[Cliente (Swagger)]
       |
       v
[Requisição HTTP (GET, POST, etc.)]
       |
       v
[InvestmentController]  <- (Endpoint)
       |
       v
[InvestmentService]     <- (Lógica de negócios / LINQ)
       |
       v
[ApiDbContext]          <- (Entity Framework)
       |
       v
[investment.db (SQLite)]  <- (Banco de Dados)
```

## 👩‍💻 Autoria

Feito por:
- Julia Amorim     RM99609
- Lana Leite       RM551143
- Matheus Cavasini RM97722
