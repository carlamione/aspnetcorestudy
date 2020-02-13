# aspnetcorestudy
## Asp Net Core Study Dot.Net Core

Este projeto é um estudo de .Net Core.


### Lista de Passos para chegar a este projeto
1.  Criar a pasta
2.  dotnet new web (projeto mais simples possível)
3.  dotnet add package Microsoft.AspNetCore.Mvc
4.  alterar o startup
5.  dotnet add package  Microsoft.EntityFrameworkCore.SqlServer
6.  adicionar as classes de entidades e a classe de contexto
7.  dotnet build
8.  dotnet-ef migration add RH6  (RH6 é apenas um nome para os scripts de migração)
9.  dotnet-ef database update
10. dotnet run

11. adicionar as views que permitam fazer o crud
12. adicionar o código de backend para fazer o crud funcionar
13. melhorar as views usando layouts e partials views
14. melhorar as views usando bootstrap
15. melhorar as views usando algum tema


### Lista de Passos para usar esse projeto

1. clonar a pasta

    git clone https://github.com/carlamione/aspnetcorestudy.git

2. Entrar na pasta aspnetcorestudy e buildar o projeto

    dotnet build

3. criar um banco vazio
4. Alterar a string de conexão no arquivo appsetings.json de forma que aponte para o banco criado
5. Atualizar o banco criado com o projeto (o passo de adicionar uma migration não é necessário já que eles ja foram realizados: os scripts de migration já estão na pasta migrations).

    dotnet-ef database update

6. dotnet run
