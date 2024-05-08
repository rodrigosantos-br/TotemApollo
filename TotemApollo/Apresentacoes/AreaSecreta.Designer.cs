namespace TotemApollo.Apresentacoes
{
    partial class AreaSecreta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnFecharPrograma = new Button();
            btnMostrarRelatorio = new Button();
            dgvRelatorio = new DataGridView();
            dgvInteracoes = new DataGridViewTextBoxColumn();
            dgvMuitoSatisfeito = new DataGridViewTextBoxColumn();
            dgvSatisfeito = new DataGridViewTextBoxColumn();
            dgvRegular = new DataGridViewTextBoxColumn();
            dgvInsatisfeito = new DataGridViewTextBoxColumn();
            dgvMuitoInsatisfeito = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            SuspendLayout();
            // 
            // btnFecharPrograma
            // 
            btnFecharPrograma.Location = new Point(304, 207);
            btnFecharPrograma.Name = "btnFecharPrograma";
            btnFecharPrograma.Size = new Size(114, 23);
            btnFecharPrograma.TabIndex = 0;
            btnFecharPrograma.Text = "Fechar Programa";
            btnFecharPrograma.UseVisualStyleBackColor = true;
            btnFecharPrograma.Click += btnFecharPrograma_Click;
            // 
            // btnMostrarRelatorio
            // 
            btnMostrarRelatorio.Location = new Point(304, 158);
            btnMostrarRelatorio.Name = "btnMostrarRelatorio";
            btnMostrarRelatorio.Size = new Size(114, 23);
            btnMostrarRelatorio.TabIndex = 1;
            btnMostrarRelatorio.Text = "Mostrar Relatório";
            btnMostrarRelatorio.UseVisualStyleBackColor = true;
            btnMostrarRelatorio.Click += btnMostrarRelatorio_Click;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.CellBorderStyle = DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Columns.AddRange(new DataGridViewColumn[] { dgvInteracoes, dgvMuitoSatisfeito, dgvSatisfeito, dgvRegular, dgvInsatisfeito, dgvMuitoInsatisfeito });
            dgvRelatorio.Location = new Point(36, 61);
            dgvRelatorio.MultiSelect = false;
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgvRelatorio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvRelatorio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvRelatorio.RowTemplate.ReadOnly = true;
            dgvRelatorio.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvRelatorio.ScrollBars = ScrollBars.None;
            dgvRelatorio.Size = new Size(650, 51);
            dgvRelatorio.TabIndex = 12;
            // 
            // dgvInteracoes
            // 
            dgvInteracoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvInteracoes.HeaderText = "Total de Interações";
            dgvInteracoes.Name = "dgvInteracoes";
            dgvInteracoes.ReadOnly = true;
            dgvInteracoes.Width = 130;
            // 
            // dgvMuitoSatisfeito
            // 
            dgvMuitoSatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMuitoSatisfeito.HeaderText = "MuitoSatisfeito";
            dgvMuitoSatisfeito.Name = "dgvMuitoSatisfeito";
            dgvMuitoSatisfeito.ReadOnly = true;
            dgvMuitoSatisfeito.Width = 112;
            // 
            // dgvSatisfeito
            // 
            dgvSatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSatisfeito.HeaderText = "Satisfeito";
            dgvSatisfeito.Name = "dgvSatisfeito";
            dgvSatisfeito.ReadOnly = true;
            dgvSatisfeito.Width = 80;
            // 
            // dgvRegular
            // 
            dgvRegular.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRegular.HeaderText = "Regular";
            dgvRegular.Name = "dgvRegular";
            dgvRegular.ReadOnly = true;
            dgvRegular.Width = 72;
            // 
            // dgvInsatisfeito
            // 
            dgvInsatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvInsatisfeito.HeaderText = "Insatisfeito";
            dgvInsatisfeito.Name = "dgvInsatisfeito";
            dgvInsatisfeito.ReadOnly = true;
            dgvInsatisfeito.Width = 89;
            // 
            // dgvMuitoInsatisfeito
            // 
            dgvMuitoInsatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMuitoInsatisfeito.HeaderText = "Muito Insatisfeito";
            dgvMuitoInsatisfeito.Name = "dgvMuitoInsatisfeito";
            dgvMuitoInsatisfeito.ReadOnly = true;
            dgvMuitoInsatisfeito.Width = 124;
            // 
            // AreaSecreta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 290);
            Controls.Add(dgvRelatorio);
            Controls.Add(btnMostrarRelatorio);
            Controls.Add(btnFecharPrograma);
            Name = "AreaSecreta";
            Text = "AreaSecreta";
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFecharPrograma;
        private Button btnMostrarRelatorio;
        private DataGridView dgvRelatorio;
        private DataGridViewTextBoxColumn dgvInteracoes;
        private DataGridViewTextBoxColumn dgvMuitoSatisfeito;
        private DataGridViewTextBoxColumn dgvSatisfeito;
        private DataGridViewTextBoxColumn dgvRegular;
        private DataGridViewTextBoxColumn dgvInsatisfeito;
        private DataGridViewTextBoxColumn dgvMuitoInsatisfeito;
    }
}