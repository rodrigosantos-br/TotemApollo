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
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblPergunta = new Label();
            btnMuitoSatisfeito = new Button();
            btnSatisfeito = new Button();
            btnNeutro = new Button();
            btnInsatisfeito = new Button();
            btnMuitoInsatisfeito = new Button();
            btnSalvar = new Button();
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
            lblNome.Location = new Point(497, 199);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.AcceptsTab = true;
            txbNome.Anchor = AnchorStyles.None;
            txbNome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNome.ImeMode = ImeMode.On;
            txbNome.Location = new Point(568, 189);
            txbNome.Margin = new Padding(4, 2, 4, 2);
            txbNome.MaxLength = 20;
            txbNome.Name = "txbNome";
            txbNome.PlaceholderText = "Digite seu primeiro nome.";
            txbNome.Size = new Size(345, 38);
            txbNome.TabIndex = 1;
            txbNome.Enter += TextBoxNome_Enter;
            txbNome.Leave += TextBoxNome_Leave;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.None;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataNascimento.Location = new Point(380, 250);
            lblDataNascimento.Margin = new Padding(4, 0, 4, 0);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(180, 25);
            lblDataNascimento.TabIndex = 2;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txbDataNascimento
            // 
            txbDataNascimento.Anchor = AnchorStyles.None;
            txbDataNascimento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDataNascimento.Location = new Point(568, 242);
            txbDataNascimento.Margin = new Padding(4, 2, 4, 2);
            txbDataNascimento.MaxLength = 10;
            txbDataNascimento.Name = "txbDataNascimento";
            txbDataNascimento.PlaceholderText = "Digite sua data de nascimento.";
            txbDataNascimento.Size = new Size(345, 38);
            txbDataNascimento.TabIndex = 2;
            txbDataNascimento.Enter += TextBoxDataNascimento_Enter;
            txbDataNascimento.Leave += TextBoxDataNascimento_Leave;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(665, 351);
            btnIniciar.Margin = new Padding(4, 2, 4, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(150, 45);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += BotaoIniciar_Click;
            // 
            // mtcCalendario
            // 
            mtcCalendario.Anchor = AnchorStyles.None;
            mtcCalendario.Location = new Point(894, 268);
            mtcCalendario.Margin = new Padding(11);
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
            pnlCadastro.Margin = new Padding(4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(1480, 834);
            pnlCadastro.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Bottom;
            pictureBox4.Image = Properties.Resources.imgRodape;
            pictureBox4.Location = new Point(0, 684);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1480, 150);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = Properties.Resources.imgCabecalho1;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1480, 150);
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
            pnlObraDescricao.Size = new Size(1480, 834);
            pnlObraDescricao.TabIndex = 5;
            pnlObraDescricao.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.None;
            lblDescricao.AutoEllipsis = true;
            lblDescricao.FlatStyle = FlatStyle.Flat;
            lblDescricao.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(731, 199);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(604, 411);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição da obra aqui.";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.imgRodape;
            pictureBox2.Location = new Point(0, 684);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1480, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.imgCabecalho1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1480, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnAvancarObra
            // 
            btnAvancarObra.Anchor = AnchorStyles.None;
            btnAvancarObra.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvancarObra.Location = new Point(627, 385);
            btnAvancarObra.Margin = new Padding(4);
            btnAvancarObra.Name = "btnAvancarObra";
            btnAvancarObra.Size = new Size(62, 62);
            btnAvancarObra.TabIndex = 5;
            btnAvancarObra.Text = ">";
            btnAvancarObra.UseVisualStyleBackColor = true;
            btnAvancarObra.Click += btnAvancarObra_Click;
            // 
            // btnRetrocederObra
            // 
            btnRetrocederObra.Anchor = AnchorStyles.None;
            btnRetrocederObra.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetrocederObra.Location = new Point(121, 385);
            btnRetrocederObra.Margin = new Padding(4);
            btnRetrocederObra.Name = "btnRetrocederObra";
            btnRetrocederObra.Size = new Size(62, 62);
            btnRetrocederObra.TabIndex = 4;
            btnRetrocederObra.Text = "<";
            btnRetrocederObra.UseVisualStyleBackColor = true;
            btnRetrocederObra.Click += btnRetrocederObra_Click;
            // 
            // pbxImagemObra
            // 
            pbxImagemObra.Anchor = AnchorStyles.None;
            pbxImagemObra.Location = new Point(191, 155);
            pbxImagemObra.Margin = new Padding(4, 2, 4, 2);
            pbxImagemObra.Name = "pbxImagemObra";
            pbxImagemObra.Size = new Size(428, 524);
            pbxImagemObra.SizeMode = PictureBoxSizeMode.Zoom;
            pbxImagemObra.TabIndex = 0;
            pbxImagemObra.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(13, 628);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(110, 45);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "< Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnQuestionario
            // 
            btnQuestionario.Anchor = AnchorStyles.None;
            btnQuestionario.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuestionario.Location = new Point(1267, 628);
            btnQuestionario.Margin = new Padding(4);
            btnQuestionario.Name = "btnQuestionario";
            btnQuestionario.Size = new Size(200, 45);
            btnQuestionario.TabIndex = 3;
            btnQuestionario.Text = "Iniciar Questionário";
            btnQuestionario.UseVisualStyleBackColor = true;
            btnQuestionario.Click += BotaoQuestionario_Click;
            // 
            // pnlQuestionario
            // 
            pnlQuestionario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlQuestionario.Controls.Add(pictureBox6);
            pnlQuestionario.Controls.Add(pictureBox5);
            pnlQuestionario.Controls.Add(lblPergunta);
            pnlQuestionario.Controls.Add(btnMuitoSatisfeito);
            pnlQuestionario.Controls.Add(btnSatisfeito);
            pnlQuestionario.Controls.Add(btnNeutro);
            pnlQuestionario.Controls.Add(btnInsatisfeito);
            pnlQuestionario.Controls.Add(btnMuitoInsatisfeito);
            pnlQuestionario.Controls.Add(btnSalvar);
            pnlQuestionario.Controls.Add(btnVoltarQ);
            pnlQuestionario.Dock = DockStyle.Fill;
            pnlQuestionario.Location = new Point(0, 0);
            pnlQuestionario.Margin = new Padding(4);
            pnlQuestionario.Name = "pnlQuestionario";
            pnlQuestionario.Size = new Size(1480, 834);
            pnlQuestionario.TabIndex = 12;
            pnlQuestionario.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Bottom;
            pictureBox6.Image = Properties.Resources.imgRodape;
            pictureBox6.Location = new Point(0, 684);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1480, 150);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Top;
            pictureBox5.Image = Properties.Resources.imgCabecalho1;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1480, 150);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // lblPergunta
            // 
            lblPergunta.Anchor = AnchorStyles.None;
            lblPergunta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(378, 199);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(724, 219);
            lblPergunta.TabIndex = 16;
            lblPergunta.Text = "Perguntas aqui...";
            // 
            // btnMuitoSatisfeito
            // 
            btnMuitoSatisfeito.Anchor = AnchorStyles.None;
            btnMuitoSatisfeito.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnMuitoSatisfeito.Location = new Point(1107, 473);
            btnMuitoSatisfeito.Name = "btnMuitoSatisfeito";
            btnMuitoSatisfeito.Size = new Size(170, 45);
            btnMuitoSatisfeito.TabIndex = 15;
            btnMuitoSatisfeito.TabStop = false;
            btnMuitoSatisfeito.Text = "Muito Satisfeito";
            btnMuitoSatisfeito.UseVisualStyleBackColor = true;
            // 
            // btnSatisfeito
            // 
            btnSatisfeito.Anchor = AnchorStyles.None;
            btnSatisfeito.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSatisfeito.Location = new Point(881, 473);
            btnSatisfeito.Name = "btnSatisfeito";
            btnSatisfeito.Size = new Size(170, 45);
            btnSatisfeito.TabIndex = 14;
            btnSatisfeito.TabStop = false;
            btnSatisfeito.Text = "Satisfeito";
            btnSatisfeito.UseVisualStyleBackColor = true;
            // 
            // btnNeutro
            // 
            btnNeutro.Anchor = AnchorStyles.None;
            btnNeutro.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnNeutro.Location = new Point(655, 473);
            btnNeutro.Name = "btnNeutro";
            btnNeutro.Size = new Size(170, 45);
            btnNeutro.TabIndex = 13;
            btnNeutro.TabStop = false;
            btnNeutro.Text = "Neutro";
            btnNeutro.UseVisualStyleBackColor = true;
            // 
            // btnInsatisfeito
            // 
            btnInsatisfeito.Anchor = AnchorStyles.None;
            btnInsatisfeito.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnInsatisfeito.Location = new Point(429, 473);
            btnInsatisfeito.Name = "btnInsatisfeito";
            btnInsatisfeito.Size = new Size(170, 45);
            btnInsatisfeito.TabIndex = 12;
            btnInsatisfeito.TabStop = false;
            btnInsatisfeito.Text = "Insatisfeito";
            btnInsatisfeito.UseVisualStyleBackColor = true;
            // 
            // btnMuitoInsatisfeito
            // 
            btnMuitoInsatisfeito.Anchor = AnchorStyles.None;
            btnMuitoInsatisfeito.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnMuitoInsatisfeito.Location = new Point(203, 473);
            btnMuitoInsatisfeito.Name = "btnMuitoInsatisfeito";
            btnMuitoInsatisfeito.Size = new Size(170, 45);
            btnMuitoInsatisfeito.TabIndex = 11;
            btnMuitoInsatisfeito.TabStop = false;
            btnMuitoInsatisfeito.Text = "Muito Insatisfeito";
            btnMuitoInsatisfeito.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.None;
            btnSalvar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnSalvar.Location = new Point(1357, 628);
            btnSalvar.Margin = new Padding(4, 2, 4, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 45);
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
            btnVoltarQ.Location = new Point(13, 628);
            btnVoltarQ.Margin = new Padding(4, 2, 4, 2);
            btnVoltarQ.Name = "btnVoltarQ";
            btnVoltarQ.Size = new Size(110, 45);
            btnVoltarQ.TabIndex = 9;
            btnVoltarQ.TabStop = false;
            btnVoltarQ.Text = "Voltar";
            btnVoltarQ.UseVisualStyleBackColor = true;
            btnVoltarQ.Click += BotaoVoltarObras_Click;
            // 
            // Totem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1480, 834);
            ControlBox = false;
            Controls.Add(pnlObraDescricao);
            Controls.Add(pnlQuestionario);
            Controls.Add(pnlCadastro);
            Margin = new Padding(4);
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
        private Button btnMuitoSatisfeito;
        private Button btnSatisfeito;
        private Button btnNeutro;
        private Button btnInsatisfeito;
        private Button btnMuitoInsatisfeito;
    }
}