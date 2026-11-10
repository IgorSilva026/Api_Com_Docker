# API Piaget - Docker

Projeto acadêmico desenvolvido em ASP.NET Core 8, utilizando SQL Server, Entity Framework Core e Docker.

## Tecnologias

- C# e ASP.NET Core 8
- Entity Framework Core
- SQL Server 2022
- Docker e Docker Compose
- Swagger / OpenAPI
- Git e GitHub

## Funcionalidades

API REST para gerenciamento de registros acadêmicos, com recursos para:

- Alunos
- Escolas
- Professores
- Administração escolar

Operações CRUD (Create, Read, Update e Delete), conforme os endpoints implementados.

## Requisitos

- Docker Desktop
- Docker Compose

## Como executar

1. Clone o repositório:

   git clone https://github.com/JefersonRios125/ApiPiagetDois-Docker.git

2. Entre na pasta do projeto:

   cd ApiPiagetDois-Docker

3. Crie o arquivo de ambiente:

   Copy-Item .env.example .env

4. Edite o arquivo .env e configure uma senha forte para o SQL Server.

5. Inicie os contêineres:

   docker compose up --build -d

6. Verifique os contêineres:

   docker compose ps

## Swagger

Após iniciar a aplicação, acesse:

http://localhost:8080/swagger

## Encerrar os contêineres

docker compose down

## Segurança

O arquivo .env não deve ser enviado ao GitHub. Utilize .env.example como referência para configurar suas próprias variáveis de ambiente.

## Autor

Jeferson Rios Pereira

Projeto acadêmico - Análise e Desenvolvimento de Sistemas.
