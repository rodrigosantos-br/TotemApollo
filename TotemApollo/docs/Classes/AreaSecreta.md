### Classe `AreaSecreta`

Essa classe representa a área secreta da aplicação e herda da classe `Form`.

#### Atributos:

- `private readonly QuestionarioSatisfacaoControle _questionario`: Controla o questionário de satisfação exibido na área secreta.

#### Métodos:

- `public AreaSecreta()`: Construtor da classe `AreaSecreta`.
- `private void BtnFecharPrograma_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Fechar Programa".
- `private void BtnVoltarCadastro_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Voltar" para fechar a área secreta.
- `private void AreaSecreta_Load(object sender, EventArgs e)`: Manipula o evento de carregamento da área secreta, onde são exibidos os dados do questionário de satisfação.