using TotemApollo.Controles;

namespace TotemApollo
{
    public partial class Totem : Form
    {
        private readonly TecladoControle _teclado;
        private CadastroControle _cadastro;
        private ObrasControle _obras;
        private readonly QuestionarioInteracaoControle _questionarioInteracao;
        private readonly QuestionarioSatisfacaoControle _questionarioSatisfacao;
        private readonly FormularioControle _formulario;
        private readonly List<CheckBox> _checkboxes;
        private readonly List<Button> _buttons;

        public Totem()
        {
            InitializeComponent();

            _formulario = new FormularioControle();
            _teclado = new TecladoControle();
            _teclado.TeclaProcessada += Teclado_TeclaProcessada;
            // Inicializa a lista de botões antes de passá-la para o controle QuestionarioInteracaoControle
            _buttons = [btnRespostaA, btnRespostaB, btnRespostaC, btnRespostaD, btnRespostaE];
            _questionarioInteracao = new QuestionarioInteracaoControle(_buttons); // Passa a lista de botões aqui
            _questionarioSatisfacao = new QuestionarioSatisfacaoControle();
            _checkboxes = [chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo];
            _questionarioSatisfacao.AssociarCheckBoxes(_checkboxes);
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
            // Preenche a data de nascimento com a data selecionada no calendário
            txbDataNascimento.Text = mtcCalendario.SelectionStart.ToShortDateString();
            mtcCalendario.Visible = false;
        }

        private void TxbDataNascimento_Enter(object sender, EventArgs e)
        {
            // Calendário visível apenas se o textBox do mesmo estiver selecionado e remove o teclado
            mtcCalendario.Visible = true;
            _teclado.RemoverTeclado(pnlCadastro);
        }

