using TotemApollo.Apresentacoes;

namespace TotemApollo
{
    public partial class TecladoControle : UserControl
    {
        private bool capsAtivado;
        private bool shiftAtivado;
        private string teclaProcessada;

        public event EventHandler<string> TeclaProcessada;

        public TecladoControle()
        {
            InitializeComponent();
        }

        public void AbrirAreaSecreta()
        {
            if (chkCtrl.Checked && chkAlt.Checked)
            {
                AreaSecreta areaSecreta = new();
                areaSecreta.Show();
                chkAlt.Checked = false;
                chkCtrl.Checked = false;
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            TeclaProcessada?.Invoke(this, "Enter");
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            TeclaProcessada?.Invoke(this, "Backspace");
        }

        public void Tecla_Click(object sender, EventArgs e)
        {
            Button tecla = (Button)sender;
            teclaProcessada = ProcessarTecla(chkShift.Checked, chkCaps.Checked, tecla.Text);
            chkShift.Checked = false;

            // Dispara o evento TeclaPressionada
            TeclaProcessada?.Invoke(this, teclaProcessada);
        }

        private string ProcessarTecla(bool shift, bool caps, string teclaPressionada)
        {
            capsAtivado = caps;
            shiftAtivado = shift;

            // Verifica se a tecla é uma letra
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                if (teclaPressionada == letra.ToString())
                {
                    return capsAtivado || shiftAtivado ? teclaPressionada : teclaPressionada.ToLower();
                }
            }

            switch (teclaPressionada)
            {
                case "Space":
                    return " ";
                default:
                    return null;
            }
        }

        public void RemoveUltimoCaractere(TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }

        public void AdicionarTeclado(Panel painel)
        {
            // Adiciona o ControleTeclado ao formulário
            painel.Controls.Add(this);

            // Subscreve o evento LocationChanged do formulário principal
            if (this.ParentForm != null)
            {
                this.ParentForm.LocationChanged += Form_LocationChanged;
            }

            // Chama o método para posicionar o teclado virtual pela primeira vez
            ReposicionarTeclado();
        }

        private void Form_LocationChanged(object sender, EventArgs e)
        {
            // Quando a posição do formulário principal mudar, reposiciona o teclado virtual
            ReposicionarTeclado();
        }

        private void ReposicionarTeclado()
        {
            if (this.ParentForm != null)
            {
                // Obtém a área de trabalho do monitor em que o formulário principal está
                Rectangle areaDeTrabalho = Screen.FromControl(this.ParentForm).WorkingArea;

                // Calcula a posição para centralizar horizontalmente e colocar na parte inferior da tela
                int x = (areaDeTrabalho.Width - this.Width) / 2;
                int y = areaDeTrabalho.Height - this.Height - 150; // Ajuste da quantidade de pixels conforme necessário

                // Define a posição do controle
                this.Location = new Point(x, y);
            }
        }

        public void RemoverTeclado(Panel painel)
        {
            // Remove o ControleTeclado do formulário
            painel.Controls.Remove(this);

            // Remove o manipulador de eventos LocationChanged
            if (this.ParentForm != null)
            {
                this.ParentForm.LocationChanged -= Form_LocationChanged;
            }
        }
    }
}

