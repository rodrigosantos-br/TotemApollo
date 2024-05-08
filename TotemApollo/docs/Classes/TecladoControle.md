# Classe TecladoControle

## Descrição

A classe TecladoControle representa um controle de teclado virtual utilizado no Totem Apollo para fornecer entrada de texto ao usuário.

### Membros

- **capsAtivado**: Indica se a tecla Caps Lock está ativada.
- **shiftAtivado**: Indica se a tecla Shift está pressionada.
- **teclaProcessada**: A última tecla processada pelo controle.

#### Eventos

- TeclaProcessada: Evento acionado quando uma tecla do teclado virtual é pressionada.

#### Construtor

**TecladoControle()**: Inicializa uma nova instância da classe TecladoControle.

#### Métodos

- **AbrirAreaSecreta()**: Abre uma área secreta se as teclas Ctrl e Alt estiverem pressionadas simultaneamente.
- **BtnEnter_Click(object sender, EventArgs e)**: Manipula o evento de clique do botão Enter.
- **BtnBackspace_Click(object sender, EventArgs e)**: Manipula o evento de clique do botão Backspace.
- **Tecla_Click(object sender, EventArgs e)**: Manipula o evento de clique de uma tecla do teclado virtual.
- **ProcessarTecla(bool shift, bool caps, string teclaPressionada)**: Processa a tecla pressionada no teclado virtual, levando em consideração o estado das teclas Shift e Caps Lock.
- **RemoveUltimoCaractere(TextBox textBox)**: Remove o último caractere de um controle TextBox.
- **AdicionarTeclado(Panel painel)**: Adiciona o controle TecladoControle a um painel na tela.
- **RemoverTeclado(Panel painel)**: Remove o controle TecladoControle de um painel na tela.
