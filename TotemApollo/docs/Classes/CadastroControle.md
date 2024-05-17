### Classe `CadastroControle`

Essa classe controla o processo de cadastro de visitantes.

#### Atributos:

- `private Museu museu`: Representa o museu onde o visitante será cadastrado.
- `private CadastroValidacao validacao`: Realiza a validação dos dados do visitante.
- `private string mensagem`: Mensagem de erro ou sucesso do cadastro.

#### Métodos:

- `public CadastroControle(string nome, string dataNascimento)`: Construtor da classe `CadastroControle`, responsável por iniciar o processo de cadastro do visitante.
- `public void RemoverUltimoVisitante()`: Remove o último visitante cadastrado no museu.
- `public string Mensagem { get => mensagem; }`: Propriedade que retorna a mensagem de erro ou sucesso do cadastro.