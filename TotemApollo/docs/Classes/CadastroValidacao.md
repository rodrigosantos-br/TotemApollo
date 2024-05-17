### Classe `CadastroValidacao`

Esta classe é responsável por validar os dados de cadastro, como o nome e a data de nascimento.

#### Atributos:

- `private string nome`: Armazena o nome a ser validado.
- `private readonly string dataNascimento`: Armazena a data de nascimento a ser validada.
- `private string mensagemNome`: Armazena mensagens de erro relacionadas ao nome.
- `private string mensagemDataNascimento`: Armazena mensagens de erro relacionadas à data de nascimento.

#### Construtor:

- `public CadastroValidacao(string nome, string dataNascimento)`: Construtor da classe `CadastroValidacao`, responsável por inicializar os atributos `nome` e `dataNascimento` e chamar os métodos de validação.

#### Métodos:

- `private void ValidarNome()`: Valida o nome, verificando se não está vazio, se tem um comprimento adequado e transformando a primeira letra em maiúscula.
- `private void ValidarDataNascimento()`: Valida a data de nascimento, verificando se não está vazia.
- `public string MensagemNome { get => mensagemNome; }`: Propriedade somente leitura que retorna a mensagem de erro relacionada ao nome.
- `public string MensagemDataNascimento { get => mensagemDataNascimento; }`: Propriedade somente leitura que retorna a mensagem de erro relacionada à data de nascimento.