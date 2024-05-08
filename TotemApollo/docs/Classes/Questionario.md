# Classe Questionario

## Descrição

A classe Questionario representa um conjunto de perguntas e respostas utilizado para coletar feedback dos visitantes sobre as exposições do museu no sistema Totem Apollo.

### Membros

- **perguntas**: Lista de perguntas do questionário.
- **respostas**: Lista de listas de respostas acumulativas para cada pergunta.
- **contadorInteracoes**: Contador de interações com o questionário.

#### Construtores

- **Questionario()**: Inicializa uma nova instância da classe Questionario com perguntas pré-definidas e respostas vazias.

#### Métodos

- **AdicionarResposta(int indicePergunta, int resposta)**: Adiciona uma resposta ao questionário para a pergunta especificada pelo índice.
- **ObterPerguntas()**: Retorna a lista de perguntas do questionário.
- **CalcularPorcentagens()**: Calcula as porcentagens de respostas para cada opção de resposta.
- **ObterRelatorioCumulativo()**: Retorna um relatório cumulativo das respostas dadas ao questionário.
- **IncrementarContadorInteracoes()**: Incrementa o contador de interações com o questionário.

#### Propriedades

- **ContadorInteracoes**: Obtém o número total de interações com o questionário.

#### Uso

Para utilizar o questionário, criar uma instância da classe Questionario. As perguntas já estão pré-definidas no construtor padrão, mas você pode adicionar ou modificar as perguntas conforme necessário. Utilize o método AdicionarResposta para registrar as respostas dos visitantes para cada pergunta. Você pode então calcular as porcentagens de respostas utilizando o método CalcularPorcentagens e obter um relatório cumulativo das respostas com o método ObterRelatorioCumulativo. Não se esqueça de incrementar o contador de interações sempre que o questionário for utilizado.
