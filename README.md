# 📘 Sistema de Gerenciamento de Alunos

## 📌 Descrição
Este projeto é uma aplicação **ASP.NET Core Web API** desenvolvida em **C#** com **Entity Framework Core**, que permite o **gerenciamento de alunos** através de operações CRUD (Create, Read, Update, Delete).  

A API expõe endpoints para criar, listar, atualizar e remover alunos, salvando as informações em um banco de dados **SQLite**.  

---

## ⚙️ Tecnologias Utilizadas
- .NET 8 (compatível com 7 ou 6)
- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQLite
- Swagger (para documentação e testes dos endpoints)

---

## 🚀 Como Executar o Projeto

### 1. Clonar o repositório
```bash
git clone https://github.com/seu-usuario/gerenciamento-alunos-api.git
cd gerenciamento-alunos-api
```
### 2. Restaurar pacotes
No diretório do projeto, rode:
```bash
dotnet restore
```

### 3. Criar o banco de dados
Como estamos usando o **Entity Framework Core** com **SQLite**, precisamos criar a base de dados com migrations.

1. Adicione uma migration inicial:
```bash
dotnet ef migrations add InitialCreate
```

2. Aplique a migration para gerar o arquivo banco.db:
```bash
dotnet ef database update
```

### 4. Rodar a aplicação
Agora você pode subir a API:
```bash
dotnet run
```
Se tudo estiver correto, você verá algo como:
```bash
Now listening on: http://localhost:5000
Now listening on: https://localhost:5001
```

### 5. Acessar a API
- **Swagger UI (para testar endpoints)**:  
  👉 [http://localhost:5000/swagger](http://localhost:5000/swagger)  
  ou  
  👉 [https://localhost:5001/swagger](https://localhost:5001/swagger)


  No Swagger você pode testar todos os endpoints CRUD:

- **POST /api/alunos** → Criar aluno  
  Exemplo de corpo da requisição:
  ```json
  {
    "nome": "Ana Souza",
    "idade": 21,
    "curso": "Ciência da Computação"
  }

  ```

- **GET /api/alunos** → Listar todos os alunos
- **POST /api/alunos** → Criar aluno
- **PUT /api/alunos/{id}** → Atualizar aluno existente
- **DELETE /api/alunos/{id}** → Deletar aluno

## 👥 Equipe
- Julia Amorim RM99609
- Lana Leite RM551143
- Matheus Cavasini RM97722
