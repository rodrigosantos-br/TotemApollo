﻿namespace TotemApollo
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
            pcbRodapeCadastro = new PictureBox();
            pcbLogotipoCadastro = new PictureBox();
            pcbCabecalhoCadastro = new PictureBox();
            pnlObraDescricao = new Panel();
            pcbLogotipoObrasDescricao = new PictureBox();
            btnVoltar = new Button();
            btnQuestionario = new Button();
            lblDescricao = new Label();
            pcbRodapeObraDescricao = new PictureBox();
            pcbCabecalhoObraDescricao = new PictureBox();
            btnAvancarObra = new Button();
            btnRetrocederObra = new Button();
            pbxImagemObra = new PictureBox();
            pnlQuestionario = new Panel();
            pnlRelatorioAcumuladoSatisfacao = new Panel();
            lblAgradecimento = new Label();
            lblRelatorioAcumuladoSatisfacao = new Label();
            pnlRelatorioAcumuladoInteracao = new Panel();
            lblAvisoParaQuestionarioSatisfacao = new Label();
            lblRelatorioAcumuladoQuestionarioInteracao = new Label();
            btnAvancarParaQuestionarioSatisfacao = new Button();
            pcbBalaoInformacao = new PictureBox();
            pnlEstrelasSatisfacao = new Panel();
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
            lblExplicacaoResposta = new Label();
            pcbCabecalhoQuestionario = new PictureBox();
            pcbLogotipoQuestionario = new PictureBox();
            btnProximaPerguntaInteracao = new Button();
            pnlOpcoesRespostaInteracoes = new Panel();
            btnRespostaE = new Button();
            btnRespostaD = new Button();
            btnRespostaC = new Button();
            btnRespostaB = new Button();
            btnRespostaA = new Button();
            btnProximaPerguntaSatisfacao = new Button();
            pcbRodapeQuestionario = new PictureBox();
            btnFinalizar = new Button();
            btnVoltarQ = new Button();
            lblPergunta = new Label();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRodapeCadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipoCadastro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCabecalhoCadastro).BeginInit();
            pnlObraDescricao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipoObrasDescricao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbRodapeObraDescricao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCabecalhoObraDescricao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagemObra).BeginInit();
            pnlQuestionario.SuspendLayout();
            pnlRelatorioAcumuladoSatisfacao.SuspendLayout();
            pnlRelatorioAcumuladoInteracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBalaoInformacao).BeginInit();
            pnlEstrelasSatisfacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCabecalhoQuestionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipoQuestionario).BeginInit();
            pnlOpcoesRespostaInteracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRodapeQuestionario).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(718, 296);
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
            txbNome.Location = new Point(790, 286);
            txbNome.Margin = new Padding(4, 2, 4, 2);
            txbNome.MaxLength = 20;
            txbNome.Name = "txbNome";
            txbNome.PlaceholderText = "Digite seu primeiro nome.";
            txbNome.Size = new Size(349, 38);
            txbNome.TabIndex = 1;
            txbNome.TabStop = false;
            txbNome.Enter += TxbNome_Enter;
            txbNome.Leave += TxbNome_Leave;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.Anchor = AnchorStyles.None;
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataNascimento.Location = new Point(601, 348);
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
            txbDataNascimento.Location = new Point(790, 339);
            txbDataNascimento.Margin = new Padding(4, 2, 4, 2);
            txbDataNascimento.MaxLength = 10;
            txbDataNascimento.Name = "txbDataNascimento";
            txbDataNascimento.PlaceholderText = "Digite sua data de nascimento.";
            txbDataNascimento.Size = new Size(349, 38);
            txbDataNascimento.TabIndex = 2;
            txbDataNascimento.TabStop = false;
            txbDataNascimento.Enter += TxbDataNascimento_Enter;
            txbDataNascimento.Leave += TxbDataNascimento_Leave;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(890, 422);
            btnIniciar.Margin = new Padding(4, 2, 4, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(150, 56);
            btnIniciar.TabIndex = 4;
            btnIniciar.TabStop = false;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += BtnIniciar_Click;
            // 
            // mtcCalendario
            // 
            mtcCalendario.Anchor = AnchorStyles.None;
            mtcCalendario.BackColor = SystemColors.InactiveCaption;
            mtcCalendario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtcCalendario.Location = new Point(1127, 361);
            mtcCalendario.Margin = new Padding(11);
            mtcCalendario.MaxDate = new DateTime(2014, 12, 31, 0, 0, 0, 0);
            mtcCalendario.MinDate = new DateTime(1924, 1, 1, 0, 0, 0, 0);
            mtcCalendario.Name = "mtcCalendario";
            mtcCalendario.ShowTodayCircle = false;
            mtcCalendario.TabIndex = 6;
            mtcCalendario.TabStop = false;
            mtcCalendario.Visible = false;
            mtcCalendario.DateSelected += DataNascimento_DateSelected;
            // 
            // pnlCadastro
            // 
            pnlCadastro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlCadastro.Controls.Add(pcbRodapeCadastro);
            pnlCadastro.Controls.Add(pcbLogotipoCadastro);
            pnlCadastro.Controls.Add(pcbCabecalhoCadastro);
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
            pnlCadastro.Size = new Size(1924, 1009);
            pnlCadastro.TabIndex = 2;
            // 
            // pcbRodapeCadastro
            // 
            pcbRodapeCadastro.Dock = DockStyle.Bottom;
            pcbRodapeCadastro.Image = Properties.Resources.imgRodape;
            pcbRodapeCadastro.Location = new Point(0, 859);
            pcbRodapeCadastro.Margin = new Padding(2);
            pcbRodapeCadastro.Name = "pcbRodapeCadastro";
            pcbRodapeCadastro.Size = new Size(1924, 150);
            pcbRodapeCadastro.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbRodapeCadastro.TabIndex = 8;
            pcbRodapeCadastro.TabStop = false;
            // 
            // pcbLogotipoCadastro
            // 
            pcbLogotipoCadastro.BackColor = Color.Transparent;
            pcbLogotipoCadastro.BackgroundImage = Properties.Resources.Logotipo;
            pcbLogotipoCadastro.Image = Properties.Resources.Logotipo;
            pcbLogotipoCadastro.Location = new Point(75, 188);
            pcbLogotipoCadastro.Margin = new Padding(4);
            pcbLogotipoCadastro.Name = "pcbLogotipoCadastro";
            pcbLogotipoCadastro.Size = new Size(188, 188);
            pcbLogotipoCadastro.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipoCadastro.TabIndex = 37;
            pcbLogotipoCadastro.TabStop = false;
            // 
            // pcbCabecalhoCadastro
            // 
            pcbCabecalhoCadastro.Dock = DockStyle.Top;
            pcbCabecalhoCadastro.Image = Properties.Resources.imgCabecalho1;
            pcbCabecalhoCadastro.Location = new Point(0, 0);
            pcbCabecalhoCadastro.Margin = new Padding(2);
            pcbCabecalhoCadastro.Name = "pcbCabecalhoCadastro";
            pcbCabecalhoCadastro.Size = new Size(1924, 150);
            pcbCabecalhoCadastro.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCabecalhoCadastro.TabIndex = 12;
            pcbCabecalhoCadastro.TabStop = false;
            // 
            // pnlObraDescricao
            // 
            pnlObraDescricao.AccessibleRole = AccessibleRole.ScrollBar;
            pnlObraDescricao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlObraDescricao.Controls.Add(pcbLogotipoObrasDescricao);
            pnlObraDescricao.Controls.Add(btnVoltar);
            pnlObraDescricao.Controls.Add(btnQuestionario);
            pnlObraDescricao.Controls.Add(lblDescricao);
            pnlObraDescricao.Controls.Add(pcbRodapeObraDescricao);
            pnlObraDescricao.Controls.Add(pcbCabecalhoObraDescricao);
            pnlObraDescricao.Controls.Add(btnAvancarObra);
            pnlObraDescricao.Controls.Add(btnRetrocederObra);
            pnlObraDescricao.Controls.Add(pbxImagemObra);
            pnlObraDescricao.Dock = DockStyle.Fill;
            pnlObraDescricao.Location = new Point(0, 0);
            pnlObraDescricao.Margin = new Padding(1);
            pnlObraDescricao.Name = "pnlObraDescricao";
            pnlObraDescricao.Size = new Size(1924, 1009);
            pnlObraDescricao.TabIndex = 5;
            pnlObraDescricao.Visible = false;
            // 
            // pcbLogotipoObrasDescricao
            // 
            pcbLogotipoObrasDescricao.BackColor = Color.Transparent;
            pcbLogotipoObrasDescricao.Image = Properties.Resources.Logotipo;
            pcbLogotipoObrasDescricao.Location = new Point(75, 188);
            pcbLogotipoObrasDescricao.Margin = new Padding(4);
            pcbLogotipoObrasDescricao.Name = "pcbLogotipoObrasDescricao";
            pcbLogotipoObrasDescricao.Size = new Size(188, 188);
            pcbLogotipoObrasDescricao.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipoObrasDescricao.TabIndex = 41;
            pcbLogotipoObrasDescricao.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.AutoSize = true;
            btnVoltar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(333, 770);
            btnVoltar.Margin = new Padding(4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 56);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "< Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += BtnVoltar_Click;
            // 
            // btnQuestionario
            // 
            btnQuestionario.Anchor = AnchorStyles.None;
            btnQuestionario.AutoSize = true;
            btnQuestionario.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuestionario.Location = new Point(1321, 770);
            btnQuestionario.Margin = new Padding(4);
            btnQuestionario.Name = "btnQuestionario";
            btnQuestionario.Size = new Size(232, 56);
            btnQuestionario.TabIndex = 3;
            btnQuestionario.Text = "Iniciar Questionário";
            btnQuestionario.UseVisualStyleBackColor = true;
            btnQuestionario.Click += BtnQuestionarioInteracao_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.None;
            lblDescricao.AutoEllipsis = true;
            lblDescricao.FlatStyle = FlatStyle.Flat;
            lblDescricao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(1514, 188);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(361, 496);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição da obra aqui.";
            // 
            // pcbRodapeObraDescricao
            // 
            pcbRodapeObraDescricao.Dock = DockStyle.Bottom;
            pcbRodapeObraDescricao.Image = Properties.Resources.imgRodape;
            pcbRodapeObraDescricao.Location = new Point(0, 859);
            pcbRodapeObraDescricao.Margin = new Padding(2);
            pcbRodapeObraDescricao.Name = "pcbRodapeObraDescricao";
            pcbRodapeObraDescricao.Size = new Size(1924, 150);
            pcbRodapeObraDescricao.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbRodapeObraDescricao.TabIndex = 9;
            pcbRodapeObraDescricao.TabStop = false;
            // 
            // pcbCabecalhoObraDescricao
            // 
            pcbCabecalhoObraDescricao.Dock = DockStyle.Top;
            pcbCabecalhoObraDescricao.Image = Properties.Resources.imgCabecalho1;
            pcbCabecalhoObraDescricao.Location = new Point(0, 0);
            pcbCabecalhoObraDescricao.Margin = new Padding(2);
            pcbCabecalhoObraDescricao.Name = "pcbCabecalhoObraDescricao";
            pcbCabecalhoObraDescricao.Size = new Size(1924, 150);
            pcbCabecalhoObraDescricao.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCabecalhoObraDescricao.TabIndex = 8;
            pcbCabecalhoObraDescricao.TabStop = false;
            // 
            // btnAvancarObra
            // 
            btnAvancarObra.Anchor = AnchorStyles.None;
            btnAvancarObra.AutoSize = true;
            btnAvancarObra.BackColor = Color.Transparent;
            btnAvancarObra.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvancarObra.Location = new Point(1321, 454);
            btnAvancarObra.Margin = new Padding(4);
            btnAvancarObra.Name = "btnAvancarObra";
            btnAvancarObra.Size = new Size(125, 125);
            btnAvancarObra.TabIndex = 5;
            btnAvancarObra.Text = "▷";
            btnAvancarObra.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAvancarObra.UseVisualStyleBackColor = false;
            btnAvancarObra.Click += BtnAvancarObra_Click;
            // 
            // btnRetrocederObra
            // 
            btnRetrocederObra.Anchor = AnchorStyles.None;
            btnRetrocederObra.AutoSize = true;
            btnRetrocederObra.BackColor = Color.Transparent;
            btnRetrocederObra.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetrocederObra.Location = new Point(321, 454);
            btnRetrocederObra.Margin = new Padding(4);
            btnRetrocederObra.Name = "btnRetrocederObra";
            btnRetrocederObra.Size = new Size(125, 125);
            btnRetrocederObra.TabIndex = 4;
            btnRetrocederObra.Text = "◁";
            btnRetrocederObra.UseVisualStyleBackColor = false;
            btnRetrocederObra.Click += BtnRetrocederObra_Click;
            // 
            // pbxImagemObra
            // 
            pbxImagemObra.Anchor = AnchorStyles.None;
            pbxImagemObra.Location = new Point(453, 174);
            pbxImagemObra.Margin = new Padding(4, 2, 4, 2);
            pbxImagemObra.Name = "pbxImagemObra";
            pbxImagemObra.Size = new Size(859, 660);
            pbxImagemObra.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagemObra.TabIndex = 0;
            pbxImagemObra.TabStop = false;
            // 
            // pnlQuestionario
            // 
            pnlQuestionario.Controls.Add(pnlRelatorioAcumuladoSatisfacao);
            pnlQuestionario.Controls.Add(pnlRelatorioAcumuladoInteracao);
            pnlQuestionario.Controls.Add(pcbBalaoInformacao);
            pnlQuestionario.Controls.Add(pnlEstrelasSatisfacao);
            pnlQuestionario.Controls.Add(lblExplicacaoResposta);
            pnlQuestionario.Controls.Add(pcbCabecalhoQuestionario);
            pnlQuestionario.Controls.Add(pcbLogotipoQuestionario);
            pnlQuestionario.Controls.Add(btnProximaPerguntaInteracao);
            pnlQuestionario.Controls.Add(pnlOpcoesRespostaInteracoes);
            pnlQuestionario.Controls.Add(btnProximaPerguntaSatisfacao);
            pnlQuestionario.Controls.Add(pcbRodapeQuestionario);
            pnlQuestionario.Controls.Add(btnFinalizar);
            pnlQuestionario.Controls.Add(btnVoltarQ);
            pnlQuestionario.Controls.Add(lblPergunta);
            pnlQuestionario.Dock = DockStyle.Fill;
            pnlQuestionario.Location = new Point(0, 0);
            pnlQuestionario.Margin = new Padding(4);
            pnlQuestionario.Name = "pnlQuestionario";
            pnlQuestionario.Size = new Size(1924, 1009);
            pnlQuestionario.TabIndex = 12;
            pnlQuestionario.Visible = false;
            // 
            // pnlRelatorioAcumuladoSatisfacao
            // 
            pnlRelatorioAcumuladoSatisfacao.Controls.Add(lblAgradecimento);
            pnlRelatorioAcumuladoSatisfacao.Controls.Add(lblRelatorioAcumuladoSatisfacao);
            pnlRelatorioAcumuladoSatisfacao.Location = new Point(343, 174);
            pnlRelatorioAcumuladoSatisfacao.Margin = new Padding(4);
            pnlRelatorioAcumuladoSatisfacao.Name = "pnlRelatorioAcumuladoSatisfacao";
            pnlRelatorioAcumuladoSatisfacao.Size = new Size(1797, 664);
            pnlRelatorioAcumuladoSatisfacao.TabIndex = 44;
            pnlRelatorioAcumuladoSatisfacao.Visible = false;
            // 
            // lblAgradecimento
            // 
            lblAgradecimento.AutoSize = true;
            lblAgradecimento.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgradecimento.Location = new Point(91, 579);
            lblAgradecimento.Margin = new Padding(4, 0, 4, 0);
            lblAgradecimento.Name = "lblAgradecimento";
            lblAgradecimento.Size = new Size(917, 41);
            lblAgradecimento.TabIndex = 1;
            lblAgradecimento.Text = "Obrigado pela sua visita! Esperamos vê-lo novamente em breve.";
            // 
            // lblRelatorioAcumuladoSatisfacao
            // 
            lblRelatorioAcumuladoSatisfacao.AutoSize = true;
            lblRelatorioAcumuladoSatisfacao.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRelatorioAcumuladoSatisfacao.Location = new Point(91, 44);
            lblRelatorioAcumuladoSatisfacao.Margin = new Padding(4, 0, 4, 0);
            lblRelatorioAcumuladoSatisfacao.Name = "lblRelatorioAcumuladoSatisfacao";
            lblRelatorioAcumuladoSatisfacao.Size = new Size(186, 32);
            lblRelatorioAcumuladoSatisfacao.TabIndex = 0;
            lblRelatorioAcumuladoSatisfacao.Text = "Relatorio aqui...";
            // 
            // pnlRelatorioAcumuladoInteracao
            // 
            pnlRelatorioAcumuladoInteracao.Anchor = AnchorStyles.None;
            pnlRelatorioAcumuladoInteracao.Controls.Add(lblAvisoParaQuestionarioSatisfacao);
            pnlRelatorioAcumuladoInteracao.Controls.Add(lblRelatorioAcumuladoQuestionarioInteracao);
            pnlRelatorioAcumuladoInteracao.Controls.Add(btnAvancarParaQuestionarioSatisfacao);
            pnlRelatorioAcumuladoInteracao.Location = new Point(343, 174);
            pnlRelatorioAcumuladoInteracao.Margin = new Padding(4);
            pnlRelatorioAcumuladoInteracao.Name = "pnlRelatorioAcumuladoInteracao";
            pnlRelatorioAcumuladoInteracao.Size = new Size(1412, 664);
            pnlRelatorioAcumuladoInteracao.TabIndex = 43;
            pnlRelatorioAcumuladoInteracao.Visible = false;
            // 
            // lblAvisoParaQuestionarioSatisfacao
            // 
            lblAvisoParaQuestionarioSatisfacao.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAvisoParaQuestionarioSatisfacao.Location = new Point(206, 255);
            lblAvisoParaQuestionarioSatisfacao.Margin = new Padding(4, 0, 4, 0);
            lblAvisoParaQuestionarioSatisfacao.Name = "lblAvisoParaQuestionarioSatisfacao";
            lblAvisoParaQuestionarioSatisfacao.Size = new Size(811, 276);
            lblAvisoParaQuestionarioSatisfacao.TabIndex = 2;
            lblAvisoParaQuestionarioSatisfacao.Text = "Estamos sempre buscando formas de melhorar a experiência dos nossos visitantes, e gostaríamos de contar com a sua ajuda. Você irá responder um breve questionário para avaliar o museu.";
            // 
            // lblRelatorioAcumuladoQuestionarioInteracao
            // 
            lblRelatorioAcumuladoQuestionarioInteracao.AutoSize = true;
            lblRelatorioAcumuladoQuestionarioInteracao.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRelatorioAcumuladoQuestionarioInteracao.Location = new Point(206, 51);
            lblRelatorioAcumuladoQuestionarioInteracao.Margin = new Padding(4, 0, 4, 0);
            lblRelatorioAcumuladoQuestionarioInteracao.Name = "lblRelatorioAcumuladoQuestionarioInteracao";
            lblRelatorioAcumuladoQuestionarioInteracao.Size = new Size(287, 50);
            lblRelatorioAcumuladoQuestionarioInteracao.TabIndex = 1;
            lblRelatorioAcumuladoQuestionarioInteracao.Text = "Relatorio aqui...";
            // 
            // btnAvancarParaQuestionarioSatisfacao
            // 
            btnAvancarParaQuestionarioSatisfacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvancarParaQuestionarioSatisfacao.Location = new Point(911, 583);
            btnAvancarParaQuestionarioSatisfacao.Margin = new Padding(4);
            btnAvancarParaQuestionarioSatisfacao.Name = "btnAvancarParaQuestionarioSatisfacao";
            btnAvancarParaQuestionarioSatisfacao.Size = new Size(106, 56);
            btnAvancarParaQuestionarioSatisfacao.TabIndex = 0;
            btnAvancarParaQuestionarioSatisfacao.Text = "Avancar";
            btnAvancarParaQuestionarioSatisfacao.UseVisualStyleBackColor = true;
            btnAvancarParaQuestionarioSatisfacao.Click += BtnAvancarParaQuestionarioSatisfacao_Click;
            // 
            // pcbBalaoInformacao
            // 
            pcbBalaoInformacao.Anchor = AnchorStyles.None;
            pcbBalaoInformacao.Location = new Point(1394, 178);
            pcbBalaoInformacao.Margin = new Padding(4);
            pcbBalaoInformacao.Name = "pcbBalaoInformacao";
            pcbBalaoInformacao.Size = new Size(361, 269);
            pcbBalaoInformacao.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBalaoInformacao.TabIndex = 41;
            pcbBalaoInformacao.TabStop = false;
            // 
            // pnlEstrelasSatisfacao
            // 
            pnlEstrelasSatisfacao.Anchor = AnchorStyles.None;
            pnlEstrelasSatisfacao.Controls.Add(chkPessimo);
            pnlEstrelasSatisfacao.Controls.Add(chkOtimo);
            pnlEstrelasSatisfacao.Controls.Add(lblOtimo);
            pnlEstrelasSatisfacao.Controls.Add(chkBom);
            pnlEstrelasSatisfacao.Controls.Add(lblBom);
            pnlEstrelasSatisfacao.Controls.Add(chkRegular);
            pnlEstrelasSatisfacao.Controls.Add(lblRegular);
            pnlEstrelasSatisfacao.Controls.Add(chkRuim);
            pnlEstrelasSatisfacao.Controls.Add(lblRuim);
            pnlEstrelasSatisfacao.Controls.Add(lblPessimo);
            pnlEstrelasSatisfacao.Location = new Point(550, 408);
            pnlEstrelasSatisfacao.Margin = new Padding(4);
            pnlEstrelasSatisfacao.Name = "pnlEstrelasSatisfacao";
            pnlEstrelasSatisfacao.Size = new Size(838, 162);
            pnlEstrelasSatisfacao.TabIndex = 30;
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
            chkPessimo.Location = new Point(9, 4);
            chkPessimo.Margin = new Padding(4);
            chkPessimo.Name = "chkPessimo";
            chkPessimo.Size = new Size(125, 125);
            chkPessimo.TabIndex = 23;
            chkPessimo.Tag = "estrelaPessimo";
            chkPessimo.UseVisualStyleBackColor = true;
            chkPessimo.CheckedChanged += ChkPessimo_CheckedChanged;
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
            chkOtimo.Location = new Point(705, 4);
            chkOtimo.Margin = new Padding(4);
            chkOtimo.Name = "chkOtimo";
            chkOtimo.Size = new Size(125, 125);
            chkOtimo.TabIndex = 19;
            chkOtimo.Tag = "estrelaOtimo";
            chkOtimo.UseVisualStyleBackColor = true;
            chkOtimo.CheckedChanged += ChkOtimo_CheckedChanged;
            // 
            // lblOtimo
            // 
            lblOtimo.Anchor = AnchorStyles.None;
            lblOtimo.AutoSize = true;
            lblOtimo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblOtimo.Location = new Point(732, 132);
            lblOtimo.Margin = new Padding(2, 0, 2, 0);
            lblOtimo.Name = "lblOtimo";
            lblOtimo.Size = new Size(69, 28);
            lblOtimo.TabIndex = 29;
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
            chkBom.Location = new Point(539, 4);
            chkBom.Margin = new Padding(4);
            chkBom.Name = "chkBom";
            chkBom.Size = new Size(125, 125);
            chkBom.TabIndex = 20;
            chkBom.Tag = "estrelaBom";
            chkBom.UseVisualStyleBackColor = true;
            chkBom.CheckedChanged += ChkBom_CheckedChanged;
            // 
            // lblBom
            // 
            lblBom.Anchor = AnchorStyles.None;
            lblBom.AutoSize = true;
            lblBom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBom.Location = new Point(574, 132);
            lblBom.Margin = new Padding(2, 0, 2, 0);
            lblBom.Name = "lblBom";
            lblBom.Size = new Size(54, 28);
            lblBom.TabIndex = 28;
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
            chkRegular.Location = new Point(361, 4);
            chkRegular.Margin = new Padding(4);
            chkRegular.Name = "chkRegular";
            chkRegular.Size = new Size(125, 125);
            chkRegular.TabIndex = 21;
            chkRegular.Tag = "estrelaRegular";
            chkRegular.UseVisualStyleBackColor = true;
            chkRegular.CheckedChanged += ChkRegular_CheckedChanged;
            // 
            // lblRegular
            // 
            lblRegular.Anchor = AnchorStyles.None;
            lblRegular.AutoSize = true;
            lblRegular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRegular.Location = new Point(382, 132);
            lblRegular.Margin = new Padding(2, 0, 2, 0);
            lblRegular.Name = "lblRegular";
            lblRegular.Size = new Size(80, 28);
            lblRegular.TabIndex = 27;
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
            chkRuim.Location = new Point(182, 4);
            chkRuim.Margin = new Padding(4);
            chkRuim.Name = "chkRuim";
            chkRuim.Size = new Size(125, 125);
            chkRuim.TabIndex = 22;
            chkRuim.Tag = "estrelaRuim";
            chkRuim.UseVisualStyleBackColor = true;
            chkRuim.CheckedChanged += ChkRuim_CheckedChanged;
            // 
            // lblRuim
            // 
            lblRuim.Anchor = AnchorStyles.None;
            lblRuim.AutoSize = true;
            lblRuim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRuim.Location = new Point(216, 132);
            lblRuim.Margin = new Padding(2, 0, 2, 0);
            lblRuim.Name = "lblRuim";
            lblRuim.Size = new Size(59, 28);
            lblRuim.TabIndex = 26;
            lblRuim.Text = "Ruim";
            // 
            // lblPessimo
            // 
            lblPessimo.Anchor = AnchorStyles.None;
            lblPessimo.AutoSize = true;
            lblPessimo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPessimo.Location = new Point(29, 132);
            lblPessimo.Margin = new Padding(2, 0, 2, 0);
            lblPessimo.Name = "lblPessimo";
            lblPessimo.Size = new Size(87, 28);
            lblPessimo.TabIndex = 25;
            lblPessimo.Text = "Péssimo";
            // 
            // lblExplicacaoResposta
            // 
            lblExplicacaoResposta.Anchor = AnchorStyles.None;
            lblExplicacaoResposta.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblExplicacaoResposta.ForeColor = Color.Green;
            lblExplicacaoResposta.Location = new Point(701, 744);
            lblExplicacaoResposta.Margin = new Padding(4, 0, 4, 0);
            lblExplicacaoResposta.Name = "lblExplicacaoResposta";
            lblExplicacaoResposta.Size = new Size(539, 94);
            lblExplicacaoResposta.TabIndex = 42;
            // 
            // pcbCabecalhoQuestionario
            // 
            pcbCabecalhoQuestionario.Dock = DockStyle.Top;
            pcbCabecalhoQuestionario.Image = Properties.Resources.imgCabecalho1;
            pcbCabecalhoQuestionario.Location = new Point(0, 0);
            pcbCabecalhoQuestionario.Margin = new Padding(2);
            pcbCabecalhoQuestionario.Name = "pcbCabecalhoQuestionario";
            pcbCabecalhoQuestionario.Size = new Size(1924, 150);
            pcbCabecalhoQuestionario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCabecalhoQuestionario.TabIndex = 17;
            pcbCabecalhoQuestionario.TabStop = false;
            // 
            // pcbLogotipoQuestionario
            // 
            pcbLogotipoQuestionario.BackColor = Color.Transparent;
            pcbLogotipoQuestionario.Image = Properties.Resources.Logotipo;
            pcbLogotipoQuestionario.Location = new Point(75, 188);
            pcbLogotipoQuestionario.Margin = new Padding(4);
            pcbLogotipoQuestionario.Name = "pcbLogotipoQuestionario";
            pcbLogotipoQuestionario.Size = new Size(188, 188);
            pcbLogotipoQuestionario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogotipoQuestionario.TabIndex = 33;
            pcbLogotipoQuestionario.TabStop = false;
            // 
            // btnProximaPerguntaInteracao
            // 
            btnProximaPerguntaInteracao.Anchor = AnchorStyles.None;
            btnProximaPerguntaInteracao.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnProximaPerguntaInteracao.Location = new Point(1274, 740);
            btnProximaPerguntaInteracao.Margin = new Padding(4, 2, 4, 2);
            btnProximaPerguntaInteracao.Name = "btnProximaPerguntaInteracao";
            btnProximaPerguntaInteracao.Size = new Size(112, 56);
            btnProximaPerguntaInteracao.TabIndex = 32;
            btnProximaPerguntaInteracao.TabStop = false;
            btnProximaPerguntaInteracao.Text = "Próxima";
            btnProximaPerguntaInteracao.UseVisualStyleBackColor = true;
            btnProximaPerguntaInteracao.Click += BtnProximaPerguntaInteracao_Click;
            // 
            // pnlOpcoesRespostaInteracoes
            // 
            pnlOpcoesRespostaInteracoes.Anchor = AnchorStyles.None;
            pnlOpcoesRespostaInteracoes.Controls.Add(btnRespostaE);
            pnlOpcoesRespostaInteracoes.Controls.Add(btnRespostaD);
            pnlOpcoesRespostaInteracoes.Controls.Add(btnRespostaC);
            pnlOpcoesRespostaInteracoes.Controls.Add(btnRespostaB);
            pnlOpcoesRespostaInteracoes.Controls.Add(btnRespostaA);
            pnlOpcoesRespostaInteracoes.Location = new Point(550, 570);
            pnlOpcoesRespostaInteracoes.Margin = new Padding(4);
            pnlOpcoesRespostaInteracoes.Name = "pnlOpcoesRespostaInteracoes";
            pnlOpcoesRespostaInteracoes.Size = new Size(838, 162);
            pnlOpcoesRespostaInteracoes.TabIndex = 31;
            pnlOpcoesRespostaInteracoes.Visible = false;
            // 
            // btnRespostaE
            // 
            btnRespostaE.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnRespostaE.Location = new Point(688, 35);
            btnRespostaE.Margin = new Padding(4);
            btnRespostaE.Name = "btnRespostaE";
            btnRespostaE.Size = new Size(94, 94);
            btnRespostaE.TabIndex = 4;
            btnRespostaE.Text = "E";
            btnRespostaE.UseVisualStyleBackColor = true;
            btnRespostaE.Click += BtnRespostaInteracao_Click;
            // 
            // btnRespostaD
            // 
            btnRespostaD.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnRespostaD.Location = new Point(530, 35);
            btnRespostaD.Margin = new Padding(4);
            btnRespostaD.Name = "btnRespostaD";
            btnRespostaD.Size = new Size(94, 94);
            btnRespostaD.TabIndex = 3;
            btnRespostaD.Text = "D";
            btnRespostaD.UseVisualStyleBackColor = true;
            btnRespostaD.Click += BtnRespostaInteracao_Click;
            // 
            // btnRespostaC
            // 
            btnRespostaC.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnRespostaC.Location = new Point(372, 35);
            btnRespostaC.Margin = new Padding(4);
            btnRespostaC.Name = "btnRespostaC";
            btnRespostaC.Size = new Size(94, 94);
            btnRespostaC.TabIndex = 2;
            btnRespostaC.Text = "C";
            btnRespostaC.UseVisualStyleBackColor = true;
            btnRespostaC.Click += BtnRespostaInteracao_Click;
            // 
            // btnRespostaB
            // 
            btnRespostaB.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnRespostaB.Location = new Point(215, 35);
            btnRespostaB.Margin = new Padding(4);
            btnRespostaB.Name = "btnRespostaB";
            btnRespostaB.Size = new Size(94, 94);
            btnRespostaB.TabIndex = 1;
            btnRespostaB.Text = "B";
            btnRespostaB.UseVisualStyleBackColor = true;
            btnRespostaB.Click += BtnRespostaInteracao_Click;
            // 
            // btnRespostaA
            // 
            btnRespostaA.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold);
            btnRespostaA.Location = new Point(58, 35);
            btnRespostaA.Margin = new Padding(4);
            btnRespostaA.Name = "btnRespostaA";
            btnRespostaA.Size = new Size(94, 94);
            btnRespostaA.TabIndex = 0;
            btnRespostaA.Text = "A";
            btnRespostaA.UseVisualStyleBackColor = true;
            btnRespostaA.Click += BtnRespostaInteracao_Click;
            // 
            // btnProximaPerguntaSatisfacao
            // 
            btnProximaPerguntaSatisfacao.Anchor = AnchorStyles.None;
            btnProximaPerguntaSatisfacao.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnProximaPerguntaSatisfacao.Location = new Point(1274, 740);
            btnProximaPerguntaSatisfacao.Margin = new Padding(4, 2, 4, 2);
            btnProximaPerguntaSatisfacao.Name = "btnProximaPerguntaSatisfacao";
            btnProximaPerguntaSatisfacao.Size = new Size(112, 56);
            btnProximaPerguntaSatisfacao.TabIndex = 24;
            btnProximaPerguntaSatisfacao.TabStop = false;
            btnProximaPerguntaSatisfacao.Text = "Próxima";
            btnProximaPerguntaSatisfacao.UseVisualStyleBackColor = true;
            btnProximaPerguntaSatisfacao.Visible = false;
            btnProximaPerguntaSatisfacao.Click += BtnProximaPerguntaSatisfacao_Click;
            // 
            // pcbRodapeQuestionario
            // 
            pcbRodapeQuestionario.Dock = DockStyle.Bottom;
            pcbRodapeQuestionario.Image = Properties.Resources.imgRodape;
            pcbRodapeQuestionario.Location = new Point(0, 859);
            pcbRodapeQuestionario.Margin = new Padding(2);
            pcbRodapeQuestionario.Name = "pcbRodapeQuestionario";
            pcbRodapeQuestionario.Size = new Size(1924, 150);
            pcbRodapeQuestionario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbRodapeQuestionario.TabIndex = 18;
            pcbRodapeQuestionario.TabStop = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.None;
            btnFinalizar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnFinalizar.Location = new Point(1394, 740);
            btnFinalizar.Margin = new Padding(4, 2, 4, 2);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(112, 56);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.TabStop = false;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Visible = false;
            btnFinalizar.Click += BtnFinalizar_Click;
            // 
            // btnVoltarQ
            // 
            btnVoltarQ.Anchor = AnchorStyles.None;
            btnVoltarQ.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            btnVoltarQ.Location = new Point(550, 738);
            btnVoltarQ.Margin = new Padding(4, 2, 4, 2);
            btnVoltarQ.Name = "btnVoltarQ";
            btnVoltarQ.Size = new Size(112, 56);
            btnVoltarQ.TabIndex = 9;
            btnVoltarQ.TabStop = false;
            btnVoltarQ.Text = "Voltar";
            btnVoltarQ.UseVisualStyleBackColor = true;
            btnVoltarQ.Click += BotaoVoltarObras_Click;
            // 
            // lblPergunta
            // 
            lblPergunta.Anchor = AnchorStyles.None;
            lblPergunta.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(601, 211);
            lblPergunta.Margin = new Padding(2, 0, 2, 0);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(724, 360);
            lblPergunta.TabIndex = 16;
            lblPergunta.Text = "Perguntas aqui...";
            // 
            // Totem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1924, 1009);
            Controls.Add(pnlQuestionario);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlObraDescricao);
            Margin = new Padding(4);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Totem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Totem";
            WindowState = FormWindowState.Maximized;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbRodapeCadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipoCadastro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCabecalhoCadastro).EndInit();
            pnlObraDescricao.ResumeLayout(false);
            pnlObraDescricao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipoObrasDescricao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbRodapeObraDescricao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCabecalhoObraDescricao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxImagemObra).EndInit();
            pnlQuestionario.ResumeLayout(false);
            pnlRelatorioAcumuladoSatisfacao.ResumeLayout(false);
            pnlRelatorioAcumuladoSatisfacao.PerformLayout();
            pnlRelatorioAcumuladoInteracao.ResumeLayout(false);
            pnlRelatorioAcumuladoInteracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbBalaoInformacao).EndInit();
            pnlEstrelasSatisfacao.ResumeLayout(false);
            pnlEstrelasSatisfacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbCabecalhoQuestionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogotipoQuestionario).EndInit();
            pnlOpcoesRespostaInteracoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbRodapeQuestionario).EndInit();
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
        private PictureBox pcbRodapeQuestionario;
        private PictureBox pcbCabecalhoQuestionario;
        private Label lblPergunta;
        private CheckBox chkOtimo;
        private CheckBox chkPessimo;
        private CheckBox chkRuim;
        private CheckBox chkRegular;
        private CheckBox chkBom;
        private Label lblOtimo;
        private Label lblBom;
        private Label lblRegular;
        private Label lblRuim;
        private Label lblPessimo;
        private PictureBox pcbRodapeObraDescricao;
        private PictureBox pcbCabecalhoObraDescricao;
        private PictureBox pcbRodapeCadastro;
        private PictureBox pcbCabecalhoCadastro;
        private Panel pnlOpcoesRespostaInteracoes;
        private Button btnRespostaA;
        private Panel pnlEstrelasSatisfacao;
        private Button btnRespostaE;
        private Button btnRespostaD;
        private Button btnRespostaC;
        private Button btnRespostaB;
        private Button btnProximaPerguntaSatisfacao;
        private Button btnProximaPerguntaInteracao;
        private PictureBox pcbLogotipoCadastro;
        private PictureBox pcbLogotipoQuestionario;
        private PictureBox pcbLogotipoObrasDescricao;
        private PictureBox pcbBalaoInformacao;
        private Label lblExplicacaoResposta;
        private Panel pnlRelatorioAcumuladoInteracao;
        private Label lblAvisoParaQuestionarioSatisfacao;
        private Label lblRelatorioAcumuladoQuestionarioInteracao;
        private Button btnAvancarParaQuestionarioSatisfacao;
        private Panel pnlRelatorioAcumuladoSatisfacao;
        private Label lblRelatorioAcumuladoSatisfacao;
        private Label lblAgradecimento;
    }
}