# Sistema de Atividades API

Esta é uma API RESTful ASP.NET Core que fornece funcionalidades para um sistema de atividades. Os recursos principais incluem o cadastro de atividades e usuários, com a capacidade de vincular atividades a usuários. Você pode usar o Swagger ou o Postman para interagir com esta API.

## Pré-requisitos

Antes de executar a API, certifique-se de que você tenha o seguinte instalado:

### Ferramentas

- [.Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/)
- [Postman](https://www.postman.com/downloads/) (opcional)

### Pacotes do NuGet v6
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Swashbuckle.AspNetCore

## Uso da API

### A API oferece os seguintes endpoints tanto para Usuários quanto para Atividades:

- POST /api/Usuario/InserirUsuario: Crie um novo usuário.
- GET /api/Usuario/ListarUsuario: Obtenha a lista de todos os usuários.
- GET /api/Usuario/BuscarPorId: Obtenha os detalhes de um usuário específico.
- PUT api/Usuario/AtualizarUsuario: Atualiza um usuário.
- DELETE /api/Usuario/ApagarUsuario: Apaga um usuário.

![gifApi](https://github.com/Jonas-Emir/API_SistemaDeAtividades/assets/89087399/d638a544-8b44-422e-977b-73c831dd666b)


## Configuração do Projeto

1. Clone este repositório:

   ```bash
   git clone https://github.com/Jonas-Emir/API_SistemaDeAtividades.git
   cd API_SistemaDeAtividades

2. Restaure as dependências do projeto:
   ```bash
    dotnet restore

3. Execute as migrações do banco de dados para criar o banco de dados (opcional):
   ```bash
    dotnet ef database update

4. Inicie a aplicação:
   ```bash
   dotnet run

5. Necessário configurar o arquivo appsettings.json para conexão com banco de dados.

## Contribuição

Sinta-se à vontade para contribuir com melhorias para este projeto. Crie um fork deste repositório, faça as alterações e envie um pull request :smile:	












  
