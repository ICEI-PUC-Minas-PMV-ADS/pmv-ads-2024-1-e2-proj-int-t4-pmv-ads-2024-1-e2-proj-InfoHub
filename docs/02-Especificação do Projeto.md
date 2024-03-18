# Especificações do Projeto

O projeto consistirá no desenvolvimento de uma aplicação web que permita aos usuários receberem notícias personalizadas de várias fontes da web. O aplicativo utilizará um crawler para coletar notícias de diferentes sites de notícias, agregando e organizando as informações de acordo com as preferências e interesses de cada usuário.


## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas nas figuras que se seguem:

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-xxx/blob/main/docs/img/persona%20anderson.png?raw=true"width="250px"height="250px"
   
    Figura 1 - Persona 1 
 <figure>
   
<br>

Nome: Anderson Moura
   
Idade: 25 anos

Ocupação: Estudante universitário.

Área de Estudo: Jornalismo e Comunicação.

Interesses:
<ul>
<li>Notícias em Tempo Real: Anderson é apaixonado por estar atualizado com as últimas notícias. Ele gosta de saber o que está acontecendo no mundo, seja política, tecnologia, esportes ou cultura.</li>
<li>Tecnologia: Anderson é um entusiasta da tecnologia. Ele acompanha blogs e podcasts sobre inovações, gadgets e tendências.</li>
<li>Redes Sociais:  é ativo nas redes sociais, onde compartilha notícias interessantes e interage com outros estudantes e profissionais da área.</li>
<li>Eventos e Debates: Ele participa de eventos, palestras e debates relacionados a jornalismo e mídia.</li>
</ul>
Comportamento Online:
<ul>
<li>Segue várias fontes de notícias em suas redes sociais e usa aplicativos de notícias para receber atualizações em tempo real.</li>
<li>ele gosta de debater tópicos relevantes e compartilhar informações com seus colegas.</li>
<li>avalia a credibilidade das fontes de notícias que consome.</li>
</ul>
Desafios:
<ul>
<li>Gerenciar o fluxo constante de informações e filtrar notícias relevantes.</li>
<li>Manter-se atualizado com as mudanças rápidas no cenário de notícias.</li>
<li>Encontrar fontes confiáveis e evitar notícias falsas.</li>
</ul>

Objetivos:
<ul>
<li>Se formar em Jornalismo e trabalhar como repórter ou editor.</li>
<li>Contribuir para a sociedade informando e educando através do jornalismo.</li>
<li>Desenvolver habilidades de escrita e comunicação.</li>
</ul>
<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-xxx/blob/main/persona%20giselle.png?raw=true"width="250px"height="250px"
     
    Figura 2 - Persona 2
 <figure>
   
<br>

Nome: Giselle Silva

Idade: 45 anos

Ocupação: Advogada especializada em direito internacional, gerencia o setor juridico de uma empresa Multinacional.

Área de Atuação: Direito Corporativo e Relações Internacionais.

Interesses:
<ul>
<li>Notícias Globais: Giselle é apaixonada por estar atualizada com as principais notícias do mundo. Ela acompanha eventos políticos, econômicos e sociais em diferentes países.</li>
<li>Direito Internacional: Ela está sempre atenta a mudanças nas leis e regulamentos internacionais que possam afetar seus clientes ou suas negociações.</li>
<li>Eventos e Conferências:Giselle participa de conferências e eventos relacionados a direito internacional para expandir sua rede de contatos e aprofundar seu conhecimento.</li>
<li>Literatura Jurídica: Ela lê livros e artigos acadêmicos sobre direito internacional para se manter atualizada.
</ul>
Comportamento Online:
<ul>
<li>Giselle segue fontes confiáveis de notícias internacionais, como agências de notícias, jornais e revistas especializadas.</li>
<li>Ela também participa de fóruns e grupos online para debater questões legais e trocar ideias com outros profissionais.</li>
<li>Giselle é crítica em relação a informações falsas e verifica a credibilidade das fontes antes de compartilhar notícias.</li>
</ul>
Desafios:
<ul>
<li>Gerenciar o volume de informações e filtrar notícias relevantes para sua área de atuação.</li>
<li>Compreender nuances legais em diferentes contextos culturais e jurídicos.</li>
<li>Manter-se atualizada com as mudanças rápidas no cenário global.</li>
</ul>
Objetivos:
<ul>
<li>Continuar aprimorando suas habilidades jurídicas e expandir sua atuação internacional.</li>
<li>Representar clientes em casos complexos envolvendo disputas internacionais.</li>
<li>Contribuir para a justiça e o entendimento mútuo entre diferentes nações.</li>
</ul>


 
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
|RF-001| O site deve apresentar na página principal notícias dinâmicas obtidas por meio de canais de notícias da Internet (API) | ALTA | 
|RF-002|  O site deve apresentar, para cada notícia, uma imagem correspondente ao assunto apresentado (thumbnail)  | MÉDIA |
|RF-003| O site deve permitir ao usuário visualizar o texto completo da notícia com todos os detalhes da publicação | MÉDIA | 
|RF-004|  O site deve oferecer um menu adicional que permita ao usuário visualizar notícias de fontes distintas (sources).  | MÉDIA |
|RF-005|O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar um texto específico que será informado na caixa de pesquisa.7,5 | ALTA | 
|RF-006|  O site deve permitir visualizar as informações de contatos do mantenedor do site  | MÉDIA |
|RF-007| O site deve permitir o compartilhamento de notícias visualizadas em plataformas de redes sociais | BAIXA | 
|RF-008|  O site deve permitir salvar notícias preferidas  | BAIXA |
|RF-009| O site deve permitir verificar as notícias salvas como preferidas | BAIXA | 
|RF-010|  O site deve permitir que usuários possam comentar notícias  | BAIXA |
|RF-011| O site deve exibir os comentários registrados juntamente com a notícia exibida | BAIXA | 


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada | ALTA | 
|RNF-003|  O site deve ter bom nível de contraste entre os elementos da tela em conformidade  | MÉDIA | 
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 

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


