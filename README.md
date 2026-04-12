# SCUB.API

Sistema de Cadastro de Usuários da Biblioteca (SCUB)

## 📌 Descrição

O SCUB.API é uma aplicação backend desenvolvida em .NET com o objetivo de gerenciar o cadastro de usuários de uma biblioteca.

A API permite realizar operações completas de CRUD (Create, Read, Update, Delete), possibilitando o registro, consulta, atualização e remoção de usuários.

Este sistema foi projetado para ser consumido por diferentes interfaces, como aplicações web, mobile ou sistemas internos.

---

## 🚀 Funcionalidades

- Cadastro de usuários
- Busca por nome e/ou CPF
- Atualização de dados cadastrais
- Remoção de usuários

---

## 📊 Estrutura do Cadastro

Cada usuário possui os seguintes dados:

- Data e hora do cadastro
- Nome completo
- Telefone
- CPF
- Nome do responsável (opcional)
- Nome da escola (opcional)
- Data de nascimento
- Endereço (rua)
- Bairro
- Cidade

---

## 🛠️ Tecnologias utilizadas

- .NET (ASP.NET Core Web API)
- C#
- Entity Framework Core (em configuração)
- Banco de dados (a definir)

---

## 📂 Estrutura do Projeto

```

ScubApi/
│
├── Controllers/
├── Models/
│   └── Usuario.cs
├── Program.cs
└── ...

```

---

## ▶️ Como executar o projeto

1. Clone o repositório:

```

git clone <url-do-repositorio>

```

2. Acesse a pasta do projeto:

```

cd ScubApi

```

3. Execute a aplicação:

```

dotnet run

```

4. Acesse o Swagger:

```

[https://localhost:xxxx/swagger](https://localhost:xxxx/swagger)

```

---

## 📌 Status do Projeto

🚧 Em desenvolvimento

---

## 📎 Observações

Este projeto está sendo desenvolvido com foco educacional e prática de conceitos de desenvolvimento backend com .NET.

---

## 👨‍💻 Autor

Kleber Gabriel Nascimento da Silva