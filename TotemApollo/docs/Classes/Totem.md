# Classe Totem

## Descrição

A classe Totem representa a interface do Totem Apollo, que interage com os usuários para controlar o processo de cadastro de visitantes, exibir informações sobre obras do museu e coletar feedback por meio de um questionário.

### Membros

- **_teclado**: Controle para o teclado virtual.
- **_cadastro**: Controle para o processo de cadastro de visitantes.
- **_obras**: Controle para exibição de informações sobre obras do museu.
- **_questionario**: Controle para coleta de feedback por meio de um questionário.
- **_formulario**: Controle para limpar os controles após o salvamento bem-sucedido.

#### Construtores

- **Totem()**: Inicializa uma nova instância da classe Totem e configura os controles necessários.

#### Eventos

- **Teclado_TeclaProcessada**: Evento acionado quando uma tecla é processada pelo teclado virtual.

#### Métodos

- **txbNome_Enter(object sender, EventArgs e)**: Evento acionado quando o controle de entrada de nome recebe o foco.
- **txbNome_Leave(object sender, EventArgs e)**: Evento acionado quando o controle de entrada de nome perde o foco.
- **DataNascimento_DateSelected(object sender, DateRangeEventArgs e)**: Evento acionado quando uma data é selecionada no calendário.
- **txbDataNascimento_Enter(object sender, EventArgs e)**: Evento acionado quando o controle de entrada de data de nascimento recebe o foco.
- **txbDataNascimento_Leave(object sender, EventArgs e)**: Evento acionado quando o controle de entrada de data de nascimento perde o foco.
- **btnIniciar_Click(object sender, EventArgs e)**: Evento acionado quando o botão "Iniciar" é clicado.
- **private void btnVoltarInicio_Click(object sender, EventArgs e)**: Evento acionado quando o botão voltar é clicado.
- **btnObra1_Click(object sender, EventArgs e)**: Evento acionado quando o botão da primeira obra é clicado.
- **btnObra2_Click(object sender, EventArgs e)**: Evento acionado quando o botão da segunda obra é clicado.
- **btnObra3_Click(object sender, EventArgs e)**: Evento acionado quando o botão da terceira obra é clicado.
- **btnObra4_Click(object sender, EventArgs e)**: Evento acionado quando o botão da quarta obra é clicado.
- **btnVoltar_Click(object sender, EventArgs e)**: Evento acionado quando o botão "Voltar" é clicado.
- **btnQuestionario_Click(object sender, EventArgs e)**: Evento acionado quando o botão "Questionário" é clicado.
- **btnVoltarQ_Click(object sender, EventArgs e)**: Evento acionado quando o botão "Voltar" do questionário é clicado.
- **btnSalvar_Click(object sender, EventArgs e)**: Evento acionado quando o botão "Salvar" do questionário é clicado.

#### Uso

Para utilizar a classe Totem, crie uma nova instância dela e configure os controles necessários. Utilize os eventos e métodos disponíveis para controlar a interação com os usuários e executar as operações desejadas.
