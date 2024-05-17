A classe `Resposta` representa uma resposta fornecida pelo usuário a uma pergunta específica em um questionário.

#### Atributos:

- `public int PerguntaId { get; set; }`: Identifica a pergunta à qual a resposta pertence, utilizando o ID da pergunta.
  
- `public int RespostaSelecionada { get; set; }`: Armazena o índice da resposta selecionada pelo usuário para a pergunta correspondente.

Essa classe é útil para registrar e gerenciar as respostas dos usuários em um questionário, permitindo associar cada resposta à pergunta correspondente.