## Sobre o Projeto
Bem-vindo ao repositório CleanWebApiArchitecture! Este repositório contém um projeto Web API construído usando ASP.NET Core, Entity Framework, CQRS (Command Query Responsibility Segregation) e seguindo os princípios da Clean Architecture.

## Visão Geral:
Este projeto é um exemplo prático de como aplicar a Clean Architecture em uma aplicação Web API. A estrutura do código é organizada de acordo com os conceitos de Separação de Responsabilidades, Desacoplamento e Testabilidade, promovendo uma arquitetura robusta e escalável.

## Tecnologias Utilizadas:

- ASP.NET Core Web API
- Entity Framework Core
- CQRS (Command Query Responsibility Segregation)
- Clean Architecture

## Estrutura do Projeto:

- Api: Contém os controladores, configurações da API e a camada de apresentação.
- Application: Responsável por implementar os casos de uso da aplicação, incluindo manipuladores de comandos e consultas.
- Domain: Contém as entidades, agregados e lógica de negócios da aplicação.
- Infrastructure: Inclui implementações concretas de interfaces, como repositórios e serviços externos.
- Persistence: Configurações e implementações específicas para persistência de dados usando o Entity Framework Core.
- Tests: Testes unitários para garantir a robustez e qualidade do código.
