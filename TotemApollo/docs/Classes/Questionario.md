A classe `Questionario` serve como uma base para diferentes tipos de questionários, fornecendo funcionalidades comuns.

#### Atributos:

- `protected List<string> perguntas`: Armazena a lista de perguntas do questionário.

#### Construtor:

- `public Questionario()`: Inicializa uma nova instância da classe `Questionario`. Neste momento, a lista de perguntas não é inicializada.

#### Métodos:

- `public void AdicionarResposta(int indicePergunta, int resposta)`: Adiciona a resposta de uma pergunta à lista de respostas estáticas, mantida em uma classe auxiliar chamada `QuestionarioEstaticos`.
- `public List<string> ObterPerguntas()`: Retorna a lista de perguntas do questionário.
- `public void IncrementarContadorInteracoes()`: Incrementa o contador de interações estático, mantido em `QuestionarioEstaticos`.
- `public void DecrementarContadorInteracoes()`: Decrementa o contador de interações estático, mantido em `QuestionarioEstaticos`.
- `public int ContadorInteracoes`: Propriedade que retorna o contador de interações estático, mantido em `QuestionarioEstaticos`.

Essa classe é uma base abstrata para diferentes tipos de questionários, fornecendo funcionalidades comuns, como adicionar respostas, obter perguntas e gerenciar o contador de interações. As implementações específicas de questionários podem herdar dessa classe e adicionar funcionalidades adicionais conforme necessário.