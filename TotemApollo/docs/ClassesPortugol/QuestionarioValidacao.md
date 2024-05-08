#### Algoritmo QuestionarioValidacao
    procedimento QuestionarioValidacao()
        // Método para validar se todas as questões foram respondidas
        funcao ValidarRespostas(respostas: lista de inteiro) -> logico
        inicio
            se tamanho(respostas) = 0 entao
                retorne falso // Retorna falso se a lista estiver vazia
            fim_se

            para cada resposta em respostas faca
                se resposta = -1 entao // Se a resposta for -1, significa que não foi respondida
                    retorne falso
                fim_se
            fim_para

            retorne verdadeiro
        fim_funcao
#### Fim Algoritmo
