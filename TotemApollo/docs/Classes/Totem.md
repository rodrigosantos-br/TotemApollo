### Classe `Totem`
Essa classe representa um totem e herda da classe `Form`.

#### Atributos:

- `private readonly TecladoControle _teclado`: Controla o teclado associado ao totem.
- `private CadastroControle _cadastro`: Controla o cadastro realizado no totem.
- `private ObrasControle _obras`: Controla as obras exibidas no totem.
- `private readonly QuestionarioInteracaoControle _questionarioInteracao`: Controla o questionário de interação exibido no totem.
- `private readonly QuestionarioSatisfacaoControle _questionarioSatisfacao`: Controla o questionário de satisfação exibido no totem.
- `private readonly FormularioControle _formulario`: Controla o formulário exibido no totem.
- `private readonly List<CheckBox> _checkboxes`: Lista de checkboxes associadas ao questionário de satisfação.
- `private readonly List<Button> _buttons`: Lista de botões associados ao questionário de interação.

#### Métodos:

- `public Totem()`: Construtor da classe `Totem`.
- `private void Teclado_TeclaProcessada(object sender, string teclaProcessada)`: Manipula o evento de tecla processada.
- `private void TxbNome_Enter(object sender, EventArgs e)`: Manipula o evento de entrada no campo de texto para o nome.
- `private void TxbNome_Leave(object sender, EventArgs e)`: Manipula o evento de saída do campo de texto para o nome.
- `private void DataNascimento_DateSelected(object sender, DateRangeEventArgs e)`: Manipula o evento de seleção de data de nascimento.
- `private void TxbDataNascimento_Enter(object sender, EventArgs e)`: Manipula o evento de entrada no campo de texto para a data de nascimento.
- `private void TxbDataNascimento_Leave(object sender, EventArgs e)`: Manipula o evento de saída do campo de texto para a data de nascimento.
- `private void BtnIniciar_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Iniciar".
- `private void BtnVoltar_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Voltar".
- `private void BtnAvancarObra_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Avançar Obra".
- `private void BtnRetrocederObra_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Retroceder Obra".
- `private void BtnQuestionarioInteracao_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Questionário de Interação".
- `private void BotaoVoltarObras_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Voltar" no questionário de interação.
- `private void ChkPessimo_CheckedChanged(object sender, EventArgs e)`: Manipula o evento de mudança de estado da checkbox "Péssimo".
- `private void ChkRuim_CheckedChanged(object sender, EventArgs e)`: Manipula o evento de mudança de estado da checkbox "Ruim".
- `private void ChkRegular_CheckedChanged(object sender, EventArgs e)`: Manipula o evento de mudança de estado da checkbox "Regular".
- `private void ChkBom_CheckedChanged(object sender, EventArgs e)`: Manipula o evento de mudança de estado da checkbox "Bom".
- `private void ChkOtimo_CheckedChanged(object sender, EventArgs e)`: Manipula o evento de mudança de estado da checkbox "Ótimo".
- `private void BtnRespostaInteracao_Click(object sender, EventArgs e)`: Manipula o evento de clique nos botões de resposta no questionário de interação.
- `private void BtnProximaPerguntaInteracao_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Próxima Pergunta" no questionário de interação.
- `private void BtnAvancarParaQuestionarioSatisfacao_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Avançar para Questionário de Satisfação".
- `private void BtnProximaPerguntaSatisfacao_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Próxima Pergunta" no questionário de satisfação.
- `private void BtnFinalizar_Click(object sender, EventArgs e)`: Manipula o evento de clique no botão "Finalizar".