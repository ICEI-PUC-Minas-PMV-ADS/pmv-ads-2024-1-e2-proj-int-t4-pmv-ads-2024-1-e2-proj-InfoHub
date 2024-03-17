# Especificações do Projeto

O projeto consistirá no desenvolvimento de uma aplicação web que permita aos usuários receberem notícias personalizadas de várias fontes da web. O aplicativo utilizará um crawler para coletar notícias de diferentes sites de notícias, agregando e organizando as informações de acordo com as preferências e interesses de cada usuário.


## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas como:

<figure> 
  <img src="https://user-images.githubusercontent.com/146504095/271831604-71c88caf-1af0-4611-957f-79235cd843b8.png"width="800px"height="300px"
     
    Figura 1 - Etiquetas GitHub
 
 <figure>

Nome: Anderson Moura
Idade: 25 anos
Ocupação: Estudante universitário
Área de Estudo: Jornalismo e Comunicação
Interesses:
Notícias em Tempo Real: Anderson é apaixonado por estar atualizado com as últimas notícias. Ele gosta de saber o que está acontecendo no mundo, seja política, tecnologia, esportes ou cultura.
Tecnologia: Anderson é um entusiasta da tecnologia. Ele acompanha blogs e podcasts sobre inovações, gadgets e tendências.
Redes Sociais:  é ativo nas redes sociais, onde compartilha notícias interessantes e interage com outros estudantes e profissionais da área.
Eventos e Debates: Ele participa de eventos, palestras e debates relacionados a jornalismo e mídia.
Comportamento Online:segue várias fontes de notícias em suas redes sociais e usa aplicativos de notícias para receber atualizações em tempo real.
Ele gosta de debater tópicos relevantes e compartilhar informações com seus colegas.
também é crítico e avalia a credibilidade das fontes de notícias que consome.
Desafios:
Gerenciar o fluxo constante de informações e filtrar notícias relevantes.
Manter-se atualizado com as mudanças rápidas no cenário de notícias.
Encontrar fontes confiáveis e evitar notícias falsas.
Objetivos:
Se formar em Jornalismo e trabalhar como repórter ou editor.
Contribuir para a sociedade informando e educando através do jornalismo.
Desenvolver habilidades de escrita e comunicação.

Nome: Giselle Silva

Idade: 45 anos
Ocupação: Advogada especializada em direito internacional
Área de Atuação: Direito Corporativo e Relações Internacionais
Interesses:
Notícias Globais: Giselle é apaixonada por estar atualizada com as principais notícias do mundo. Ela acompanha eventos políticos, econômicos e sociais em diferentes países.
Direito Internacional: Ela está sempre atenta a mudanças nas leis e regulamentos internacionais que possam afetar seus clientes ou suas negociações.
Eventos e Conferências:Giselle participa de conferências e eventos relacionados a direito internacional para expandir sua rede de contatos e aprofundar seu conhecimento.
Literatura Jurídica: Ela lê livros e artigos acadêmicos sobre direito internacional para se manter atualizada.
Comportamento Online:
Giselle segue fontes confiáveis de notícias internacionais, como agências de notícias, jornais e revistas especializadas.
Ela também participa de fóruns e grupos online para debater questões legais e trocar ideias com outros profissionais.
Giselle é crítica em relação a informações falsas e verifica a credibilidade das fontes antes de compartilhar notícias.
Desafios:
Gerenciar o volume de informações e filtrar notícias relevantes para sua área de atuação.
Compreender nuances legais em diferentes contextos culturais e jurídicos.
Manter-se atualizada com as mudanças rápidas no cenário global.
Objetivos:
Continuar aprimorando suas habilidades jurídicas e expandir sua atuação internacional.
Representar clientes em casos complexos envolvendo disputas internacionais.
Contribuir para a justiça e o entendimento mútuo entre diferentes nações.



 
## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`|
|--------------------|------------------------------------|-----------------------|
|Anderson Moura|Fazer comentários em notícias e expor minha opinião|Discutir com grupos de interesse comum|
|Anderson Moura|Compartilhar notícias nas redes sociais em que faço parte|Poder discutir com os amigos e colegas de faculdade sobre temas de interesse|
|Giselle Silva|Visualizar as notícias mais relevantes do momento|Tomar conhecimento dos fatos das áreas que atuo e que me interessam|
|Anderson Moura|Ler notícias tanto no desktop quanto no celular|Ocupar o tempo quando estou esperando algo (ex: intervalos de aulas, ônibus/metrô)|
|Giselle Silva|Visualizar notícias mais alinhadas com minha área de atuação|Gastar menos tempo lendo notícias e dar foco naquelas que estão relacionadas com o meu trabalho|
|Giselle Silva|Manter um registro de notícias específicas de interesse particular|Visualizar depois e manter um histórico de notícias que possam ser compartilhadas posteriormente|
|Giselle Silva|Poder realizar uma pesquisa sobre notícias acerca de um tema específico|Localizar tópicos específicos e conseguir maior objetividade em algumas leituras|
|Anderson Moura|Saber a data e a fonte das notícias lidas|Confiar no conteúdo passado e na atualidade das notícias que recebo|

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário gerencie suas tarefas | ALTA | 
|RF-002| A aplicação deve emitir um relatório de tarefas realizadas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

![Diagrama de Casos de Uso](img/diagrama-casosdeuso.jpeg)


