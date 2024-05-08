#### Algoritmo Totem
    usando TotemApollo.Apresentacoes
    usando TotemApollo.Controles
    usando TotemApollo.Modelos

    classe parcial Totem: Formulario
        privado TecladoControle _teclado
        privado CadastroControle _cadastro
        privado ObrasControle _obras
        privado QuestionarioControle _questionario
        privado FormularioControle _formulario

        procedimento Totem()
            inicio
                InicializarComponente()
                _formulario := novo FormularioControle()
                _teclado := novo TecladoControle()
                _teclado.TeclaProcessada += Teclado_TeclaProcessada
                _questionario := novo QuestionarioControle()
            fim_procedimento

        procedimento Teclado_TeclaProcessada(objeto remetente, caractere teclaProcessada)
            inicio
                se (teclaProcessada = "Enter") entao
                    // Clicar no botão "Iniciar"
                    btnIniciar.ExecutarClique()
                senao se (teclaProcessada = "K") entao
                    _teclado.AbrirAreaSecreta()
                senao se (teclaProcessada = "Backspace") entao
                    _teclado.RemoveUltimoCaractere(txbNome)
                senao
                    // Adicionar a tecla processada ao texto
                    txbNome.Texto += teclaProcessada
            fim_procedimento

        procedimento txbNome_Entrar(objeto remetente, EventArgs e)
            inicio
                _teclado.AdicionarTeclado(pnlCadastro)
            fim_procedimento

        procedimento txbNome_Sair(objeto remetente, EventArgs e)
            inicio
                // Verifica se o controle que recebeu o foco não é o teclado virtual
                se (Este.ControleAtivo != _teclado) entao
                    // Oculta o teclado virtual quando o txbNome perder o foco
                    _teclado.RemoverTeclado(pnlCadastro)
            fim_procedimento

        procedimento DataNascimento_DataSelecionada(objeto remetente, DateRangeEventArgs e)
            inicio
                txbDataNascimento.Texto := mtcCalendario.SelecaoInicio.ToShortDateString()
                mtcCalendario.Visível := falso
            fim_procedimento

        procedimento txbDataNascimento_Entrar(objeto remetente, EventArgs e)
            inicio
                mtcCalendario.Visível := verdadeiro
                _teclado.RemoverTeclado(pnlCadastro)
            fim_procedimento

        procedimento txbDataNascimento_Sair(objeto remetente, EventArgs e)
            inicio
                se (ControleAtivo != mtcCalendario) entao
                    mtcCalendario.Visível := falso
            fim_procedimento

        procedimento btnIniciar_Clicar(objeto remetente, EventArgs e)
            inicio
                _cadastro := novo CadastroControle(txbNome.Texto, txbDataNascimento.Texto)

                // Verificar se houve erro na validação do nome ou da data de nascimento
                se (_cadastro.Mensagem = "") entao
                    pnlCadastro.Visível := falso
                    pnlObras.Mostrar()
                senao
                    MessageBox.Mostrar(_cadastro.Mensagem)
                    retornar
            fim_procedimento

        procedimento btnVoltarInicio_Clicar(objeto remetente, EventArgs e)
        
            pnlObras.Visible = false;
            pnlCadastro.Show();
            _formulario.LimparControles(Este.Controles);
            _cadastro.RemoverUltimoVisitante();
        
        procedimento btnObra1_Clicar(objeto remetente, EventArgs e)
            inicio
                _obras := novo ObrasControle()
                pnlObras.Visível := falso
                pnlDescricao.Mostrar()

                // Exibe o histórico da primeira obra
                lblDescricao.Texto := _obras.ExibirHistoricoObra(1)

                pbxDescricaoObra.Imagem := Imagem.CarregarDeArquivo("Imagens\\imgObra1.jpeg")
            fim_procedimento

        procedimento btnObra2_Clicar(objeto remetente, EventArgs e)
            inicio
                _obras := novo ObrasControle()
                pnlObras.Visível := falso
                pnlDescricao.Mostrar()

                // Exibe o histórico da segunda obra
                lblDescricao.Texto := _obras.ExibirHistoricoObra(2)

                pbxDescricaoObra.Imagem := Imagem.CarregarDeArquivo("Imagens\\imgObra2.jpeg")
            fim_procedimento

        procedimento btnObra3_Clicar(objeto remetente, EventArgs e)
            inicio
                _obras := novo ObrasControle()
                pnlObras.Visível := falso
                pnlDescricao.Mostrar()

                // Exibe o histórico da terceira obra
                lblDescricao.Texto := _obras.ExibirHistoricoObra(3)

                pbxDescricaoObra.Imagem := Imagem.CarregarDeArquivo("Imagens\\imgObra3.jpeg")
            fim_procedimento

        procedimento btnObra4_Clicar(objeto remetente, EventArgs e)
            inicio
                _obras := novo ObrasControle()
                pnlObras.Visível := falso
                pnlDescricao.Mostrar()

                // Exibe o histórico da quarta obra
                lblDescricao.Texto := _obras.ExibirHistoricoObra(4)

                pbxDescricaoObra.Imagem := Imagem.CarregarDeArquivo("Imagens\\imgObra4.jpeg")
            fim_procedimento

        procedimento btnVoltar_Clicar(objeto remetente, EventArgs e)
            inicio
                pnlDescricao.Visível := falso
                pnlObras.Mostrar()
            fim_procedimento

        procedimento btnQuestionario_Clicar(objeto remetente, EventArgs e)
            inicio
                pnlDescricao.Visível := falso
                pnlQuestionario.Mostrar()
                _questionario.IncrementarContadorInteracoes()
            fim_procedimento

        // Evento de clique do botão para salvar as respostas e exibir o relatório cumulativo
        procedimento btnSalvar_Clicar(objeto remetente, EventArgs e)
            inicio
                // Obtém as respostas do formulário
                var respostas := _questionario.ObterRespostasDoFormulario(
                    novo vetor de RadioButton { rdbQ1Nota1, rdbQ1Nota2, rdbQ1Nota3, rdbQ1Nota4, rdbQ1Nota5 },
                    novo vetor de RadioButton { rdbQ2Nota1, rdbQ2Nota2, rdbQ2Nota3, rdbQ2Nota4, rdbQ2Nota5 },
                    novo vetor de RadioButton { rdbQ3Nota1, rdbQ3Nota2, rdbQ3Nota3, rdbQ3Nota4, rdbQ3Nota5 },
                    novo vetor de RadioButton { rdbQ4Nota1, rdbQ4Nota2, rdbQ4Nota3, rdbQ4Nota4, rdbQ4Nota5 },
                    novo vetor de RadioButton { rdbQ5Nota1, rdbQ5Nota2, rdbQ5Nota3, rdbQ5Nota4, rdbQ5Nota5 }
                )

                // Verifica se todas as perguntas foram respondidas corretamente
                se (_questionario.ValidarRespostas(respostas)) entao
                    // Adiciona as respostas ao questionário
                    para (inteiro i := 0; i < respostas.Tamanho; i++)
                    inicio
                        _questionario.AdicionarRespostas(i, respostas[i])
                    fim_para

                    // Se todas as perguntas foram respondidas, obtém e exibe o relatório cumulativo
                    var relatorio := _questionario.ObterRelatorioCumulativo()
                    var relatorioFormatado := Texto.Juntar(Env.NewLine, relatorio)
                    MessageBox.Mostrar(relatorioFormatado, "Relatório Cumulativo")

                    // Limpa os controles após o salvamento bem-sucedido
                    _formulario.LimparControles(Este.Controles)

                    pnlQuestionario.Visível := falso
                    pnlCadastro.Mostrar()
                senao
                    // Se nem todas as perguntas foram respondidas corretamente, exibe uma mensagem de erro
                    MessageBox.Mostrar("Por favor, responda todas as perguntas antes de salvar.", "Erro")
            fim_procedimento
    fim_classe
### Fim Algoritmo
