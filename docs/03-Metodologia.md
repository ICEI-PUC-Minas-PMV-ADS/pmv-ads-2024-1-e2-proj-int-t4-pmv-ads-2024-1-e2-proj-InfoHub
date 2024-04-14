
# Metodologia
A metodologia contempla as definições de ferramental utilizado pela equipe tanto para a manutenção dos códigos e demais artefatos quanto para a organização do time na execução das tarefas do projeto.

## Relação de Ambientes de Trabalho
Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela que se segue. 

| Ambiente | Plataforma | Link de Acesso |
| ------------- | ------------- | -------------
| Repositório de código fonte  | GitHub | [GitHub](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-InfoHub.git) |
| Documentos do projeto  | Google Docs | [Google Docs](https://docs.google.com/document/d/1CUFskGWb7eC3LL1kh2X8etuYh4pKSSlmVeejPDd84tQ/edit?usp=sharing) | 
| Projeto de Interface e  Wireframes | A preencher | A preencher |
| Gerenciamento do Projeto | Trello  | [Trello](https://trello.com/invite/b/SsBO4WyN/ATTI34b0322b1204d9eac204cd8f8de0ba35362E6C9F/eixo-2-desenvolvimento-de-aplicacao-web-interativa) |


## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

## Gerenciamento de Projeto

### Divisão de Papéis

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento.

A equipe está organizada da seguinte maneira:

- `Scrum Master`: Luana Aparecida
- `Product Owner`: Renan Azevedo
- `Equipe de Back-End`
- Nicholas Deway
- João Victor Oliveira
- Guilherme Marques Morato
- `Equipe de Front-End`
- Rogério Rodrigues Mendes

## Organização e destribuições das tarefas

Para organização e distribuição das tarefas do projeto, a equipe está utilizando o Trello estruturado com as seguintes listas: 

- **Etiquetas:** Essa lista mantém um template de tarefas recorrentes com as configurações padronizadas que todos devem seguir. O objetivo é permitir a cópia destes templates para agilizar a criação de novos cartões.
- **Backlog:** Recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a essa lista.
- **To do:** Essa lista representa o Sprint Backlog, algo que ainda está pendente ou ainda não foi iniciada. Este é o Sprint atual que estamos trabalhando.
- **Doing:**  Essa lista representa as tarefas da etapa que estamos trabalhando no momento e que foram inicializadas.
- **Code Review:** Revisamos  o código fonte por outros membros da equipe para identificar erros, bugs e oportunidades de melhoria antes da integração no projeto principal, via GitHub.
- **Test:** Checagem de Qualidade. Quando as tarefas são concluídas, elas são movidas para o "CQ". No final da semana, verificamos essa lista novamente para garantir que tudo saiu perfeito.
- **Done:** Nessa lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontas para serem entregues ao usuário. Não há mais edições ou revisões necessárias, elas estão agendadas e prontas para a ação.
- **Locked:** Quando alguma coisa impede a conclusão da tarefa, ela é movida para essa lista juntamente com um comentário sobre o que está travando a tarefa.
  
![Captura de tela 2024-04-14 201834](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-InfoHub/assets/144181666/db9e5644-39d9-4911-9be4-ce7354cb7f4e)
![Captura de tela 2024-04-14 201922](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-InfoHub/assets/144181666/0b709bf7-2f10-4836-ba17-df9b80b24b33)



## Projeto de Interface

Dentre as preocupações para a montagem da interface do sistema, estamos estabelecendo foco em questões como agilidade, acessibilidade e usabilidade. Desta forma, o projeto tem uma identidade visual padronizada em todas as telas que são projetadas para funcionamento em desktops e dispositivos móveis.

### Diagrama de Classes
![Diagrama de Classes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-InfoHub/assets/65633444/048ff756-f395-423f-9ee5-29a49df639a5)

### Diagrama Modelo Entidade Relacionamento
![Diagrama Modelo Entidade Relacionamento](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-InfoHub/assets/65633444/994a7767-1716-4d2d-8dc7-66dbaa4fb796)

### Gestão de Código Fonte
O diagrama de fluxo, também conhecido como fluxograma, é uma representação visual que mapeia o movimento e interação do usuário com um sistema interativo. Ele não se concentra no design detalhado das telas, mas sim nas etapas e relações entre elas. Ao destacar as interações-chave, o diagrama permite um planejamento preciso das interações, influenciando diretamente a qualidade do wireframe interativo subsequente. Geralmente, é composto por "boxes" que contêm elementos de interface e funcionalidades essenciais, como a página inicial, login, pesquisas e seus filtros, conectados por setas que representam o fluxo de interação.

Veja o nosso exemplo de estrutura básica de um diagrama de fluxo centrado nas ações dos usuários:
![Diagrama de fluxo 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t4-pmv-ads-2024-1-e2-proj-InfoHub/assets/65633444/2dc880a5-ec4c-4c66-9ea0-16dacd26373d)


