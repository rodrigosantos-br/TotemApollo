    algoritmo
        classe AreaSecreta
            privado _questionario: QuestionarioSatisfacaoControle

            metodo novo()
                inicializarComponentes()
                _questionario = novo QuestionarioSatisfacaoControle()

            metodo BtnFecharPrograma_Clicar(sender, e)
                Application.Sair()

            metodo BtnVoltarCadastro_Clicar(sender, e)
                fechar()

            metodo AreaSecreta_Carregar(sender, e)
                porcentagens : vetor de real
                porcentagens = _questionario.ObterPorcentagens()

                dgvRelatorio.linhas[0].celulas[0].valor = _questionario.ObterContadorInteracoes() 
                dgvRelatorio.linhas[0].celulas[1].valor = $"{porcentagens[4]:0.00}%" 
                dgvRelatorio.linhas[0].celulas[2].valor = $"{porcentagens[3]:0.00}%" 
                dgvRelatorio.linhas[0].celulas[3].valor = $"{porcentagens[2]:0.00}%" 
                dgvRelatorio.linhas[0].celulas[4].valor = $"{porcentagens[1]:0.00}%" 
                dgvRelatorio.linhas[0].celulas[5].valor = $"{porcentagens[0]:0.00}%" 
        fim classe
    fim algoritmo
