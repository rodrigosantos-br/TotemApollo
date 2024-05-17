    classe Questionario
        protegido Lista texto perguntas

        publico Questionario()
    
        publico vazio AdicionarResposta(int indicePergunta, int resposta)
            se (indicePergunta >= 0 e indicePergunta < perguntas.Contar)
                QuestionarioEstaticos.respostas[indicePergunta].Adicionar(resposta)
            senao
                lançar nova IndexOutOfRangeException("O índice da pergunta está fora dos limites.")
    
        publico Lista texto ObterPerguntas()
            retornar perguntas
    
        publico vazio IncrementarContadorInteracoes()
            QuestionarioEstaticos.contadorInteracoes++
    
        publico vazio DecrementarContadorInteracoes()
            QuestionarioEstaticos.contadorInteracoes--
    
        publico int ContadorInteracoes => QuestionarioEstaticos.contadorInteracoes
    fimclasse