        private void TxbDataNascimento_Leave(object sender, EventArgs e)
        {
            // Mantém o calendário visível caso o foco seja o calendário
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

        private void BtnQuestionarioInteracao_Click(object sender, EventArgs e)
        {
            pnlObraDescricao.Visible = false;
            btnVoltarQ.Visible = true;
            pnlQuestionario.Show();
            _questionarioSatisfacao.IncrementarContadorInteracoes();
            _questionarioInteracao.ExibirProximaPergunta(lblPergunta);
            pnlEstrelasSatisfacao.Visible = false;
            pnlOpcoesRespostaInteracoes.Show();
            btnProximaPerguntaInteracao.Visible = true;
            btnProximaPerguntaSatisfacao.Visible = false;
            pcbBalaoInformacao.BackgroundImage = Properties.Resources.imgBalaoQuiz;
            pcbBalaoInformacao.BackgroundImageLayout = ImageLayout.Stretch;
            pcbBalaoInformacao.Visible = true;
            // Define um Timer para ocultar a imagem após 3,8 segundos
            _formulario.IniciarTimer(pcbBalaoInformacao, 3800);
        }

        private void BotaoVoltarObras_Click(object sender, EventArgs e)
        {
            pnlQuestionario.Visible = false;
            pnlObraDescricao.Show();
            _questionarioSatisfacao.DecrementarContadorInteracoes();
            _questionarioInteracao.ExibirPerguntaAnterior(lblPergunta);
            foreach (Button botao in _buttons)
            {
                botao.Enabled = true;
            }
        }

        // Troca a imagem do checkBox de acordo com o estado
        private void ChkPessimo_CheckedChanged(object sender, EventArgs e)
        {
            _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkRuim_CheckedChanged(object sender, EventArgs e)
        {
            _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkRegular_CheckedChanged(object sender, EventArgs e)
        {
            _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkBom_CheckedChanged(object sender, EventArgs e)
        {
            _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e);
        }

        private void ChkOtimo_CheckedChanged(object sender, EventArgs e)
        {
            _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e);
        }

        private void BtnRespostaInteracao_Click(object sender, EventArgs e)
        {
            // Captura o botão clicado
            Button botaoResposta = (Button)sender;
            string respostaUsuario = botaoResposta.Text;

            // Verifica a resposta do usuário e atualiza a cor dos botões
            _questionarioInteracao.VerificarResposta(respostaUsuario, botaoResposta);
            lblExplicacaoResposta.Visible = true;
            _questionarioInteracao.MostrarExplicacaoResposta(lblExplicacaoResposta);
            // Desativa todos os botões de resposta
            foreach (Button botao in _buttons)
            {
                botao.Enabled = false;
            }
        }

        private void BtnProximaPerguntaInteracao_Click(object sender, EventArgs e)
        {
            // Verificar se todas as perguntas foram respondidas
            if (!_questionarioInteracao.ValidarRespostas())
            {
                MessageBox.Show("Por favor, responda todas as perguntas.");
                return;
            }

            lblExplicacaoResposta.Visible = false;
            _questionarioInteracao.ExibirProximaPergunta(lblPergunta);

            // Verificar se não há mais perguntas disponíveis
            if (_questionarioInteracao.IndicePerguntaAtual == _questionarioInteracao.ObterNumeroPerguntas())
            {
                pnlOpcoesRespostaInteracoes.Visible = false;
                btnProximaPerguntaInteracao.Visible = false;
                lblRelatorioAcumuladoQuestionarioInteracao.Text = _questionarioInteracao.ExibirRelatorioInteracao();
                pnlRelatorioAcumuladoInteracao.Visible = true;
                // Limpar os botões de resposta
                foreach (Button botao in _buttons)
                {
                    botao.Enabled = true;
                }
            }
            else
            {
                // Ativar todos os botões de resposta para a próxima pergunta
                foreach (Button botao in _buttons)
                {
                    botao.Enabled = true;
                }
            }
        }

        private void BtnAvancarParaQuestionarioSatisfacao_Click(object sender, EventArgs e)
        {
            pnlRelatorioAcumuladoInteracao.Visible = false;
            pnlEstrelasSatisfacao.Visible = true;
            btnProximaPerguntaSatisfacao.Visible = true;
            pcbBalaoInformacao.BackgroundImage = Properties.Resources.imgBalaoSatisfacao;
            pcbBalaoInformacao.Visible = true;
            btnVoltarQ.Visible = false;
            _formulario.IniciarTimer(pcbBalaoInformacao, 3800); // Define um Timer para ocultar a imagem após 3,8 segundos
            _questionarioSatisfacao.MostrarProximaPergunta(lblPergunta, [chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo]); // Mostrar a próxima pergunta no questionário de satisfação
            _questionarioInteracao.ResetarContadorVisitanteAtual();
        }

        private void BtnProximaPerguntaSatisfacao_Click(object sender, EventArgs e)
        {
            // Obter todas as respostas do formulário
            List<int> respostas = _questionarioSatisfacao.ObterRespostasDoFormulario(
                [[chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo]]
            );

            // Verificar se todas as perguntas foram respondidas
            if (!QuestionarioSatisfacaoControle.ValidarRespostas(respostas))
            {
                MessageBox.Show("Por favor, responda todas as perguntas.");
                return;
            }

            // Adicionar as respostas ao questionário
            _questionarioSatisfacao.AdicionarRespostasDoFormulario(respostas);


            // Verificar se é a última pergunta
            if (_questionarioSatisfacao.IndicePerguntaAtual >= _questionarioSatisfacao.ObterPerguntas().Count)
            {
                pnlRelatorioAcumuladoSatisfacao.Visible = true;
                _formulario.IniciarTimer(pnlRelatorioAcumuladoSatisfacao, 10000, () => BtnFinalizar_Click(sender, e));
                btnProximaPerguntaSatisfacao.Visible = false;
                btnVoltarQ.Visible = false;
                // Obter o relatório cumulativo
                List<string> relatorio = _questionarioSatisfacao.ObterRelatorioCumulativo();

                // Exibir o relatório
                lblRelatorioAcumuladoSatisfacao.Text = string.Join("\n", relatorio);
            }
            else
            {
                // Mostrar a próxima pergunta e redefinir as checkboxes
                _questionarioSatisfacao.MostrarProximaPergunta(lblPergunta, [chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo]);
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            // Voltar para a tela inicial
            pnlQuestionario.Visible = false;
            pnlCadastro.Show();
            _questionarioSatisfacao.IndicePerguntaAtual = 0;
            _formulario.LimparControles(Controls);
            btnProximaPerguntaSatisfacao.Visible = true;
        }

    }
}
