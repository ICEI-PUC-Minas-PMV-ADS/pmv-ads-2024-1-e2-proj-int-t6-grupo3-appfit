# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A tela deve a presentar a funcionalidade de cadastro do usuário, caso ele não tenha uma conta |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passo 1 	| - Acessar o navegador e inserir: https://fitapp2024.azurewebsites.net/Usuario/Registro
| Passo 2   | - Criar conta, preenchendo os dados solicitados(nome, e-mail, senha e confirmação de senha)
| Passo 3   | - Clicar em "Registrar" 
|Critério de Êxito | - O cadastro foi realizado com sucesso e o usuário poderá entrar com a conta cadastrada. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passo 1	| - Acessar o navegador e inserir: https://fitapp2024.azurewebsites.net/
| Passo 2   | - Preencher o campo de e-mail e senha
| Passo 3   | - Clicar no botão "Entrar" 
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Filtrar Exercícios	|
|Requisito Associado | - A aplicação deve permitir que o usuário filtre pelos exercícios
| Objetivo do Teste 	| Verificar se o usuário consegue filtrar por determinado exercício. |
| Passo 1	| - Acessar o navegador e inserir: https://fitapp2024.azurewebsites.net/  
| Passo 2   | - Realizar o Login e clicar em "Entrar" 
| Passo 3   | - Na página inicial, clicar em "Exercícios" e depois em "Selecione" e depois em "Concluir", no exercício que o usuário realizar.
| Passo 4   | - Clicar em "Histórico" 
Critério de Êxito | - O histórico de exercícios realizados foi visto com sucesso. |
    |   |
| Caso de Teste 	| CT-04 – Filtrar por receitas 	|
|Requisito Associado | - A aplicação deve permitir a filtragem de receitas baseada no número de calorias
| Objetivo do Teste 	| Verificar se o usuário consegue filtrar por determinado receita baseada no número de calorias. |
| Passo 1	| - Acessar o navegador e inserir: https://fitapp2024.azurewebsites.net/  
| Passo 2   | - Realizar o Login e clicar em "Entrar" 
| Passo 3   | - Na página inicial, clicar em "Receitas" 
| Passo 4   | - Selecionar um numeral de calorias mínimas e calorias máximas 
Critério de Êxito | - As receitas foram filtradas com sucesso. |



 

