# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - A aplicação deve permitir ao usuário criar uma conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador; <br> - Informar o endereço do site; <br> - Clicar em "Criar conta"; <br> - Preencher os campos obrigatórios (e-mail, nome, senha e confirmação de senha); <br> - Clicar em "Cadastre-se". |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-02	- A aplicação deve permitir ao usuário ao usuário realizar login. |
| Objetivo do Teste 	| Verificar se o usuário consegue efetuar login. |
| Passos 	| - Acessar o navegador; <br> - Informar o endereço do site; <br> - Clicar em "Entrar"; <br> - Preencher o campo de e-mail; <br> - Preencher o campo da senha; <br> - Clicar em "Login". |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Categorizar Notícias |
|Requisitos Associados | RF-05	- A aplicação deve permitir que as notícias sejam categorizadas com base em tópicos relevantes, como política, tecnologia, esportes etc., para que os | 
|                      |  usuários possam navegar facilmente por suas áreas de interesse; <br>                                                                                       |
|                      | RF-02	- A aplicação deve permitir ao usuário ao usuário realizar login.                                                                                     |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar, por temas, as notícias de seu interesse. |
| Passos 	| - Acessar o navegador; <br> - Informar o endereço do site; <br> - Clicar em "Entrar"; <br> - Preencher o campo de e-mail; <br> - Preencher o campo da senha; <br> - Clicar em "Login"; <br> - Filtrar por tema. |
|Critério de Êxito | - As notícias devidamente categorizadas serão exibidas ao usuário. |
|  	|  	|
| Caso de Teste 	| CT-04 – Filtrar Notícias. |
|Requisitos Associados | RF-07	- A aplicação deve ter mecanismos de busca, com filtros que considerem as preferências dos usuários; <br> | 
|                      | RF-02	- A aplicação deve permitir ao usuário ao usuário realizar login.                                         |                                             
| Objetivo do Teste 	| Verificar se o usuário consegue filtrar notícias, de acordo com as suas preferências. |
| Passos 	| - Acessar o navegador; <br> - Informar o endereço do site; <br> - Clicar em "Entrar"; <br> - Preencher o campo de e-mail; <br> - Preencher o campo da senha; <br> - Clicar em "Login"; <br> - Clicar em "Pesquisa; <br> - Aplicar filtro. |
|Critério de Êxito | - As notícias selecionadas serão exibidas ao usuário. |
|  	|  	|
| Caso de Teste 	| CT-05 – Favoritar Notícias. |
|Requisitos Associados | RF-06	- A aplicação deve oferecer a opção de favoritar as notícias que gostou para vê-las posteriormente;; <br> | 
|                      | RF-02	- A aplicação deve permitir ao usuário ao usuário realizar login.                                         |                                             
| Objetivo do Teste 	| Verificar se o usuário consegue favoritar notícias. |
| Passos 	| - Acessar o navegador; <br> - Informar o endereço do site; <br> - Clicar em "Entrar"; <br> - Preencher o campo de e-mail; <br> - Preencher o campo da senha; <br> - Clicar em "Login"; <br> - Clicar no ícone no formato de estrela; <br> - Clicar em "Favoritos". |
|Critério de Êxito | - As notícias favoritadas serão exibidas ao usuário. |
 

