# 1. ANALISE DE REQUISITOS

No início do projeto, foi fundamental compreender o domínio de negócio, que se refere ao contexto em que o software será utilizado: um museu multitemático. Este ambiente proporciona aos visitantes a oportunidade de explorar diversas exposições e interagir com as obras expostas.

Ao entender esse domínio, pudemos identificar as necessidades específicas dos usuários e do cliente. E levantar os requisitos funcionais e não funcionais do projeto.

## 1.1 Necessidades do Cliente (Organização sem fins lucrativos)

Engajamento do Visitante: A organização deseja aumentar o engajamento dos visitantes com a exposição, fornecendo informações detalhadas sobre as obras expostas através do totem. Isso inclui um breve histórico de cada obra para promover uma compreensão mais profunda e apreciação das obras que estão sendo exibidas.

Feedback do Visitante: A organização pretende coletar feedback dos visitantes sobre a exposição através de um questionário de múltipla escolha disponível no totem. Isso possibilitará uma compreensão mais ampla das opiniões e percepções dos visitantes sobre a exposição.

Análise de Dados: A organização busca utilizar os dados coletados dos questionários para tomar decisões informadas sobre a exposição, incluindo a realização de melhorias ou a decisão de encerrar a temporada do tema em exibição. Para isso, é necessário um sistema capaz de realizar cálculos e gerar relatórios a partir dos dados coletados.

Conformidade com a LGPD: A organização precisa garantir que o sistema esteja em conformidade com a Lei Geral de Proteção de Dados (LGPD), evitando a coleta de informações sensíveis dos visitantes.

## 1.2 Necessidades do Usuário (Visitantes do Museu)

Informações sobre as Obras: Os visitantes do museu desejam aprender sobre as obras expostas, tendo acesso a informações detalhadas e um breve histórico de cada obra. O totem deve fornecer essas informações de forma clara e acessível.

Feedback sobre a Exposição: Os visitantes devem ter a oportunidade de dar seu feedback sobre a exposição, respondendo a um questionário de múltipla escolha disponível no totem. Além disso, eles devem ser capazes de visualizar o resultado totalizado da pesquisa após responderem ao questionário.

Facilidade de Uso: O sistema deve ser fácil de usar, sendo desenvolvido para ser utilizado com um monitor sensível ao toque e incluindo um teclado na própria aplicação. Além disso, deve haver uma tela de login que solicite o primeiro e segundo nome e a idade do usuário, bem como um botão de “Iniciar” para começar a descrição.

Privacidade dos Dados: Os visitantes precisam ter a garantia de que suas informações pessoais serão tratadas de forma segura e em conformidade com a LGPD, assegurando que o sistema não colete informações sensíveis deles.

## 1.3 Requisitos Funcionais

**[RF001]** O software deve conter uma tela de cadastro para o usuário.

**[RF002]** O cadastro deve solicitar o primeiro nome e a idade do usuário, e apresentar um botão para iniciar a descrição.

**[RF003]** O totem deve permitir selecionar as obras, e uma vez que selecionado apresentar informações sobre as obras expostas, incluindo um breve histórico de cada uma

**[RF004]** Após o usuário se cadastrar, selecionar a obra e visualizar a descrição, o totem deve apresentar um questionário com 5 questões de múltipla escolha, cada uma com 5 alternativas. O usuário deve escolher uma alternativa para cada questão.

**[RF005]** Após o usuário responder todas as questões, o sistema deve salvar as respostas e apresentar o resultado do questionário ao usuário.

**[RF006]** O sistema deve ser capaz de realizar cálculos para gerar relatórios que permitam a tomada de decisão para melhorias ou encerramento da temporada do tema em exibição.

**[RF007]** O sistema deve armazenar e processar todos os dados de forma dinâmica em algum tipo de vetor.

**[RF008]** O sistema deve ser desenvolvido para ser utilizado com um monitor sensível ao toque.

**[RF009]** O sistema deve incluir um teclado na própria aplicação, sem utilizar o teclado visual do próprio sistema operacional.

## 1.4 Requisitos Não Funcionais

**[RNF001]** Compatibilidade com diferentes resoluções de tela (Priorização: Essencial)

O sistema proposto deve possuir capacidade de adaptação dinâmica a resoluções de tela comuns (1920x1080, 1680x1050, 1600x900, 1440x900), com todos os elementos da interface do usuário sendo redimensionáveis e ajustáveis. A validação deste requisito é realizada por meio de testes de interface do usuário em diversas resoluções de tela.

**[RNF002]** Responsividade e Desempenho (Priorização: Essencial)

O sistema deve ter uma resposta rápida, com um tempo de resposta inferior a 0,5 segundos, sem atrasos perceptíveis durante o carregamento ou transições de tela. Deve ser capaz de lidar com uma carga de trabalho típica sem degradação significativa do desempenho, mesmo em sistemas com recursos limitados. A validação desse requisito pode é feita através de testes de desempenho e usabilidade, e a verificação através de medições de tempo de resposta e análise de desempenho do sistema.

**[RNF003]** Facilidade de Instalação e Uso (Priorização: Essencial)

O processo de instalação e utilização do software deve ser simples e intuitivo, com um instalador fácil de usar e instruções disponíveis. As funcionalidades principais devem ser acessíveis por meio de uma interface de usuário intuitiva e bem organizada. A facilidade de instalação e uso é crucial para garantir que os usuários possam começar a utilizar sem complicações, tanto para os usuários visitantes quanto para os usuários administradores.

**[RNF004]** Consistência Visual e de Interatividade (Priorização: Essencial)

O sistema deve apresentar uma interface de usuário consistente em todos os seus componentes, seguindo diretrizes de design. A interação com os elementos da interface do usuário deve ser uniforme e previsível, aderindo aos padrões de acessibilidade e usabilidade. A consistência visual e de interatividade é crucial para proporcionar uma experiência de usuário intuitiva e fácil de usar.

**[RNF005]** Tolerância a Falhas (Priorização: Essencial)

O sistema deve ser capaz de lidar com falhas de forma resiliente, minimizando o impacto nos usuários e garantindo a disponibilidade contínua do serviço. Deve ser implementado um mecanismo de backup automático para proteger os dados do usuário em caso de falha catastrófica do sistema. O tempo de recuperação do sistema após uma falha não planejada deve ser minimizado para que os usuários possam retomar suas atividades rapidamente.

**[RNF006]** Escalabilidade e Extensibilidade (Priorização: Importante)

O sistema deve ser capaz de escalar vertical e horizontalmente para lidar com um aumento na carga de trabalho e suportar a adição de novas funcionalidades. Deve ser projetado com uma arquitetura modular e escalável, permitindo a adição de novos componentes e serviços conforme necessários. O software deve suportar um aumento gradual no número de usuários e transações sem degradação significativa do desempenho.
