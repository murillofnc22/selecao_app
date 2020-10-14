# App Seleção
## Login
Login: Admin
Senha: admin

Não foi feito um cadastro de usuários, então eu crio esse automaticamente no primeiro login, a senha é salva como um MD5 unindo nome de usuário e a senha.
## Configuração
Para executar o projeto basta criar o banco usando o script SelecaoDB.sql que está dentro da pasta scripts e depois atualizar o Entity para a connection string da máquina que for abrir o projeto.

## Mapa mental com o fluxo do projeto

![Mapa mental do projeto.](https://i.ibb.co/dLgqHXb/min-Map-Selecao.png)

## Arquitetura
### SelecaoApp.Domain
Usei esse projeto de biblioteca de classes para criar os Modelos do banco de dados.
### SelecaoApp.Services
Nessa biblioteca de classes eu criei a abstração do CRUD
### SelecaoApp.Infra
É onde eu faço a implementação das operações com Banco de Dados e faço o mapeamento usando Entity. As operações de Insert, Delete, Update foram feitas usando o Entity, já as consultas dos DataGridViews e das pesquisas de tela foram feitas usando ADO.
### SelecaoApp
Essa é a camada onde ficam as telas do sistema e eu uso as abstrações criadas nas camadas anteriores para concluir as operações.
