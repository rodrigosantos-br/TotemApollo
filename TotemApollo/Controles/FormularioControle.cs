using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                else if (controle is RadioButton)
                {
                    ((RadioButton)controle).Checked = false;
                }

                // Recursivamente limpar os controles filhos, se houver
                if (controle.Controls.Count > 0)
                {
                    LimparControles(controle.Controls);
                }
            }
        }
    }
}
