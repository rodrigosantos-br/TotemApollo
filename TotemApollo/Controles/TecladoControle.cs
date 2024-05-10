using TotemApollo.Apresentacoes;
using TotemApollo.Controles;

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
            // Obtém a área de trabalho da tela principal
            Rectangle areaDeTrabalho = Screen.PrimaryScreen.WorkingArea;

            // Calcula a posição para centralizar horizontalmente e colocar na parte inferior da tela
            int x = (areaDeTrabalho.Width - this.Width) / 2;
            int y = areaDeTrabalho.Height - this.Height - 120; // Ajuste a quantidade de pixels conforme necessário

            // Define a posição do controle
            this.Location = new Point(x, y);

            // Adiciona o ControleTeclado ao formulário
            painel.Controls.Add(this);
        }

        public void RemoverTeclado(Panel painel)
        {
            painel.Controls.Remove(this);
        }

    }
}

