namespace TotemApollo.Controles
{
    public class FormularioControle
    {
        public void LimparControles(Control.ControlCollection control)
        {
            foreach (Control controle in control)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
                else if (controle is ComboBox)
                {
                    ((ComboBox)controle).SelectedIndex = -1;
                }
                else if (controle is CheckBox)
                {
                    ((CheckBox)controle).Checked = false;
                }
                else if (controle is CheckBox)
                {
                    ((CheckBox)controle).Checked = false;
                }

                // Recursivamente limpar os controles filhos, se houver
                if (controle.Controls.Count > 0)
                {
                    LimparControles(controle.Controls);
                }
            }
        }

        // Método para iniciar o timer
        public void IniciarTimer(Control objetoAlvo, int intervalo)
        {
            System.Windows.Forms.Timer timer = new()
            {
                Interval = intervalo // Define o intervalo fornecido
            };
            timer.Tick += (sender, e) =>
            {
                objetoAlvo.Visible = false; // Oculta o objeto alvo
                timer.Stop(); // Para o Timer
                timer.Dispose(); // Libera os recursos do Timer
            };
            timer.Start(); // Inicia o Timer
        }

        public void IniciarTimer(Control control, int intervalo, Action callback)
        {
            System.Windows.Forms.Timer timer = new();
            timer.Interval = intervalo;
            timer.Tick += (s, e) =>
            {
                control.Visible = false;
                timer.Stop();
                callback?.Invoke();
            };
            timer.Start();
        }

    }
}
