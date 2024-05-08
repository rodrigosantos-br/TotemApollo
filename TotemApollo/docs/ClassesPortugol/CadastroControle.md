#### Algoritmo CadastroControle

    // Declaração de variáveis
    museu: Museu
    validacao: CadastroValidacao
    mensagem: Caractere

    // Procedimento para controlar o cadastro do visitante
    Procedimento CadastroControle(nome: Caractere, dataNascimento: Caractere)
        Início
            validacao := Novo CadastroValidacao(nome, dataNascimento)
            Se (validacao.MensagemNome = "" E validacao.MensagemDataNascimento = "") Então
                museu := Novo Museu()
                museu.CadastrarVisitante(nome, dataNascimento)
                mensagem := ""
            Senão
                mensagem := "Não foi possível cadastrar o visitante. "
                Se (validacao.MensagemNome <> "") Então
                    mensagem := mensagem + validacao.MensagemNome
                Fim Se
                Se (validacao.MensagemDataNascimento <> "") Então
                    mensagem := mensagem + validacao.MensagemDataNascimento
                Fim Se
            Fim Se
        Fim Procedimento

    // Procedimento para remover o ultimo visitante caso desista de responder o questionario
    Inicio
        Função RemoverUltimoVisitante()
            museu.RemoverUltimoVisitante()
    Fim Função
    
    // Função para obter a mensagem
    Função Mensagem() -> Caractere
        Início
            Retorne mensagem
        Fim Função

#### Fim Algoritmo
