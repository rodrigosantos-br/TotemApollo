A classe `QuestionarioValidacao` fornece métodos para validar as respostas fornecidas pelos usuários em um questionário.

#### Métodos:

- `public bool ValidarRespostas(List<int> respostas)`: Este método valida se todas as questões foram respondidas. Ele verifica se a lista de respostas está vazia ou se contém alguma resposta não respondida representada pelo valor -1.

- `public bool ValidarRespostas(List<Button> botoesResposta)`: Este método valida se pelo menos uma resposta foi selecionada. Ele verifica se algum botão de resposta foi selecionado, verificando se a cor de fundo do botão foi alterada da cor padrão.

Esses métodos são úteis para garantir que os usuários respondam todas as questões em um questionário e que pelo menos uma opção de resposta seja selecionada.