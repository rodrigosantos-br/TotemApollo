    classe QuestionarioInteracaoControle
        privado questionarioInteracao: QuestionarioInteracao
        privado validacao: QuestionarioValidacao
        privado indicePerguntaAtual: inteiro
        privado botoesResposta: vetor de Button
        privado acumuladoRespostas: dicionario de string para inteiro

        metodo novo(botoesResposta: vetor de Button)
            questionarioInteracao := novo QuestionarioInteracao()
            validacao := novo QuestionarioValidacao()
            indicePerguntaAtual := 0
            this.botoesResposta := botoesResposta
            acumuladoRespostas := novo dicionario de string para inteiro()

        metodo ObterNumeroPerguntas() retorna questionarioInteracao.ObterNumeroPerguntas()

        metodo ValidarRespostas() retorna validacao.ValidarRespostas(botoesResposta)

        metodo MostrarExplicacaoResposta(labelExplicacao: Label)
            indicePerguntaAtual := this.indicePerguntaAtual - 1 
            explicacao := questionarioInteracao.ObterExplicacaoRespostaCorreta(indicePerguntaAtual).ToString()
            labelExplicacao.Texto := explicacao

        metodo ExibirPerguntaAnterior(lblPergunta: Label)
            indicePerguntaAtual := indicePerguntaAtual - 1

            se indicePerguntaAtual >= 0 entao
                lblPergunta.Texto := questionarioInteracao.ObterPergunta(indicePerguntaAtual)

                para cada i, botao em botoesResposta faca
                    botao.Texto := questionarioInteracao.ObterRespostaPorIndice(indicePerguntaAtual, i)
                    botao.CorFundo := Cores.SystemColors.Control 
            senao
                indicePerguntaAtual := 0

        metodo ExibirProximaPergunta(lblPergunta: Label)
            se indicePerguntaAtual < questionarioInteracao.ObterNumeroPerguntas() entao
                lblPergunta.Texto := questionarioInteracao.ObterPergunta(indicePerguntaAtual)

                para cada i, botao em botoesResposta faca
                    botao.Texto := questionarioInteracao.ObterRespostaPorIndice(indicePerguntaAtual, i)
                    botao.CorFundo := Cores.SystemColors.Control 
                indicePerguntaAtual := indicePerguntaAtual + 1
            senao
                indicePerguntaAtual := 0
                VerificarResposta("", nulo) // Isso está causando o problema
                ExibirProximaPergunta(lblPergunta) // Chame ExibirProximaPergunta recursivamente

        metodo VerificarResposta(respostaUsuario: string, botaoResposta: Button)
            respostaCorreta := questionarioInteracao.VerificarResposta(indicePerguntaAtual - 1, respostaUsuario)

            para cada i, botao em botoesResposta faca
                se botao.Texto.Maiusculo() == respostaUsuario.Maiusculo() entao
                    se respostaCorreta entao
                        botao.CorFundo := Cores.Verde
                    senao
                        botao.CorFundo := Cores.Vermelho
                senao
                    botao.CorFundo := Cores.SystemColors.Control

        metodo ExibirGabarito() retorna questionarioInteracao.ExibirGabarito()

        propriedade IndicePerguntaAtual: inteiro
            obter => indicePerguntaAtual
            definir(valor) => indicePerguntaAtual := valor
    fim classe
