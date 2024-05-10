using TotemApollo.Controles;

namespace TotemApollo.Apresentacoes
{
    public partial class AreaSecreta : Form
    {
        private QuestionarioControle _questionario;

        public AreaSecreta()
        {
            InitializeComponent();
            _questionario = new QuestionarioControle();
        }

        private void BtnFecharPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVoltarCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AreaSecreta_Load(object sender, EventArgs e)
        {
            // Obter as porcentagens totais para cada categoria de resposta
            List<double> porcentagens = _questionario.ObterPorcentagens();

            // Definir os valores das células na única linha do DataGridView
            dgvRelatorio.Rows[0].Cells[0].Value = _questionario.ObterContadorInteracoes(); // Total de Interações
            dgvRelatorio.Rows[0].Cells[1].Value = $"{porcentagens[4]:0.00}%"; // Muito Satisfeito
            dgvRelatorio.Rows[0].Cells[2].Value = $"{porcentagens[3]:0.00}%"; // Satisfeito
            dgvRelatorio.Rows[0].Cells[3].Value = $"{porcentagens[2]:0.00}%"; // Regular
            dgvRelatorio.Rows[0].Cells[4].Value = $"{porcentagens[1]:0.00}%"; // Insatisfeito
            dgvRelatorio.Rows[0].Cells[5].Value = $"{porcentagens[0]:0.00}%"; // Muito Insatisfeito
        }
    }
}
