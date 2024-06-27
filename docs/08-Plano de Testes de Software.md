
# Plano de Testes de Software
 
### RF-001: Acesso a Notícias por Tema

#### Objetivo
Verificar se o usuário pode acessar notícias selecionando um tema na barra de temas.

#### Casos de Teste

| ID      | Descrição                                                                 | Passos                                                       | Resultado Esperado                              |
|---------|---------------------------------------------------------------------------|--------------------------------------------------------------|------------------------------------------------|
| CT-001  | Seleção de tema exibe notícias correspondentes                            | 1. Acessar a página inicial. <br> 2. Selecionar um tema na barra de temas. | Notícias relacionadas ao tema selecionado são exibidas. |
| CT-002  | Exibição correta dos links de notícias                                    | 1. Acessar a página inicial. <br> 2. Selecionar um tema na barra de temas. <br> 3. Verificar links das notícias. | Todos os links das notícias estão presentes e direcionam corretamente. |

### RF-002: Acesso a Notícias por Busca

#### Objetivo
Verificar se o usuário pode acessar notícias através da barra de pesquisa.

#### Casos de Teste

| ID      | Descrição                                                                 | Passos                                                       | Resultado Esperado                              |
|---------|---------------------------------------------------------------------------|--------------------------------------------------------------|------------------------------------------------|
| CT-003  | Busca exibe notícias correspondentes                                      | 1. Acessar a página inicial. <br> 2. Inserir um termo de busca na barra de pesquisa. <br> 3. Executar a busca. | Notícias relacionadas ao termo de busca são exibidas. |
| CT-004  | Exibição correta dos links de notícias após busca                         | 1. Acessar a página inicial. <br> 2. Inserir um termo de busca na barra de pesquisa. <br> 3. Executar a busca. <br> 4. Verificar links das notícias. | Todos os links das notícias estão presentes e direcionam corretamente. |

### RF-003: Acesso a Links Externos de Notícias

#### Objetivo
Verificar se o usuário pode acessar sites de notícias através dos links externos.

#### Casos de Teste

| ID      | Descrição                                                                 | Passos                                                       | Resultado Esperado                              |
|---------|---------------------------------------------------------------------------|--------------------------------------------------------------|------------------------------------------------|
| CT-005  | Links de notícias direcionam corretamente para sites externos             | 1. Acessar a página inicial. <br> 2. Selecionar um tema na barra de temas. <br> 3. Clicar em um link de notícia. | O usuário é redirecionado para o site da notícia correspondente. |
| CT-006  | Links de notícias após busca direcionam corretamente para sites externos  | 1. Acessar a página inicial. <br> 2. Inserir um termo de busca na barra de pesquisa. <br> 3. Executar a busca. <br> 4. Clicar em um link de notícia. | O usuário é redirecionado para o site da notícia correspondente. |

## Execução dos Testes
Os testes serão executados manualmente, verificando cada funcionalidade descrita nos casos de teste. Resultados serão documentados e qualquer desvio será relatado para correção.

## Conclusão
Este plano de testes assegura que as funcionalidades principais da aplicação são verificadas de maneira eficaz e eficiente, atendendo aos requisitos funcionais especificados.


 

