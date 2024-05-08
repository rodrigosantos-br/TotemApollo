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
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblPergunta = new Label();
            btnSalvar = new Button();
            btnVoltarQ = new Button();
            btnProximaPergunta = new Button();
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
            pnlQuestionario.Controls.Add(checkBox5);
            pnlQuestionario.Controls.Add(checkBox4);
            pnlQuestionario.Controls.Add(checkBox3);
            pnlQuestionario.Controls.Add(checkBox2);
            pnlQuestionario.Controls.Add(checkBox1);
            pnlQuestionario.Controls.Add(pictureBox6);
            pnlQuestionario.Controls.Add(pictureBox5);
            pnlQuestionario.Controls.Add(lblPergunta);
            pnlQuestionario.Controls.Add(btnSalvar);
            pnlQuestionario.Controls.Add(btnVoltarQ);
            pnlQuestionario.Dock = DockStyle.Fill;
            pnlQuestionario.Location = new Point(0, 0);
            pnlQuestionario.Name = "pnlQuestionario";
            pnlQuestionario.Size = new Size(1184, 667);
            pnlQuestionario.TabIndex = 12;
            pnlQuestionario.Visible = false;
            // 
            // checkBox5
            // 
            checkBox5.Anchor = AnchorStyles.None;
            checkBox5.Appearance = Appearance.Button;
            checkBox5.BackgroundImageLayout = ImageLayout.Center;
            checkBox5.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox5.FlatAppearance.BorderColor = SystemColors.Control;
            checkBox5.FlatAppearance.CheckedBackColor = SystemColors.Control;
            checkBox5.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            checkBox5.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.Image = Properties.Resources.estrelaPessimo;
            checkBox5.Location = new Point(287, 363);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(90, 85);
            checkBox5.TabIndex = 23;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.Anchor = AnchorStyles.None;
            checkBox4.Appearance = Appearance.Button;
            checkBox4.BackgroundImageLayout = ImageLayout.Center;
            checkBox4.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox4.FlatAppearance.BorderColor = SystemColors.Control;
            checkBox4.FlatAppearance.CheckedBackColor = SystemColors.Control;
            checkBox4.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            checkBox4.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Image = Properties.Resources.estrelaRuim;
            checkBox4.Location = new Point(417, 363);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(90, 85);
            checkBox4.TabIndex = 22;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Anchor = AnchorStyles.None;
            checkBox3.Appearance = Appearance.Button;
            checkBox3.BackgroundImageLayout = ImageLayout.Center;
            checkBox3.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox3.FlatAppearance.BorderColor = SystemColors.Control;
            checkBox3.FlatAppearance.CheckedBackColor = SystemColors.Control;
            checkBox3.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            checkBox3.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Image = Properties.Resources.estrelaRegular;
            checkBox3.Location = new Point(547, 363);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(90, 85);
            checkBox3.TabIndex = 21;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.None;
            checkBox2.Appearance = Appearance.Button;
            checkBox2.BackgroundImageLayout = ImageLayout.Center;
            checkBox2.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox2.FlatAppearance.BorderColor = SystemColors.Control;
            checkBox2.FlatAppearance.CheckedBackColor = SystemColors.Control;
            checkBox2.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            checkBox2.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Image = Properties.Resources.estrelaBom;
            checkBox2.Location = new Point(677, 363);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 85);
            checkBox2.TabIndex = 20;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.Appearance = Appearance.Button;
            checkBox1.BackgroundImageLayout = ImageLayout.Center;
            checkBox1.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox1.FlatAppearance.BorderColor = SystemColors.Control;
            checkBox1.FlatAppearance.CheckedBackColor = SystemColors.Control;
            checkBox1.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            checkBox1.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Image = Properties.Resources.estrelaOtimo;
            checkBox1.Location = new Point(807, 363);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 85);
            checkBox1.TabIndex = 19;
            checkBox1.UseVisualStyleBackColor = true;
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
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.None;
            btnSalvar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSalvar.Location = new Point(1086, 502);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 36);
            btnSalvar.TabIndex = 10;
            btnSalvar.TabStop = false;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BotaoSalvar_Click;
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
            // btnProximaPergunta
            // 
            btnProximaPergunta.Anchor = AnchorStyles.None;
            btnProximaPergunta.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnProximaPergunta.Location = new Point(952, 412);
            btnProximaPergunta.Margin = new Padding(3, 2, 3, 2);
            btnProximaPergunta.Name = "btnProximaPergunta";
            btnProximaPergunta.Size = new Size(88, 36);
            btnProximaPergunta.TabIndex = 24;
            btnProximaPergunta.TabStop = false;
            btnProximaPergunta.Text = "Próxima";
            btnProximaPergunta.UseVisualStyleBackColor = true;
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
        private Button btnSalvar;
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
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Button btnProximaPergunta;
    }
}