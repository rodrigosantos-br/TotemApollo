    algoritmo
        inclua TotemApollo.Controles
        inclua TotemApollo.Modelos

        classe Totem
            privado _teclado: TecladoControle
            privado _cadastro: CadastroControle
            privado _obras: ObrasControle
            privado _questionarioInteracao: QuestionarioInteracaoControle
            privado _questionarioSatisfacao: QuestionarioSatisfacaoControle
            privado _formulario: FormularioControle
            privado _checkboxes: vetor de CheckBox
            privado _buttons: vetor de Button

            metodo novo()
                inicializarComponentes()

                // Inicializa a lista de botões antes de passá-la para o controle QuestionarioInteracaoControle
                _buttons := [btnRespostaA, btnRespostaB, btnRespostaC, btnRespostaD, btnRespostaE]
                _formulario := novo FormularioControle()
                _questionarioInteracao := novo QuestionarioInteracaoControle(_buttons)
                _questionarioSatisfacao := novo QuestionarioSatisfacaoControle()
                _teclado := novo TecladoControle()
                _teclado.TeclaProcessada += Teclado_TeclaProcessada
                _checkboxes := [chkPessimo, chkRuim, chkRegular, chkBom, chkOtimo]
                _questionarioSatisfacao.AssociarCheckBoxes(_checkboxes)

            metodo Teclado_TeclaProcessada(sender, teclaProcessada)
                se teclaProcessada = "Enter" entao
                    btnIniciar.PerformClick()
                senao se teclaProcessada = "K" entao
                    _teclado.AbrirAreaSecreta()
                senao se teclaProcessada = "Backspace" entao
                    _teclado.RemoveUltimoCaractere(txbNome)
                senao
                    txbNome.Text := txbNome.Text + teclaProcessada

            metodo TxbNome_Entrar(sender, e)
                _teclado.AdicionarTeclado(pnlCadastro)

            metodo TxbNome_Sair(sender, e)
                se this.ActiveControl != _teclado entao
                    _teclado.RemoverTeclado(pnlCadastro)

            metodo DataNascimento_DateSelected(sender, e)
                txbDataNascimento.Text := mtcCalendario.SelectionStart.ToShortDateString()
                mtcCalendario.Visible := falso

            metodo TxbDataNascimento_Entrar(sender, e)
                mtcCalendario.Visible := verdadeiro
                _teclado.RemoverTeclado(pnlCadastro)

            metodo TxbDataNascimento_Sair(sender, e)
                se ActiveControl != mtcCalendario entao
                    mtcCalendario.Visible := falso

            metodo BtnIniciar_Clicar(sender, e)
                _cadastro := novo CadastroControle(txbNome.Text, txbDataNascimento.Text)

                se _cadastro.Mensagem = "" entao
                    _obras := novo ObrasControle()
                    pnlCadastro.Visible := falso
                    pnlObraDescricao.Visible := verdadeiro // Torna o painel de descrição visível

                    _obras.ExibirObraAtual(pbxImagemObra, lblDescricao)
                senao
                    MessageBox.Show(_cadastro.Mensagem)
                    retornar

            metodo BtnVoltar_Clicar(sender, e)
                pnlObraDescricao.Visible := falso
                _cadastro.RemoverUltimoVisitante()
                _formulario.LimparControles(Controls)
                pnlCadastro.Show()

            metodo BtnAvancarObra_Clicar(sender, e)
                _obras.AvancarParaProximaObra()
                _obras.ExibirObraAtual(pbxImagemObra, lblDescricao)

            metodo BtnRetrocederObra_Clicar(sender, e)
                _obras.RetrocederParaObraAnterior()
                _obras.ExibirObraAtual(pbxImagemObra, lblDescricao)

            metodo BtnQuestionarioInteracao_Clicar(sender, e)
                pnlObraDescricao.Visible := falso
                btnVoltarQ.Visible := verdadeiro
                pnlQuestionario.Show()
                _questionarioSatisfacao.IncrementarContadorInteracoes()
                _questionarioInteracao.ExibirProximaPergunta(lblPergunta)
                pnlEstrelasSatisfacao.Visible := falso
                pnlOpcoesRespostaInteracoes.Show()
                btnProximaPerguntaInteracao.Visible := verdadeiro
                btnProximaPerguntaSatisfacao.Visible := falso
                pcbBalaoInformacao.BackgroundImage := Properties.Resources.imgBalaoQuiz
                pcbBalaoInformacao.BackgroundImageLayout := ImageLayout.Stretch
                pcbBalaoInformacao.Visible := verdadeiro
                // Define um Timer para ocultar a imagem após 3,8 segundos
                _formulario.IniciarTimer(pcbBalaoInformacao, 3800)

            metodo BotaoVoltarObras_Clicar(sender, e)
                pnlQuestionario.Visible := falso
                pnlObraDescricao.Show()
                _questionarioSatisfacao.DecrementarContadorInteracoes()
                _questionarioInteracao.ExibirPerguntaAnterior(lblPergunta)

            metodo ChkPessimo_Mudar(sender, e)
                _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e)

            metodo ChkRuim_Mudar(sender, e)
                _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e)

            metodo ChkRegular_Mudar(sender, e)
                _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e)

            metodo ChkBom_Mudar(sender, e)
                _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e)

            metodo ChkOtimo_Mudar(sender, e)
                _questionarioSatisfacao.CheckBox_CheckedChanged(sender, e)

            metodo BtnRespostaInteracao_Clicar(sender, e)
                botaoResposta : Button := Button(sender)
                respostaUsuario : string := botaoResposta.Text

                _questionarioInteracao.VerificarResposta(respostaUsuario, botaoResposta)
                lblExplicacaoResposta.Visible := verdadeiro
                _questionarioInteracao.MostrarExplicacaoResposta(lblExplicacaoResposta)
            para cada botao em _buttons faca
                botao.Enabled := falso

        metodo BtnProximaPerguntaInteracao_Clicar(sender, e)
            se !_questionarioInteracao.ValidarRespostas() entao
                MessageBox.Show("Por favor, responda todas as perguntas.")
                retornar

            lblExplicacaoResposta.Visible := falso
            _questionarioInteracao.ExibirProximaPergunta(lblPergunta)

            se _questionarioInteracao.IndicePerguntaAtual = _questionarioInteracao.ObterNumeroPerguntas() entao
                pnlOpcoesRespostaInteracoes.Visible := falso
                btnProximaPerguntaInteracao.Visible := falso
                lblRelatorioAcumuladoQuestionarioInteracao.Text := _questionarioInteracao.ExibirGabarito()
                pnlRelatorioAcumuladoInteracao.Visible := verdadeiro
                para cada botao em _buttons faca
                    botao.Ativar := verdadeiro
            senao
                para cada botao em _buttons faca
                    botao.Ativar := verdadeiro

        metodo BtnAvancarParaQuestionarioSatisfacao_Clicar(sender, e)
            pnlRelatorioAcumuladoInteracao.Visible := falso
            pnlEstrelasSatisfacao.Visible := verdadeiro
            btnProximaPerguntaSatisfacao.Visible := verdadeiro
            pcbBalaoInformacao.BackgroundImage := Properties.Resources.imgBalaoSatisfacao
            pcbBalaoInformacao.Visible := verdadeiro
            btnVoltarQ.Visible := falso
            _formulario.IniciarTimer(pcbBalaoInformacao, 3800)
            _questionarioSatisfacao.MostrarProximaPergunta(lblPergunta, _checkboxes)

        metodo BtnProximaPerguntaSatisfacao_Clicar(sender, e)
            respostas : vetor de inteiro := _questionarioSatisfacao.ObterRespostasDoFormulario(_checkboxes)

            se !_questionarioSatisfacao.ValidarRespostas(respostas) entao
                MessageBox.Show("Por favor, responda todas as perguntas.")
                retornar

            _questionarioSatisfacao.AdicionarRespostasDoFormulario(respostas)

            se _questionarioSatisfacao.IndicePerguntaAtual >= _questionarioSatisfacao.ObterPerguntas().Count entao
                pnlRelatorioAcumuladoSatisfacao.Visible := verdadeiro
                _formulario.IniciarTimer(pnlRelatorioAcumuladoSatisfacao, 10000, () => BtnFinalizar_Click(sender, e))
                btnProximaPerguntaSatisfacao.Visible := falso
                btnVoltarQ.Visible := falso
                relatorio : vetor de string := _questionarioSatisfacao.ObterRelatorioCumulativo()

                lblRelatorioAcumuladoSatisfacao.Text := unir("\n", relatorio)
            senao
                _questionarioSatisfacao.MostrarProximaPergunta(lblPergunta, _checkboxes)

        metodo BtnFinalizar_Click(sender, e)
            pnlQuestionario.Visible := falso
            pnlCadastro.Show()
            _questionarioSatisfacao.IndicePerguntaAtual := 0
            _formulario.LimparControles(Controls)
            btnProximaPerguntaSatisfacao.Visible := verdadeiro

    fim classe

           
