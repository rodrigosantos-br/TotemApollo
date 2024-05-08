#### Algoritmo Questionário
    // Lista de perguntas
    Privado perguntas : Lista de Texto

    // Lista de respostas acumulativas
    Público Estático respostas : Lista de Lista de Inteiro
        
    // Contador de interações
    Privado Estático contadorInteracoes : Inteiro

    // Inicialização estática
    Estático Questionário()
        respostas := Nova Lista de Lista de Inteiro()

    // Método construtor
    Construtor Questionário()
        // Inicialize as perguntas
        perguntas := Nova Lista de Texto()
        perguntas.Adicionar("Como você classificaria a qualidade geral das exposições apresentadas?")
        perguntas.Adicionar("Qual é o seu nível de satisfação com a interatividade e engajamento proporcionado pelas exposições?")
        perguntas.Adicionar("Como você avaliaria a adequação do ambiente (iluminação, espaço, acessibilidade) da exposição?")
        perguntas.Adicionar("Como você avalia o conhecimento adquirido sobre o tema da exposição?")
        perguntas.Adicionar("Considerando sua experiência completa, qual é a probabilidade de você recomendar esta exposição a amigos e familiares?")

        // Inicialize as listas de respostas para cada pergunta
        Para i de 0 até perguntas.Tamanho - 1 Passo 1
            respostas.Adicionar(Nova Lista de Inteiro())

    // Método para adicionar respostas ao questionário
    Público AdicionarResposta(indicePergunta : Inteiro, resposta : Inteiro)
        Se (indicePergunta >= 0 E indicePergunta < perguntas.Tamanho) Então
            respostas[indicePergunta].Adicionar(resposta)
        Senão
            Lancar Nova Excecao("O índice da pergunta está fora dos limites.")

    // Método para obter as perguntas do questionário
    Público ObterPerguntas() : Lista de Texto
        Retorne perguntas

    // Método para calcular as porcentagens das respostas
    Público CalcularPorcentagens() : Lista de Real
        Porcentagens : Lista de Real
        TotalPorOpcao : Vetor de Inteiro[5]
        TotalRespostas : Real

        // Inicialize as porcentagens
        Porcentagens := Nova Lista de Real()

        // Inicialize o vetor de contagem para cada opção de resposta
        Para i de 0 até 4 Passo 1
            TotalPorOpcao[i] := 0

        // Contar o número total de respostas para cada opção
        Para Cada Resposta na respostas
            Para i de 0 até Resposta.Tamanho - 1 Passo 1
                TotalPorOpcao[Resposta[i] - 1]++

        // Calcular a porcentagem para cada opção
        TotalRespostas := respostas.Soma(r => r.Tamanho) // Total de todas as respostas
        Para Cada TotalOpcao em TotalPorOpcao
            Porcentagem := TotalOpcao / TotalRespostas * 100
            Porcentagens.Adicionar(Porcentagem)

        Retorne Porcentagens

    // Método para obter o relatório cumulativo das respostas
    Público ObterRelatorioCumulativo() : Lista de Texto
        Relatorio : Lista de Texto

        // Inicialize o relatório
        Relatorio := Nova Lista de Texto()
        Relatorio.Adicionar($"Número Total de Interações: {contadorInteracoes}")

        // Iterar sobre todas as perguntas
        Para i de 0 até perguntas.Tamanho - 1 Passo 1
            RespostaFormatada : Texto
            RespostaFormatada := "\n" + perguntas[i] + " \n"

            // Verificar se há respostas para esta pergunta na lista compartilhada
            Se (i < respostas.Tamanho) Então
                // Contagem das respostas
                Contador : Vetor de Inteiro[5]
                Para j de 0 até 4 Passo 1
                    Contador[j] := 0
                Para Cada Resposta na respostas[i]
                    Se (resposta >= 1 e resposta <= 5) Então
                        Contador[resposta - 1]++

                // Adicionar contagem ao relatório
                Para j de 0 até Contador.Tamanho - 1 Passo 1
                    RespostaFormatada := RespostaFormatada + $"\nOpção {j + 1}: {Contador[j]} |"

            // Adicionar a resposta formatada ao relatório
            Relatorio.Adicionar(RespostaFormatada)

        Retorne Relatorio

    // Método para incrementar o contador de interações
    Público IncrementarContadorInteracoes()
        contadorInteracoes++

    // Propriedade para acessar o contador de interações
    Público ObterContadorInteracoes() : Inteiro
        Retorne contadorInteracoes
#### Fim Algoritmo
