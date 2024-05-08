namespace TotemApollo
{
    partial class Totem
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
            lblNome = new Label();
            txbNome = new TextBox();
            lblDataNascimento = new Label();
            txbDataNascimento = new TextBox();
            btnIniciar = new Button();
            mtcCalendario = new MonthCalendar();
            pnlCadastro = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pnlObraDescricao = new Panel();
            lblDescricao = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnAvancarObra = new Button();
            btnRetrocederObra = new Button();
            pbxImagemObra = new PictureBox();
            btnVoltar = new Button();
            btnQuestionario = new Button();
            pnlQuestionario = new Panel();
            btnProximaPergunta = new Button();
            chkPessimo = new CheckBox();
            chkRuim = new CheckBox();
            chkRegular = new CheckBox();
            chkBom = new CheckBox();
            chkOtimo = new CheckBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblPergunta = new Label();
            btnFinalizar = new Button();
            btnVoltarQ = new Button();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlObraDescricao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagemObra).BeginInit();
            pnlQuestionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(398, 159);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(51, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.AcceptsTab = true;
            txbNome.Anchor = AnchorStyles.None;
            txbNome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNome.ImeMode = ImeMode.On;
            txbNome.Location = new Point(454, 151);
            txbNome.Margin = new Padding(3, 2, 3, 2);
            txbNome.MaxLength = 20;
            txbNome.Name = "txbNome";
            txbNome.PlaceholderText = "Digite seu primeiro nome.";
            txbNome.Size = new Size(277, 32);
            txbNome.TabIndex = 1;
            txbNome.Enter += TextBoxNome_Enter;
            txbNome.Leave += TextBoxNome_Leave;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.None;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataNascimento.Location = new Point(304, 200);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(147, 20);
            lblDataNascimento.TabIndex = 2;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txbDataNascimento
            // 
            txbDataNascimento.Anchor = AnchorStyles.None;
            txbDataNascimento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDataNascimento.Location = new Point(454, 194);
            txbDataNascimento.Margin = new Padding(3, 2, 3, 2);
            txbDataNascimento.MaxLength = 10;
            txbDataNascimento.Name = "txbDataNascimento";
            txbDataNascimento.PlaceholderText = "Digite sua data de nascimento.";
            txbDataNascimento.Size = new Size(277, 32);
            txbDataNascimento.TabIndex = 2;
            txbDataNascimento.Enter += TextBoxDataNascimento_Enter;
            txbDataNascimento.Leave += TextBoxDataNascimento_Leave;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(532, 281);
            btnIniciar.Margin = new Padding(3, 2, 3, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(120, 36);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += BotaoIniciar_Click;
            // 
            // mtcCalendario
            // 
            mtcCalendario.Anchor = AnchorStyles.None;
            mtcCalendario.Location = new Point(715, 214);
            mtcCalendario.MaxDate = new DateTime(2014, 12, 31, 0, 0, 0, 0);
            mtcCalendario.MinDate = new DateTime(1924, 1, 1, 0, 0, 0, 0);
            mtcCalendario.Name = "mtcCalendario";
            mtcCalendario.ShowTodayCircle = false;
            mtcCalendario.TabIndex = 6;
            mtcCalendario.Visible = false;
            mtcCalendario.DateSelected += DataNascimento_DateSelected;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Controls.Add(pictureBox4);
            pnlCadastro.Controls.Add(pictureBox3);
            pnlCadastro.Controls.Add(mtcCalendario);
            pnlCadastro.Controls.Add(txbDataNascimento);
            pnlCadastro.Controls.Add(btnIniciar);
            pnlCadastro.Controls.Add(lblDataNascimento);
            pnlCadastro.Controls.Add(lblNome);
            pnlCadastro.Controls.Add(txbNome);
            pnlCadastro.Dock = DockStyle.Fill;
            pnlCadastro.Location = new Point(0, 0);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1184, 667);
            pnlCadastro.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Bottom;
            pictureBox4.Image = Properties.Resources.imgRodape;
            pictureBox4.Location = new Point(0, 547);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1184, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = Properties.Resources.imgCabecalho1;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1184, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pnlObraDescricao
            // 
            pnlObraDescricao.AccessibleRole = AccessibleRole.ScrollBar;
            pnlObraDescricao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlObraDescricao.Controls.Add(lblDescricao);
            pnlObraDescricao.Controls.Add(pictureBox2);
            pnlObraDescricao.Controls.Add(pictureBox1);
            pnlObraDescricao.Controls.Add(btnAvancarObra);
            pnlObraDescricao.Controls.Add(btnRetrocederObra);
            pnlObraDescricao.Controls.Add(pbxImagemObra);
            pnlObraDescricao.Controls.Add(btnVoltar);
            pnlObraDescricao.Controls.Add(btnQuestionario);
            pnlObraDescricao.Dock = DockStyle.Fill;
            pnlObraDescricao.Location = new Point(0, 0);
            pnlObraDescricao.Margin = new Padding(1);
            pnlObraDescricao.Name = "pnlObraDescricao";
            pnlObraDescricao.Size = new Size(1184, 667);
            pnlObraDescricao.TabIndex = 5;
            pnlObraDescricao.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.None;
            lblDescricao.AutoEllipsis = true;
            lblDescricao.FlatStyle = FlatStyle.Flat;
            lblDescricao.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(585, 159);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(483, 329);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição da obra aqui.";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.imgRodape;
            pictureBox2.Location = new Point(0, 547);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1184, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.imgCabecalho1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1184, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnAvancarObra
            // 
            btnAvancarObra.Anchor = AnchorStyles.None;
            btnAvancarObra.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvancarObra.Location = new Point(502, 308);
            btnAvancarObra.Name = "btnAvancarObra";
            btnAvancarObra.Size = new Size(50, 50);
            btnAvancarObra.TabIndex = 5;
            btnAvancarObra.Text = ">";
            btnAvancarObra.UseVisualStyleBackColor = true;
            btnAvancarObra.Click += btnAvancarObra_Click;
            // 
            // btnRetrocederObra
            // 
            btnRetrocederObra.Anchor = AnchorStyles.None;
            btnRetrocederObra.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetrocederObra.Location = new Point(97, 308);
            btnRetrocederObra.Name = "btnRetrocederObra";
            btnRetrocederObra.Size = new Size(50, 50);
            btnRetrocederObra.TabIndex = 4;
            btnRetrocederObra.Text = "<";
            btnRetrocederObra.UseVisualStyleBackColor = true;
            btnRetrocederObra.Click += btnRetrocederObra_Click;
            // 
            // pbxImagemObra
            // 
            pbxImagemObra.Anchor = AnchorStyles.None;
            pbxImagemObra.Location = new Point(153, 124);
            pbxImagemObra.Margin = new Padding(3, 2, 3, 2);
            pbxImagemObra.Name = "pbxImagemObra";
            pbxImagemObra.Size = new Size(342, 419);
            pbxImagemObra.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImagemObra.TabIndex = 0;
            pbxImagemObra.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(10, 502);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(88, 36);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "< Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnQuestionario
            // 
            btnQuestionario.Anchor = AnchorStyles.None;
            btnQuestionario.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuestionario.Location = new Point(1014, 502);
            btnQuestionario.Name = "btnQuestionario";
            btnQuestionario.Size = new Size(160, 36);
            btnQuestionario.TabIndex = 3;
            btnQuestionario.Text = "Iniciar Questionário";
            btnQuestionario.UseVisualStyleBackColor = true;
            btnQuestionario.Click += BotaoQuestionario_Click;
            // 
            // pnlQuestionario
            // 
            pnlQuestionario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlQuestionario.Controls.Add(btnProximaPergunta);
            pnlQuestionario.Controls.Add(chkPessimo);
            pnlQuestionario.Controls.Add(chkRuim);
            pnlQuestionario.Controls.Add(chkRegular);
            pnlQuestionario.Controls.Add(chkBom);
            pnlQuestionario.Controls.Add(chkOtimo);
            pnlQuestionario.Controls.Add(pictureBox6);
            pnlQuestionario.Controls.Add(pictureBox5);
            pnlQuestionario.Controls.Add(lblPergunta);
            pnlQuestionario.Controls.Add(btnFinalizar);
            pnlQuestionario.Controls.Add(btnVoltarQ);
            pnlQuestionario.Dock = DockStyle.Fill;
            pnlQuestionario.Location = new Point(0, 0);
            pnlQuestionario.Name = "pnlQuestionario";
            pnlQuestionario.Size = new Size(1184, 667);
            pnlQuestionario.TabIndex = 12;
            pnlQuestionario.Visible = false;
            // 
            // btnProximaPergunta
            // 
            btnProximaPergunta.Anchor = AnchorStyles.None;
            btnProximaPergunta.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnProximaPergunta.Location = new Point(1084, 507);
            btnProximaPergunta.Margin = new Padding(3, 2, 3, 2);
            btnProximaPergunta.Name = "btnProximaPergunta";
            btnProximaPergunta.Size = new Size(88, 36);
            btnProximaPergunta.TabIndex = 24;
            btnProximaPergunta.TabStop = false;
            btnProximaPergunta.Text = "Próxima";
            btnProximaPergunta.UseVisualStyleBackColor = true;
            // 
            // chkPessimo
            // 
            chkPessimo.Anchor = AnchorStyles.None;
            chkPessimo.Appearance = Appearance.Button;
            chkPessimo.BackgroundImageLayout = ImageLayout.Center;
            chkPessimo.CheckAlign = ContentAlignment.MiddleCenter;
            chkPessimo.FlatAppearance.BorderColor = SystemColors.Control;
            chkPessimo.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkPessimo.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkPessimo.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkPessimo.FlatStyle = FlatStyle.Flat;
            chkPessimo.Location = new Point(287, 363);
            chkPessimo.Name = "chkPessimo";
            chkPessimo.Size = new Size(90, 85);
            chkPessimo.TabIndex = 23;
            chkPessimo.UseVisualStyleBackColor = true;
            chkPessimo.CheckedChanged += chkPessimo_CheckedChanged;
            // 
            // chkRuim
            // 
            chkRuim.Anchor = AnchorStyles.None;
            chkRuim.Appearance = Appearance.Button;
            chkRuim.BackgroundImageLayout = ImageLayout.Center;
            chkRuim.CheckAlign = ContentAlignment.MiddleCenter;
            chkRuim.FlatAppearance.BorderColor = SystemColors.Control;
            chkRuim.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkRuim.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkRuim.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkRuim.FlatStyle = FlatStyle.Flat;
            chkRuim.Location = new Point(417, 363);
            chkRuim.Name = "chkRuim";
            chkRuim.Size = new Size(90, 85);
            chkRuim.TabIndex = 22;
            chkRuim.UseVisualStyleBackColor = true;
            chkRuim.CheckedChanged += chkRuim_CheckedChanged;
            // 
            // chkRegular
            // 
            chkRegular.Anchor = AnchorStyles.None;
            chkRegular.Appearance = Appearance.Button;
            chkRegular.BackgroundImageLayout = ImageLayout.Center;
            chkRegular.CheckAlign = ContentAlignment.MiddleCenter;
            chkRegular.FlatAppearance.BorderColor = SystemColors.Control;
            chkRegular.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkRegular.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkRegular.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkRegular.FlatStyle = FlatStyle.Flat;
            chkRegular.Location = new Point(547, 363);
            chkRegular.Name = "chkRegular";
            chkRegular.Size = new Size(90, 85);
            chkRegular.TabIndex = 21;
            chkRegular.UseVisualStyleBackColor = true;
            chkRegular.CheckedChanged += chkRegular_CheckedChanged;
            // 
            // chkBom
            // 
            chkBom.Anchor = AnchorStyles.None;
            chkBom.Appearance = Appearance.Button;
            chkBom.BackgroundImageLayout = ImageLayout.Center;
            chkBom.CheckAlign = ContentAlignment.MiddleCenter;
            chkBom.FlatAppearance.BorderColor = SystemColors.Control;
            chkBom.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkBom.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkBom.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkBom.FlatStyle = FlatStyle.Flat;
            chkBom.Location = new Point(677, 363);
            chkBom.Name = "chkBom";
            chkBom.Size = new Size(90, 85);
            chkBom.TabIndex = 20;
            chkBom.UseVisualStyleBackColor = true;
            chkBom.CheckedChanged += chkBom_CheckedChanged;
            // 
            // chkOtimo
            // 
            chkOtimo.Anchor = AnchorStyles.None;
            chkOtimo.Appearance = Appearance.Button;
            chkOtimo.BackgroundImageLayout = ImageLayout.Center;
            chkOtimo.CheckAlign = ContentAlignment.MiddleCenter;
            chkOtimo.FlatAppearance.BorderColor = SystemColors.Control;
            chkOtimo.FlatAppearance.CheckedBackColor = SystemColors.Control;
            chkOtimo.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            chkOtimo.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            chkOtimo.FlatStyle = FlatStyle.Flat;
            chkOtimo.Location = new Point(807, 363);
            chkOtimo.Name = "chkOtimo";
            chkOtimo.Size = new Size(90, 85);
            chkOtimo.TabIndex = 19;
            chkOtimo.UseVisualStyleBackColor = true;
            chkOtimo.CheckedChanged += chkOtimo_CheckedChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Bottom;
            pictureBox6.Image = Properties.Resources.imgRodape;
            pictureBox6.Location = new Point(0, 547);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1184, 120);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Top;
            pictureBox5.Image = Properties.Resources.imgCabecalho1;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1184, 120);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // lblPergunta
            // 
            lblPergunta.Anchor = AnchorStyles.None;
            lblPergunta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(302, 159);
            lblPergunta.Margin = new Padding(2, 0, 2, 0);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(579, 175);
            lblPergunta.TabIndex = 16;
            lblPergunta.Text = "Perguntas aqui...";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.None;
            btnFinalizar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnFinalizar.Location = new Point(1084, 507);
            btnFinalizar.Margin = new Padding(3, 2, 3, 2);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(88, 36);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.TabStop = false;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Visible = false;
            // 
            // btnVoltarQ
            // 
            btnVoltarQ.Anchor = AnchorStyles.None;
            btnVoltarQ.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnVoltarQ.Location = new Point(10, 502);
            btnVoltarQ.Margin = new Padding(3, 2, 3, 2);
            btnVoltarQ.Name = "btnVoltarQ";
            btnVoltarQ.Size = new Size(88, 36);
            btnVoltarQ.TabIndex = 9;
            btnVoltarQ.TabStop = false;
            btnVoltarQ.Text = "Voltar";
            btnVoltarQ.UseVisualStyleBackColor = true;
            btnVoltarQ.Click += BotaoVoltarObras_Click;
            // 
            // Totem
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1184, 667);
            ControlBox = false;
            Controls.Add(pnlQuestionario);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlObraDescricao);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Totem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Totem";
            WindowState = FormWindowState.Maximized;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlObraDescricao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagemObra).EndInit();
            pnlQuestionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private TextBox txbNome;
        private Label lblDataNascimento;
        private TextBox txbDataNascimento;
        private Button btnIniciar;
        private MonthCalendar mtcCalendario;
        private Panel pnlCadastro;
        private Panel pnlObraDescricao;
        private PictureBox pbxImagemObra;
        private Label lblDescricao;
        private Button btnVoltar;
        private Button btnQuestionario;
        private Panel pnlQuestionario;
        private Button btnFinalizar;
        private Button btnVoltarQ;
        private Button btnAvancarObra;
        private Button btnRetrocederObra;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label lblPergunta;
        private CheckBox chkOtimo;
        private CheckBox chkPessimo;
        private CheckBox chkRuim;
        private CheckBox chkRegular;
        private CheckBox chkBom;
        private Button btnProximaPergunta;
    }
}