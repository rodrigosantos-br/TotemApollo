namespace TotemApollo.Controles
{
    public partial class ControleEstrelasSatisfacao : UserControl
    {
        private Dictionary<string, (Image CheckedImage, Image UncheckedImage)> imagensEstrelas;

        public ControleEstrelasSatisfacao()
        {
            InitializeComponent();
            InicializarImagens();
        }

        private void InicializarImagens()
        {
            imagensEstrelas = new Dictionary<string, (System.Drawing.Image, System.Drawing.Image)>
            {
                { "chkPessimo", (Properties.Resources.estrelaPessimo, Properties.Resources.estrelaPessimoCinza) },
                { "chkRuim", (Properties.Resources.estrelaRuim, Properties.Resources.estrelaRuimCinza) },
                { "chkRegular", (Properties.Resources.estrelaRegular, Properties.Resources.estrelaRegularCinza) },
                { "chkBom", (Properties.Resources.estrelaBom, Properties.Resources.estrelaBomCinza) },
                { "chkOtimo", (Properties.Resources.estrelaOtimo, Properties.Resources.estrelaOtimoCinza) }
            };
        }

        private void DesmarcarOutrosCheckBoxes(CheckBox senderCheckBox)
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    bool isChecked = checkBox == senderCheckBox;
                    checkBox.Checked = isChecked;
                    TrocarImagemDeFundo(checkBox, isChecked);
                }
            }
        }

        private void TrocarImagemDeFundo(CheckBox checkBox, bool isChecked)
        {
            if (imagensEstrelas.TryGetValue(checkBox.Name, out var imagens))
            {
                checkBox.BackgroundImage = isChecked ? imagens.CheckedImage : imagens.UncheckedImage;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox && checkBox.Checked)
            {
                DesmarcarOutrosCheckBoxes(checkBox);
            }
            else if (sender is CheckBox chk)
            {
                TrocarImagemDeFundo(chk, false);
            }
        }
    }
}
