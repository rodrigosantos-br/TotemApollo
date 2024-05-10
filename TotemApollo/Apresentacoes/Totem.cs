using TotemApollo.Controles;

namespace TotemApollo
{
    public partial class Totem : Form
    {
        private readonly TecladoControle _teclado;
        private CadastroControle _cadastro;
        private ObrasControle _obras;
        private readonly QuestionarioControle _questionario;
        private readonly FormularioControle _formulario;
        private readonly List<CheckBox> _checkboxes;
        
        public Totem()
        {
            InitializeComponent();
            _formulario = new FormularioControle();
            _questionario = new QuestionarioControle();
            _teclado = new TecladoControle();
            _teclado.TeclaProcessada += Teclado_TeclaProcessada;
            _checkboxes = [chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo];
            _questionario.AssociarCheckBoxes(_checkboxes);
        }

        private void Teclado_TeclaProcessada(object sender, string teclaProcessada)
        {
            if (teclaProcessada == "Enter")
            // Clicar no botão "Iniciar"
                btnIniciar.PerformClick();

            else if (teclaProcessada == "K")
            // Caps e Shift devem estar selecionados
                _teclado.AbrirAreaSecreta();
            
            else if (teclaProcessada == "Backspace")
                _teclado.RemoveUltimoCaractere(txbNome);
            
            else
                // Adicionar a tecla processada ao texto
                txbNome.Text += teclaProcessada;
        }

        private void TxbNome_Enter(object sender, EventArgs e)
        {
            _teclado.AdicionarTeclado(pnlCadastro);
        }

        private void TxbNome_Leave(object sender, EventArgs e)
        {
            // Verifica se o controle que recebeu o foco não é o teclado virtual
            if (this.ActiveControl != _teclado)
                // Oculta o teclado virtual quando o txbNome perder o foco
                _teclado.RemoverTeclado(pnlCadastro);
        }

        private void DataNascimento_DateSelected(object sender, DateRangeEventArgs e)
        {
            txbDataNascimento.Text = mtcCalendario.SelectionStart.ToShortDateString();
            mtcCalendario.Visible = false;
        }

        private void TxbDataNascimento_Enter(object sender, EventArgs e)
        {
            mtcCalendario.Visible = true;
            _teclado.RemoverTeclado(pnlCadastro);
        }

        private void TxbDataNascimento_Leave(object sender, EventArgs e)
        {
            if (ActiveControl != mtcCalendario)
                mtcCalendario.Visible = false;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            _cadastro = new CadastroControle(txbNome.Text, txbDataNascimento.Text);

            // Verificar se houve erro na validação do nome ou da data de nascimento
            if (_cadastro.Mensagem == "")
            {
                _obras = new ObrasControle();
                pnlCadastro.Visible = false;
                pnlObraDescricao.Visible = true; // Torna o painel de descrição visível

                // Chama o método do controle para exibir a obra atual nos controles da view
                _obras.ExibirObraAtual(pbxImagemObra, lblDescricao);
            }
            else
            {
                MessageBox.Show(_cadastro.Mensagem);
                return;
            }
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            pnlObraDescricao.Visible = false;
            _cadastro.RemoverUltimoVisitante();
            _formulario.LimparControles(Controls);
            pnlCadastro.Show();
        }

        private void BtnAvancarObra_Click(object sender, EventArgs e)
        {
            _obras.AvancarParaProximaObra();
            _obras.ExibirObraAtual(pbxImagemObra, lblDescricao); // Atualiza a exibição com a próxima obra
        }

        private void BtnRetrocederObra_Click(object sender, EventArgs e)
        {
            _obras.RetrocederParaObraAnterior();
            _obras.ExibirObraAtual(pbxImagemObra, lblDescricao); // Atualiza a exibição com a obra anterior
        }

        private void BotaoQuestionario_Click(object sender, EventArgs e)
        {
            pnlObraDescricao.Visible = false;
            pnlQuestionario.Show();
            _questionario.IncrementarContadorInteracoes();
            _questionario.MostrarProximaPergunta(lblPergunta, [chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo]);
        }

        private void BotaoVoltarObras_Click(object sender, EventArgs e)
        {
            pnlQuestionario.Visible = false;
            pnlObraDescricao.Show();
            _questionario.DecrementarContadorInteracoes();
        }

        private void ChkPessimo_CheckedChanged(object sender, EventArgs e)
        {
            _questionario.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkRuim_CheckedChanged(object sender, EventArgs e)
        {
            _questionario.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkRegular_CheckedChanged(object sender, EventArgs e)
        {
            _questionario.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkBom_CheckedChanged(object sender, EventArgs e)
        {
            _questionario.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkOtimo_CheckedChanged(object sender, EventArgs e)
        {
            _questionario.CheckBox_CheckedChanged(sender, e);
        }

        private void BtnProximaPergunta_Click(object sender, EventArgs e)
        {
            // Obter todas as respostas do formulário
            List<int> respostas = _questionario.ObterRespostasDoFormulario(
                [[chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo]]
            );

            // Verificar se todas as perguntas foram respondidas
            if (!_questionario.ValidarRespostas(respostas))
            {
                MessageBox.Show("Por favor, responda todas as perguntas.");
                return;
            }

            // Adicionar as respostas ao questionário
            _questionario.AdicionarRespostasDoFormulario(respostas);


            // Verificar se é a última pergunta
            if (_questionario.IndicePerguntaAtual >= _questionario.ObterPerguntas().Count)
            {
                // Se for a última pergunta, ocultar o botão "Próxima Pergunta" e exibir o botão "Finalizar"
                btnProximaPergunta.Visible = false;
                ButtonFinalizar_Click(sender, e);
            }
            else
            {
                // Mostrar a próxima pergunta e redefinir as checkboxes
                _questionario.MostrarProximaPergunta(lblPergunta, [chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo]);
            }
        }

        private void ButtonFinalizar_Click(object sender, EventArgs e)
        {
            // Obter o relatório cumulativo
            List<string> relatorio = _questionario.ObterRelatorioCumulativo();

            // Exibir o relatório
            MessageBox.Show(string.Join("\n", relatorio), "Relatório Total de Cada Resposta nas Interações");

            // Voltar para a tela inicial
            pnlQuestionario.Visible = false;
            pnlCadastro.Show();
            _questionario.IndicePerguntaAtual= 0;
            _formulario.LimparControles(Controls);
            btnProximaPergunta.Visible = true;
            btnFinalizar.Visible = false;
        }

    }
}
