### Classe `TecladoControle`

Esta classe controla o teclado virtual exibido no totem.

#### Atributos:

- `private bool capsAtivado`: Indica se o Caps Lock está ativado.
- `private bool shiftAtivado`: Indica se a tecla Shift está pressionada.
- `private string teclaProcessada`: Armazena a última tecla processada.

#### Eventos:

- `public event EventHandler<string> TeclaProcessada`: Evento acionado quando uma tecla é pressionada no teclado.

#### Métodos:

- `public TecladoControle()`: Construtor da classe `TecladoControle`, responsável por inicializar o teclado virtual.
- `public void AbrirAreaSecreta()`: Abre a área secreta se as teclas Ctrl e Alt estiverem pressionadas.
- `private void BtnEnter_Click(object sender, EventArgs e)`: Evento acionado quando o botão Enter é pressionado.
- `private void BtnBackspace_Click(object sender, EventArgs e)`: Evento acionado quando o botão Backspace é pressionado.
- `public void Tecla_Click(object sender, EventArgs e)`: Evento acionado quando uma tecla do teclado é pressionada.
- `private string ProcessarTecla(bool shift, bool caps, string teclaPressionada)`: Processa a tecla pressionada considerando o estado do Shift e do Caps Lock.
- `public void RemoveUltimoCaractere(TextBox textBox)`: Remove o último caractere de um campo de texto.
- `public void AdicionarTeclado(Panel painel)`: Adiciona o teclado virtual a um painel.
- `private void Form_LocationChanged(object sender, EventArgs e)`: Evento acionado quando a posição do formulário principal é alterada.
- `private void ReposicionarTeclado()`: Reposiciona o teclado virtual para centralizá-lo horizontalmente e colocá-lo na parte inferior da tela.
- `public void RemoverTeclado(Panel painel)`: Remove o teclado virtual de um painel.