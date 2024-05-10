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
            dgvRelatorio = new DataGridView();
            dgvInteracoes = new DataGridViewTextBoxColumn();
            dgvMuitoSatisfeito = new DataGridViewTextBoxColumn();
            dgvSatisfeito = new DataGridViewTextBoxColumn();
            dgvRegular = new DataGridViewTextBoxColumn();
            dgvInsatisfeito = new DataGridViewTextBoxColumn();
            dgvMuitoInsatisfeito = new DataGridViewTextBoxColumn();
            btnVoltarCadastro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            SuspendLayout();
            // 
            // btnFecharPrograma
            // 
            btnFecharPrograma.Location = new Point(580, 211);
            btnFecharPrograma.Margin = new Padding(4);
            btnFecharPrograma.Name = "btnFecharPrograma";
            btnFecharPrograma.Size = new Size(142, 29);
            btnFecharPrograma.TabIndex = 0;
            btnFecharPrograma.Text = "Fechar Programa";
            btnFecharPrograma.UseVisualStyleBackColor = true;
            btnFecharPrograma.Click += BtnFecharPrograma_Click;
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
            dgvRelatorio.Location = new Point(96, 76);
            dgvRelatorio.Margin = new Padding(4);
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
            dgvRelatorio.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvRelatorio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvRelatorio.RowTemplate.ReadOnly = true;
            dgvRelatorio.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvRelatorio.ScrollBars = ScrollBars.None;
            dgvRelatorio.Size = new Size(626, 64);
            dgvRelatorio.TabIndex = 12;
            // 
            // dgvInteracoes
            // 
            dgvInteracoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvInteracoes.HeaderText = "Total de Interações";
            dgvInteracoes.MinimumWidth = 6;
            dgvInteracoes.Name = "dgvInteracoes";
            dgvInteracoes.ReadOnly = true;
            dgvInteracoes.Width = 164;
            // 
            // dgvMuitoSatisfeito
            // 
            dgvMuitoSatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMuitoSatisfeito.HeaderText = "Ótimo";
            dgvMuitoSatisfeito.MinimumWidth = 6;
            dgvMuitoSatisfeito.Name = "dgvMuitoSatisfeito";
            dgvMuitoSatisfeito.ReadOnly = true;
            dgvMuitoSatisfeito.Width = 80;
            // 
            // dgvSatisfeito
            // 
            dgvSatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSatisfeito.HeaderText = "Bom";
            dgvSatisfeito.MinimumWidth = 6;
            dgvSatisfeito.Name = "dgvSatisfeito";
            dgvSatisfeito.ReadOnly = true;
            dgvSatisfeito.Width = 69;
            // 
            // dgvRegular
            // 
            dgvRegular.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvRegular.HeaderText = "Regular";
            dgvRegular.MinimumWidth = 6;
            dgvRegular.Name = "dgvRegular";
            dgvRegular.ReadOnly = true;
            dgvRegular.Width = 89;
            // 
            // dgvInsatisfeito
            // 
            dgvInsatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvInsatisfeito.HeaderText = "Ruim";
            dgvInsatisfeito.MinimumWidth = 6;
            dgvInsatisfeito.Name = "dgvInsatisfeito";
            dgvInsatisfeito.ReadOnly = true;
            dgvInsatisfeito.Width = 72;
            // 
            // dgvMuitoInsatisfeito
            // 
            dgvMuitoInsatisfeito.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMuitoInsatisfeito.HeaderText = "Péssimo";
            dgvMuitoInsatisfeito.MinimumWidth = 6;
            dgvMuitoInsatisfeito.Name = "dgvMuitoInsatisfeito";
            dgvMuitoInsatisfeito.ReadOnly = true;
            dgvMuitoInsatisfeito.Width = 91;
            // 
            // btnVoltarCadastro
            // 
            btnVoltarCadastro.Location = new Point(96, 211);
            btnVoltarCadastro.Margin = new Padding(4);
            btnVoltarCadastro.Name = "btnVoltarCadastro";
            btnVoltarCadastro.Size = new Size(94, 29);
            btnVoltarCadastro.TabIndex = 13;
            btnVoltarCadastro.Text = "Voltar";
            btnVoltarCadastro.UseVisualStyleBackColor = true;
            btnVoltarCadastro.Click += BtnVoltarCadastro_Click;
            // 
            // AreaSecreta
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(818, 362);
            Controls.Add(btnVoltarCadastro);
            Controls.Add(dgvRelatorio);
            Controls.Add(btnFecharPrograma);
            Margin = new Padding(4);
            Name = "AreaSecreta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AreaSecreta";
            Load += AreaSecreta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFecharPrograma;
        private DataGridView dgvRelatorio;
        private DataGridViewTextBoxColumn dgvInteracoes;
        private DataGridViewTextBoxColumn dgvMuitoSatisfeito;
        private DataGridViewTextBoxColumn dgvSatisfeito;
        private DataGridViewTextBoxColumn dgvRegular;
        private DataGridViewTextBoxColumn dgvInsatisfeito;
        private DataGridViewTextBoxColumn dgvMuitoInsatisfeito;
        private Button btnVoltarCadastro;
    }
}