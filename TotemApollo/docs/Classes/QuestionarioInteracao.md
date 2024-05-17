A classe `QuestionarioInteracao` herda da classe base `Questionario` e adiciona funcionalidades específicas para interação com o usuário, como verificação de respostas e exibição de gabarito.

#### Atributos:

- `private List<string> respostasCorretas`: Armazena as respostas corretas para cada pergunta.
- `private List<string> explicaçõesRespostasCorretas`: Armazena as explicações das respostas corretas.
- `private int acertos`: Conta o número de respostas corretas.
- `private int erros`: Conta o número de respostas incorretas.

#### Construtor:

- `public QuestionarioInteracao()`: Inicializa as perguntas, respostas corretas, explicações e contadores. Também inicializa a lista estática de respostas no `QuestionarioEstaticos`.

#### Métodos:

- `public int ObterNumeroPerguntas()`: Retorna o número total de perguntas.
- `public string ObterPergunta(int indicePergunta)`: Retorna a pergunta no índice especificado.
- `public string ObterExplicacaoRespostaCorreta(int indicePergunta)`: Retorna a explicação da resposta correta para a pergunta no índice especificado.
- `public string ObterRespostaPorIndice(int indicePergunta, int indiceResposta)`: Retorna a letra correspondente à opção de resposta no índice especificado.
- `public bool VerificarResposta(int indicePergunta, string respostaUsuario)`: Verifica se a resposta do usuário para a pergunta no índice especificado está correta. Atualiza os contadores de acertos e erros.
- `public string ExibirGabarito()`: Retorna uma string formatada com o total de visitantes, acertos e erros acumulados.

Essa classe encapsula a lógica para interagir com o usuário em um questionário, incluindo a verificação de respostas e a exibição de estatísticas.