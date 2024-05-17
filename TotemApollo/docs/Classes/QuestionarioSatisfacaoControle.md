### Classe `QuestionarioSatisfacaoControle`

Esta classe controla o questionário de satisfação exibido no totem.

#### Atributos:

- `private readonly QuestionarioSatisfacao questionarioSatisfacao`: Representa o questionário de satisfação.
- `private readonly QuestionarioValidacao validacao`: Realiza a validação das respostas do questionário.
- `private int indicePerguntaAtual`: Índice da pergunta atual no questionário.
- `private List<CheckBox> checkboxes`: Lista de checkboxes para as respostas do questionário.

#### Métodos:

- `public QuestionarioSatisfacaoControle()`: Construtor da classe `QuestionarioSatisfacaoControle`, responsável por iniciar o controle do questionário de satisfação.
- `public List<double> ObterPorcentagens()`: Retorna as porcentagens de respostas do questionário.
- `public List<string> ObterPerguntas()`: Retorna as perguntas do questionário.
- `public void AdicionarRespostas(int indicePergunta, int resposta)`: Adiciona as respostas ao questionário.
- `public bool ValidarRespostas(List<int> respostas)`: Valida as respostas do questionário.
- `public void AdicionarRespostasDoFormulario(List<int> respostas)`: Adiciona as respostas do formulário ao questionário.
- `public List<int> ObterRespostasDoFormulario(List<CheckBox[]> opcoes)`: Obtém as respostas do formulário.
- `private int ObterRespostaParaPergunta(params CheckBox[] opcoes)`: Obtém a resposta para uma pergunta do questionário.
- `public void IncrementarContadorInteracoes()`: Incrementa o contador de interações do questionário.
- `public void DecrementarContadorInteracoes()`: Decrementa o contador de interações do questionário.
- `public int ObterContadorInteracoes()`: Retorna o contador de interações do questionário.
- `public List<string> ObterRelatorioCumulativo()`: Retorna o relatório cumulativo do questionário.
- `public void MostrarProximaPergunta(Label labelPergunta, CheckBox[] checkboxes)`: Exibe a próxima pergunta no questionário.
- `private void DesmarcarOutrosCheckBoxes(CheckBox checkBox)`: Desmarca outras checkboxes quando uma é marcada.
- `public void AssociarCheckBoxes(List<CheckBox> checkboxes)`: Associa as checkboxes ao controle do questionário.
- `public void CheckBox_CheckedChanged(object sender, EventArgs e)`: Manipula o evento de mudança de estado de uma checkbox.