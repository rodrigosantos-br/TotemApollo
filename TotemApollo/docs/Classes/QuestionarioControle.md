# Classe QuestionarioControle

## Descrição

A classe QuestionarioControle é responsável por controlar o processo de interação com o questionário no Totem Apollo, incluindo a validação de respostas e a obtenção de relatórios cumulativos.

### Membros

- **questionario**: Uma instância da classe Questionario para manipular as interações com o questionário.
- **validacao**: Uma instância da classe QuestionarioValidacao para validar as respostas do questionário.

#### Construtor

**QuestionarioControle()**: Inicializa uma nova instância da classe QuestionarioControle, criando instâncias das classes Questionario e QuestionarioValidacao.

#### Métodos

- **ObterPorcentagens()**: Retorna a lista de porcentagens das respostas ao questionário.
- **ObterPerguntas()**: Retorna a lista de perguntas do questionário.
- **AdicionarRespostas(int indicePergunta, int resposta)**: Adiciona uma resposta ao questionário para a pergunta especificada.
- **ValidarRespostas(List<'int'> respostas)**: Valida as respostas fornecidas ao questionário.
- **IncrementarContadorInteracoes()**: Incrementa o contador de interações do questionário.
- **ObterContadorInteracoes()**: Retorna o número total de interações com o questionário.
- **ObterRespostasDoFormulario(params RadioButton[][] opcoes)**: Obtém as respostas selecionadas em um formulário contendo grupos de botões de opção.
- **ObterRelatorioCumulativo()**: Obtém um relatório cumulativo das respostas ao questionário.

#### Uso

Para interagir com o questionário, crie uma instância da classe QuestionarioControle e utilize seus métodos conforme necessário.
