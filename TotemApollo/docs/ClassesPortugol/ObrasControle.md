#### Algoritmo ObrasControle
    Variáveis
        museu: Museu

    // Procedimento para controle das obras
    Procedimento ObrasControle()
        Início
            museu := Nova Museu()
        Fim Procedimento

    // Função para exibir o histórico de uma obra com base no ID
    Função ExibirHistoricoObra(id: Inteiro) -> Caractere
        Início
            Retorne museu.ExibirHistoricoObra(id)
        Fim Função
#### Fim Algoritmo
