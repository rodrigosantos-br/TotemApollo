#### Algoritmo AreaSecreta

    // Importações
    Biblioteca Util
    Biblioteca Controles do TotemApollo

    // Declaração de variáveis
    QuestionarioControle _questionario

    // Início do programa
    Início
        // Inicialização do componente e instância do controle de questionário
        InicializarComponente()
        _questionario := Novo QuestionarioControle()

        // Definição dos eventos dos botões
        AoClicar(BotãoMostrarRelatorio, MostrarRelatorio)
        AoClicar(BotãoFecharPrograma, FecharPrograma)
    Fim

    // Sub-rotina para exibir o relatório
    Sub-rotina MostrarRelatorio(remetente, evento)
        // Obter as porcentagens totais para cada categoria de resposta
        porcentagens := _questionario.ObterPorcentagens()

        // Limpar as linhas do DataGridView
        dgvRelatorio.Linhas.Limpar()

        // Adicionar uma nova linha ao DataGridView
        dgvRelatorio.Linhas.Adicionar()

        // Definir os valores das células na única linha do DataGridView
        dgvRelatorio.Linhas[0].Celulas[0].Valor := _questionario.ObterContadorInteracoes() // Total de Interações
        dgvRelatorio.Linhas[0].Celulas[1].Valor := Util::Formatar("{0:0.00}%", porcentagens[4]) // Muito Satisfeito
        dgvRelatorio.Linhas[0].Celulas[2].Valor := Util::Formatar("{0:0.00}%", porcentagens[3]) // Satisfeito
        dgvRelatorio.Linhas[0].Celulas[3].Valor := Util::Formatar("{0:0.00}%", porcentagens[2]) // Regular
        dgvRelatorio.Linhas[0].Celulas[4].Valor := Util::Formatar("{0:0.00}%", porcentagens[1]) // Insatisfeito
        dgvRelatorio.Linhas[0].Celulas[5].Valor := Util::Formatar("{0:0.00}%", porcentagens[0]) // Muito Insatisfeito
    Fim

    // Sub-rotina para fechar o programa
    Sub-rotina FecharPrograma(remetente, evento)
        Util::Sair()
    Fim

#### Fim Algoritmo
