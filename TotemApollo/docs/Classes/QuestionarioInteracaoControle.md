### Classe `QuestionarioInteracaoControle`

Essa classe controla o questionário de interação exibido no totem.

#### Atributos:

- `private readonly QuestionarioInteracao questionarioInteracao`: Representa o questionário de interação.
- `private readonly QuestionarioValidacao validacao`: Realiza a validação das respostas do questionário.
- `private int indicePerguntaAtual`: Índice da pergunta atual no questionário.
- `private List<Button> botoesResposta`: Lista de botões de resposta no questionário.
- `private Dictionary<string, int> acumuladoRespostas`: Armazena o acumulado de respostas do questionário.

#### Métodos:

- `public QuestionarioInteracaoControle(List<Button> botoesResposta)`: Construtor da classe `QuestionarioInteracaoControle`, responsável por iniciar o controle do questionário de interação.
- `public int ObterNumeroPerguntas()`: Retorna o número de perguntas no questionário.
- `public bool ValidarRespostas()`: Valida as respostas do questionário.
- `public void MostrarExplicacaoResposta(Label labelExplicacao)`: Mostra a explicação da resposta correta.
- `public void ExibirPerguntaAnterior(Label lblPergunta)`: Exibe a pergunta anterior no questionário.
- `public void ExibirProximaPergunta(Label lblPergunta)`: Exibe a próxima pergunta no questionário.
- `public void VerificarResposta(string respostaUsuario, Button botaoResposta)`: Verifica a resposta do usuário e atualiza a cor dos botões de resposta.
- `public string ExibirGabarito()`: Exibe o gabarito do questionário.
- `public int IndicePerguntaAtual { get => indicePerguntaAtual; set => indicePerguntaAtual = value; }`: Propriedade para acessar e modificar o índice da pergunta atual no questionário.