#### Algoritmo QuestionarioControle
    variáveis
        questionario: Questionario
        validacao: QuestionarioValidacao

    procedimento QuestionarioControle()
        inicio
            questionario := novo Questionario()
            validacao := novo QuestionarioValidacao()
        fim_procedimento

    funcao ObterPorcentagens() -> lista de real
        inicio
            retorne questionario.CalcularPorcentagens()
        fim_funcao

    funcao ObterPerguntas() -> lista de caractere
        inicio
            retorne questionario.ObterPerguntas()
        fim_funcao

    procedimento AdicionarRespostas(indicePergunta: inteiro, resposta: inteiro)
        inicio
            questionario.AdicionarResposta(indicePergunta, resposta)
        fim_procedimento

    funcao ValidarRespostas(respostas: lista de inteiro) -> logico
        inicio
            retorne validacao.ValidarRespostas(respostas)
        fim_funcao

    // Método para obter a resposta para uma pergunta específica
    funcao ObterRespostaParaPergunta(opcoes: matriz de RadioButton) -> inteiro
        var
            i: inteiro
        inicio
            para i de 0 ate tamanho(opcoes) - 1 faca
                se opcoes[i].Verificado entao
                    retorne i + 1 // Retorna o número da opção (começando em 1)
                fim_se
            fim_para
            retorne -1 // Retorna -1 se nenhuma opção estiver selecionada
        fim_funcao

    // Método para obter o número total de interações
    procedimento IncrementarContadorInteracoes()
        inicio
            questionario.IncrementarContadorInteracoes()
        fim_procedimento

    // Método para obter o número total de interações
    funcao ObterContadorInteracoes() -> inteiro
        inicio
            retorne questionario.ContadorInteracoes
        fim_funcao

    funcao ObterRespostasDoFormulario(opcoes: matriz de matriz de RadioButton) -> lista de inteiro
        var
            respostas: lista de inteiro
            pergunta: matriz de RadioButton
        inicio
            respostas := nova lista de inteiro

            para cada pergunta em opcoes faca
                adicionar_elemento(ObterRespostaParaPergunta(pergunta), respostas)
            fim_para

            retorne respostas
        fim_funcao

    // Método para obter o relatório cumulativo das respostas
    funcao ObterRelatorioCumulativo() -> lista de caractere
        inicio
            retorne questionario.ObterRelatorioCumulativo()
        fim_funcao
#### Fim Algoritmo