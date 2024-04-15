# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Administrar Exercícios	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de administrar os exercícios a serem criados. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar e acessar o valor criado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site e realizar login <br> - Clicar no botão "Exercícios" <br> - Preencher o campo com os valores <br> - Guardar <br> - Clicar em "Ver" |
|Critério de Êxito | - O evento foi criado e acessado com sucesso. |
| Caso de Teste 	| CT-04 – Administrar Receitas	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de administrar as receitas a serem criados. |
| Objetivo do Teste 	| Verificar se o usuário consegue criar e acessar o valor criado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site e realizar login <br> - Clicar no botão "Receitas FIT" <br> - Preencher o campo com os valores <br> - Guardar <br> - Clicar em "Ver" |
|Critério de Êxito | - O evento foi criado e acessado com sucesso. |
| Caso de Teste 	| CT-05 – Utilizar o forum	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de postar mensagens e iteractuar. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar um post e agregar um comentário. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site e realizar login <br> - Clicar no botão "Fórum" <br> - Clicar em "Novo Post" <br> - Preencher os campos e guardar <br> - Clicar em "Adicionar Comentario" |
|Critério de Êxito | - O evento foi criado e acessado com sucesso. |


 

