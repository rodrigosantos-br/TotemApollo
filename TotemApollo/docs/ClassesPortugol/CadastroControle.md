    classe CadastroControle
        privado museu: Museu
        privado validacao: CadastroValidacao
        privado mensagem: string

        metodo novo(nome: string, dataNascimento: string)
            this.validacao := novo CadastroValidacao(nome, dataNascimento)
            se validacao.MensagemNome = "" e validacao.MensagemDataNascimento = "" entao
                this.museu := novo Museu()
                this.museu.CadastrarVisitante(nome, dataNascimento)
                this.mensagem := ""
            senao
                this.mensagem := "Não foi possível cadastrar o visitante. "
                se validacao.MensagemNome != "" entao
                    this.mensagem := this.mensagem + validacao.MensagemNome
                se validacao.MensagemDataNascimento != "" entao
                    this.mensagem := this.mensagem + validacao.MensagemDataNascimento

        metodo RemoverUltimoVisitante()
            museu.RemoverUltimoVisitante()

        metodo Mensagem() retorna mensagem
    fim classe
