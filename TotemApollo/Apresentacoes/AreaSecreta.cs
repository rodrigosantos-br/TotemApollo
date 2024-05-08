using System;
using System.Collections.Generic;
using System.ComponentModel;

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

        private void btnMostrarRelatorio_Click(object sender, EventArgs e)
        {
            // Obter as porcentagens totais para cada categoria de resposta
            List<double> porcentagens = _questionario.ObterPorcentagens();

            // Limpar as células do DataGridView
            dgvRelatorio.Rows.Clear();

            // Adicionar uma nova linha ao DataGridView
            dgvRelatorio.Rows.Add();

            // Definir os valores das células na única linha do DataGridView
            dgvRelatorio.Rows[0].Cells[0].Value = _questionario.ObterContadorInteracoes(); // Total de Interações
            dgvRelatorio.Rows[0].Cells[1].Value = $"{porcentagens[4]:0.00}%"; // Muito Satisfeito
            dgvRelatorio.Rows[0].Cells[2].Value = $"{porcentagens[3]:0.00}%"; // Satisfeito
            dgvRelatorio.Rows[0].Cells[3].Value = $"{porcentagens[2]:0.00}%"; // Regular
            dgvRelatorio.Rows[0].Cells[4].Value = $"{porcentagens[1]:0.00}%"; // Insatisfeito
            dgvRelatorio.Rows[0].Cells[5].Value = $"{porcentagens[0]:0.00}%"; // Muito Insatisfeito
        }

        private void btnFecharPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
