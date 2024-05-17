    classe CadastroValidacao
        privado nome: texto
        privado somente leitura dataNascimento: texto
        privado mensagemNome: texto
        privado mensagemDataNascimento: texto

        metodo novo(nome: texto, dataNascimento: texto)
            this.nome := nome
            this.dataNascimento := dataNascimento
            this.ValidarNome()
            this.ValidarDataNascimento()

        privado void ValidarNome()
            mensagemNome := ""
            se string.IsNullOrWhiteSpace(nome) entao
                mensagemNome := "\nNome não pode ser vazio."
                retornar
            fim se

            se nome.Comprimento < 3 ou nome.Comprimento > 20 entao
                mensagemNome := "\nNome deve ter entre 3 e 20 caracteres."
                retornar
            fim se

            nome := char.ToUpper(nome[0]) + nome.Substring(1).ToLower()

        privado void ValidarDataNascimento()
            mensagemDataNascimento := ""
            se string.IsNullOrWhiteSpace(dataNascimento) entao
                mensagemDataNascimento := "\nData de nascimento não pode ser vazia."
                retornar
            fim se

        publico somente leitura propriedade MensagemNome: texto
            obter
                retornar mensagemNome
            fim obter

        publico somente leitura propriedade MensagemDataNascimento: texto
            obter
                retornar mensagemDataNascimento
            fim obter
    fim classe

