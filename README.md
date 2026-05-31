# 🚀 CRUD C# .NET API

Projeto de estudo focado na construção de uma API RESTful com C#, .NET 10 e Entity Framework Core.
O objetivo é explorar os fundamentos de Minimal APIs, manipulação de estados no banco de dados
e operações CRUD.

## 🛠️ Tecnologias

| Tecnologia | Detalhe |
|---|---|
| Linguagem | C# 13 |
| Framework | .NET 10 |
| ORM | Entity Framework Core 10 |
| Banco de dados | SQLite (migrando para PostgreSQL) |
| Documentação | Swagger / OpenAPI |

## ✨ Funcionalidades

Operações CRUD para a entidade `Usuario`:

| Método | Rota | Descrição |
|---|---|---|
| `POST` | `/person` | Cria um usuário com `Guid` único |
| `GET` | `/person` | Lista todos os usuários |
| `PUT` | `/person/{id}` | Atualiza o nome de um usuário |
| `DELETE` | `/person/{id}` | Soft Delete — marca como "Desativado" |

## 📋 Pré-requisitos

- [.NET SDK 10.0+](https://dotnet.microsoft.com/download)
- Git
- VS Code ou outra IDE de sua preferência

## 🚀 Como rodar

1. **Clone o repositório**
```bash
   git clone https://github.com/SeuUsuario/crud-csharp-estudo.git
   cd crud-csharp-estudo
```

2. **Restaure as dependências**
```bash
   dotnet restore
```

3. **Aplique as migrações**
```bash
   dotnet ef database update
```

4. **Inicie a aplicação**
```bash
   dotnet run
```

5. **Acesse a documentação**
```
   http://localhost:5099/swagger
```
