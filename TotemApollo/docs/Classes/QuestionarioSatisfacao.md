A classe `QuestionarioSatisfacao` herda da classe base `Questionario` e é responsável por gerenciar o questionário de satisfação dos visitantes do museu.

#### Construtor:

- `public QuestionarioSatisfacao()`: Inicializa as perguntas do questionário e inicializa a lista estática de respostas no `QuestionarioEstaticos`.

#### Métodos:

- `public List<double> CalcularPorcentagens()`: Calcula as porcentagens de respostas para cada opção de resposta.
- `public List<string> ObterRelatorioCumulativo()`: Gera um relatório cumulativo com o número total de visitantes e o número de respostas para cada opção de resposta para cada pergunta.

Essa classe fornece funcionalidades para calcular porcentagens de respostas e gerar relatórios cumulativos com base nas respostas dos visitantes ao questionário de satisfação.