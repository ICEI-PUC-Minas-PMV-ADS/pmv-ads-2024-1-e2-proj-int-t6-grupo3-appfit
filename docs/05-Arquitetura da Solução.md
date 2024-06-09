# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

Diagrama de conceitual de classes do projeto.


![Diagrama de Classes](img/class_diagram.png)

## Modelo ER (Projeto Conceitual)

Diagrama de conceitual de entidades-relações do projeto.


![Diagrama de Classes](img/er_conceptual_diagram.png)



## Projeto da Base de Dados

![Base de Dados](img/BDfitappEsse.png)

## Tecnologias Utilizadas

Se utilizará a suite da Google Cloud Platform (GCP) que oferece flexibilidade e simplicidade para a iteração web. Com firebase podemos ocupar as libs que já provem de manejo de sessão e credenciais para usuário, além de hosting flexível e serverless. Se requere levantar serviços para a iteração com o banco de dados relacional, e agregando métodos para gerar logs e poder realizar debug do aplicativo quando necessário.


![Diagrama de Classes](img/er_conceptual_diagram.png)


## Hospedagem

O website será hospedado em Google Cloud Platform potenciado por Firebase para web e apis. Com backend em uma db cloud sql com psql (cloud sql).
