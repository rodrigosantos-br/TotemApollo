namespace TotemApollo.Controles
{
    partial class ControleEstrelasSatisfacao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            chkPessimo = new CheckBox();
            chkOtimo = new CheckBox();
            lblOtimo = new Label();
            chkBom = new CheckBox();
            lblBom = new Label();
            chkRegular = new CheckBox();
            lblRegular = new Label();
            chkRuim = new CheckBox();
            lblRuim = new Label();
            lblPessimo = new Label();
            SuspendLayout();
            // 
            // chkPessimo
            // 
            chkPessimo.Anchor = AnchorStyles.None;
            chkPessimo.Appearance = Appearance.Button;
            chkPessimo.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
            chkPessimo.BackgroundImageLayout = ImageLayout.Center;
            chkPessimo.CheckAlign = ContentAlignment.MiddleCenter;
            chkPessimo.FlatAppearance.BorderColor = SystemColors.Control;
            chkPessimo.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkPessimo.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkPessimo.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkPessimo.FlatStyle = FlatStyle.Flat;
            chkPessimo.Location = new Point(22, 6);
            chkPessimo.Name = "chkPessimo";
            chkPessimo.Size = new Size(100, 100);
            chkPessimo.TabIndex = 24;
            chkPessimo.Tag = "estrelaPessimo";
            chkPessimo.UseVisualStyleBackColor = true;
            chkPessimo.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // chkOtimo
            // 
            chkOtimo.Anchor = AnchorStyles.None;
            chkOtimo.Appearance = Appearance.Button;
            chkOtimo.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
            chkOtimo.BackgroundImageLayout = ImageLayout.Center;
            chkOtimo.CheckAlign = ContentAlignment.MiddleCenter;
            chkOtimo.FlatAppearance.BorderColor = SystemColors.Control;
            chkOtimo.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkOtimo.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkOtimo.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkOtimo.FlatStyle = FlatStyle.Flat;
            chkOtimo.Location = new Point(568, 6);
            chkOtimo.Name = "chkOtimo";
            chkOtimo.Size = new Size(100, 100);
            chkOtimo.TabIndex = 30;
            chkOtimo.Tag = "estrelaOtimo";
            chkOtimo.UseVisualStyleBackColor = true;
            chkOtimo.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // lblOtimo
            // 
            lblOtimo.Anchor = AnchorStyles.None;
            lblOtimo.AutoSize = true;
            lblOtimo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblOtimo.Location = new Point(590, 109);
            lblOtimo.Margin = new Padding(2, 0, 2, 0);
            lblOtimo.Name = "lblOtimo";
            lblOtimo.Size = new Size(56, 21);
            lblOtimo.TabIndex = 37;
            lblOtimo.Text = "Ótimo";
            // 
            // chkBom
            // 
            chkBom.Anchor = AnchorStyles.None;
            chkBom.Appearance = Appearance.Button;
            chkBom.BackgroundImage = Properties.Resources.estrelaBomCinza;
            chkBom.BackgroundImageLayout = ImageLayout.Center;
            chkBom.CheckAlign = ContentAlignment.MiddleCenter;
            chkBom.FlatAppearance.BorderColor = SystemColors.Control;
            chkBom.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkBom.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkBom.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkBom.FlatStyle = FlatStyle.Flat;
            chkBom.Location = new Point(435, 6);
            chkBom.Name = "chkBom";
            chkBom.Size = new Size(100, 100);
            chkBom.TabIndex = 31;
            chkBom.Tag = "estrelaBom";
            chkBom.UseVisualStyleBackColor = true;
            chkBom.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // lblBom
            // 
            lblBom.Anchor = AnchorStyles.None;
            lblBom.AutoSize = true;
            lblBom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBom.Location = new Point(463, 109);
            lblBom.Margin = new Padding(2, 0, 2, 0);
            lblBom.Name = "lblBom";
            lblBom.Size = new Size(44, 21);
            lblBom.TabIndex = 36;
            lblBom.Text = "Bom";
            // 
            // chkRegular
            // 
            chkRegular.Anchor = AnchorStyles.None;
            chkRegular.Appearance = Appearance.Button;
            chkRegular.BackgroundImage = Properties.Resources.estrelaRegularCinza;
            chkRegular.BackgroundImageLayout = ImageLayout.Center;
            chkRegular.CheckAlign = ContentAlignment.MiddleCenter;
            chkRegular.FlatAppearance.BorderColor = SystemColors.Control;
            chkRegular.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkRegular.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkRegular.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkRegular.FlatStyle = FlatStyle.Flat;
            chkRegular.Location = new Point(293, 6);
            chkRegular.Name = "chkRegular";
            chkRegular.Size = new Size(100, 100);
            chkRegular.TabIndex = 32;
            chkRegular.Tag = "estrelaRegular";
            chkRegular.UseVisualStyleBackColor = true;
            chkRegular.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // lblRegular
            // 
            lblRegular.Anchor = AnchorStyles.None;
            lblRegular.AutoSize = true;
            lblRegular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRegular.Location = new Point(310, 109);
            lblRegular.Margin = new Padding(2, 0, 2, 0);
            lblRegular.Name = "lblRegular";
            lblRegular.Size = new Size(66, 21);
            lblRegular.TabIndex = 35;
            lblRegular.Text = "Regular";
            // 
            // chkRuim
            // 
            chkRuim.Anchor = AnchorStyles.None;
            chkRuim.Appearance = Appearance.Button;
            chkRuim.BackgroundImage = Properties.Resources.estrelaRuimCinza;
            chkRuim.BackgroundImageLayout = ImageLayout.Center;
            chkRuim.CheckAlign = ContentAlignment.MiddleCenter;
            chkRuim.FlatAppearance.BorderColor = SystemColors.Control;
            chkRuim.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkRuim.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkRuim.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkRuim.FlatStyle = FlatStyle.Flat;
            chkRuim.Location = new Point(150, 6);
            chkRuim.Name = "chkRuim";
            chkRuim.Size = new Size(100, 100);
            chkRuim.TabIndex = 33;
            chkRuim.Tag = "estrelaRuim";
            chkRuim.UseVisualStyleBackColor = true;
            chkRuim.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // lblRuim
            // 
            lblRuim.Anchor = AnchorStyles.None;
            lblRuim.AutoSize = true;
            lblRuim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRuim.Location = new Point(177, 109);
            lblRuim.Margin = new Padding(2, 0, 2, 0);
            lblRuim.Name = "lblRuim";
            lblRuim.Size = new Size(47, 21);
            lblRuim.TabIndex = 34;
            lblRuim.Text = "Ruim";
            // 
            // lblPessimo
            // 
            lblPessimo.Anchor = AnchorStyles.None;
            lblPessimo.AutoSize = true;
            lblPessimo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPessimo.Location = new Point(34, 109);
            lblPessimo.Margin = new Padding(2, 0, 2, 0);
            lblPessimo.Name = "lblPessimo";
            lblPessimo.Size = new Size(69, 21);
            lblPessimo.TabIndex = 38;
            lblPessimo.Text = "Péssimo";
            // 
            // ControleEstrelasSatisfacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(lblPessimo);
            Controls.Add(chkOtimo);
            Controls.Add(lblOtimo);
            Controls.Add(chkBom);
            Controls.Add(lblBom);
            Controls.Add(chkRegular);
            Controls.Add(lblRegular);
            Controls.Add(chkRuim);
            Controls.Add(lblRuim);
            Controls.Add(chkPessimo);
            Name = "ControleEstrelasSatisfacao";
            Size = new Size(686, 140);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPessimo;
        private CheckBox chkOtimo;
        private Label lblOtimo;
        private CheckBox chkBom;
        private Label lblBom;
        private CheckBox chkRegular;
        private Label lblRegular;
        private CheckBox chkRuim;
        private Label lblRuim;
        private Label lblPessimo;
    }
}
