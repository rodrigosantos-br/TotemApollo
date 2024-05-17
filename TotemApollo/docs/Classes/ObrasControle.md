### Classe `ObrasControle`

Essa classe controla a exibição e navegação entre obras em um museu.

#### Atributos:

- `private readonly Museu museu`: Representa o museu onde as obras estão armazenadas.

#### Métodos:

- `public ObrasControle()`: Construtor da classe `ObrasControle`, responsável por inicializar o controle das obras.
- `public Obra ObraAtual()`: Retorna a obra atual no museu.
- `public Image ObterImagemObraAtual()`: Retorna a imagem da obra atual.
- `public string ObterDescricaoObraAtual()`: Retorna a descrição da obra atual.
- `public void AvancarParaProximaObra()`: Avança para a próxima obra no museu.
- `public void RetrocederParaObraAnterior()`: Retrocede para a obra anterior no museu.
- `public void ExibirObraAtual(PictureBox pbxImagemObra, Label lblDescricao)`: Exibe a obra atual nos controles fornecidos, definindo a imagem no PictureBox e a descrição no Label.