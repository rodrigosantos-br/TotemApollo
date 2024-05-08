using TotemApollo.Apresentacoes;
using TotemApollo.Controles;
using TotemApollo.Modelos;

namespace TotemApollo
{
    public partial class Totem : Form
    {
        private readonly TecladoControle _teclado;
        private CadastroControle _cadastro;
        private ObrasControle _obras;
        private readonly QuestionarioControle _questionario;
        private readonly FormularioControle _formulario;

        public Totem()
        {
            InitializeComponent();
            _formulario = new FormularioControle();
            _questionario = new QuestionarioControle();
            _teclado = new TecladoControle();
            _teclado.TeclaProcessada += Teclado_TeclaProcessada;
        }

        private void Teclado_TeclaProcessada(object sender, string teclaProcessada)
        {
            if (teclaProcessada == "Enter")
            {
                // Clicar no botão "Iniciar"
                btnIniciar.PerformClick();
            }
            else if (teclaProcessada == "K")
            {
                _teclado.AbrirAreaSecreta();
            }
            else if (teclaProcessada == "Backspace")
            {
                _teclado.RemoveUltimoCaractere(txbNome);
            }
            else
            {
                // Adicionar a tecla processada ao texto
                txbNome.Text += teclaProcessada;
            }
        }

        private void TextBoxNome_Enter(object sender, EventArgs e)
        {
            _teclado.AdicionarTeclado(pnlCadastro);
        }

        private void TextBoxNome_Leave(object sender, EventArgs e)
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

        private void TextBoxDataNascimento_Enter(object sender, EventArgs e)
        {
            mtcCalendario.Visible = true;
            _teclado.RemoverTeclado(pnlCadastro);
        }

        private void TextBoxDataNascimento_Leave(object sender, EventArgs e)
        {
            if (ActiveControl != mtcCalendario)
                mtcCalendario.Visible = false;
        }

        private void BotaoIniciar_Click(object sender, EventArgs e)
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

        private void btnAvancarObra_Click(object sender, EventArgs e)
        {
            _obras.AvancarParaProximaObra();
            _obras.ExibirObraAtual(pbxImagemObra, lblDescricao); // Atualiza a exibição com a próxima obra
        }

        private void btnRetrocederObra_Click(object sender, EventArgs e)
        {
            _obras.RetrocederParaObraAnterior();
            _obras.ExibirObraAtual(pbxImagemObra, lblDescricao); // Atualiza a exibição com a obra anterior
        }

        private void BotaoQuestionario_Click(object sender, EventArgs e)
        {
            pnlObraDescricao.Visible = false;
            pnlQuestionario.Show();
            _questionario.IncrementarContadorInteracoes();
            // Defina a imagem de fundo de cada CheckBox como a imagem cinza correspondente
            chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
            chkRuim.BackgroundImage = Properties.Resources.estrelaRuimCinza;
            chkRegular.BackgroundImage = Properties.Resources.estrelaRegularCinza;
            chkBom.BackgroundImage = Properties.Resources.estrelaBomCinza;
            chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
        }

        private void BotaoVoltarObras_Click(object sender, EventArgs e)
        {
            pnlQuestionario.Visible = false;
            pnlObraDescricao.Show();
        }

        private void chkPessimo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPessimo.Checked)
            {
                _questionario.DesativarOutrosCheckBoxes(chkPessimo);
                chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimo;
                // Redefine as imagens dos outros CheckBoxes para cinza e desmarca-los
                chkRuim.BackgroundImage = Properties.Resources.estrelaRuimCinza;
                chkRuim.Checked = false;
                chkRegular.BackgroundImage = Properties.Resources.estrelaRegularCinza;
                chkRegular.Checked = false;
                chkBom.BackgroundImage = Properties.Resources.estrelaBomCinza;
                chkBom.Checked = false;
                chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
                chkOtimo.Checked = false;
            }
            else
            {
                _questionario.HabilitarCheckBoxes();
                chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
            }
        }

        private void chkRuim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRuim.Checked)
            {
                _questionario.DesativarOutrosCheckBoxes(chkRuim);
                chkRuim.BackgroundImage = Properties.Resources.estrelaRuim;
                // Redefine as imagens dos outros CheckBoxes para cinza e desmarca-los
                chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
                chkPessimo.Checked = false;
                chkRegular.BackgroundImage = Properties.Resources.estrelaRegularCinza;
                chkRegular.Checked = false;
                chkBom.BackgroundImage = Properties.Resources.estrelaBomCinza;
                chkBom.Checked = false;
                chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
                chkOtimo.Checked = false;
            }
            else
            {
                _questionario.HabilitarCheckBoxes();
                chkRuim.BackgroundImage = Properties.Resources.estrelaRuimCinza;
            }
        }

        private void chkRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegular.Checked)
            {
                _questionario.DesativarOutrosCheckBoxes(chkRegular);
                chkRegular.BackgroundImage = Properties.Resources.estrelaRegular;
                // Redefine as imagens dos outros CheckBoxes para cinza e desmarca-los
                chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
                chkPessimo.Checked = false;
                chkRuim.BackgroundImage = Properties.Resources.estrelaRuimCinza;
                chkRuim.Checked = false;
                chkBom.BackgroundImage = Properties.Resources.estrelaBomCinza;
                chkBom.Checked = false;
                chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
                chkOtimo.Checked = false;
            }
            else
            {
                _questionario.HabilitarCheckBoxes();
                chkRegular.BackgroundImage = Properties.Resources.estrelaRegularCinza;
            }
        }

        private void chkBom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBom.Checked)
            {
                _questionario.DesativarOutrosCheckBoxes(chkBom);
                chkBom.BackgroundImage = Properties.Resources.estrelaBom;
                // Redefine as imagens dos outros CheckBoxes para cinza e desmarca-los
                chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
                chkPessimo.Checked = false;
                chkRuim.BackgroundImage = Properties.Resources.estrelaRuimCinza;
                chkRuim.Checked = false;
                chkRegular.BackgroundImage = Properties.Resources.estrelaRegularCinza;
                chkRegular.Checked = false;
                chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
                chkOtimo.Checked = false;
            }
            else
            {
                _questionario.HabilitarCheckBoxes();
                chkBom.BackgroundImage = Properties.Resources.estrelaBomCinza;
            }
        }

        private void chkOtimo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtimo.Checked)
            {
                _questionario.DesativarOutrosCheckBoxes(chkOtimo);
                chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimo;
                // Redefine as imagens dos outros CheckBoxes para cinza e desmarca-los
                chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
                chkPessimo.Checked = false;
                chkRuim.BackgroundImage = Properties.Resources.estrelaRuimCinza;
                chkRuim.Checked = false;
                chkRegular.BackgroundImage = Properties.Resources.estrelaRegularCinza;
                chkRegular.Checked = false;
                chkBom.BackgroundImage = Properties.Resources.estrelaBomCinza;
                chkBom.Checked = false;
            }
            else
            {
                _questionario.HabilitarCheckBoxes();
                chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
            }
        }
    }
}
