#### Algoritmo Museu
    // Declaração de variáveis
    Variáveis
        obras: Lista de Obra
        visitantes: Lista de Visitante

    // Procedimento para inicializar o Museu
    Procedimento Museu()
        Início
            InicializarListas()
        Fim Procedimento

    // Procedimento para inicializar as listas de obras e visitantes
    Procedimento InicializarListas()
        Início
            InicializarObras()
            InicializarVisitantes()
        Fim Procedimento

    // Procedimento para inicializar a lista de obras
    Procedimento InicializarObras()
        Início
            obras := CriarListaDeObras()
        Fim Procedimento

    // Procedimento para inicializar a lista de visitantes
    Procedimento InicializarVisitantes()
        Início
            visitantes := CriarListaDeVisitantes()
        Fim Procedimento

    // Procedimento para cadastrar um visitante
    Procedimento CadastrarVisitante(nome: Caractere, dataNascimento: Caractere)
        Início
            AdicionarVisitante(nome, dataNascimento)
        Fim Procedimento

    // Procedimento para remover o último visitante
    Procedimento RemoverUltimoVisitante()
        Inicio
            Se visitantes.Contador > 0
                visitantes.Remover(visitantes.Contador -1)
        Fim Procedimento

    // Função para obter a quantidade de visitantes
    Função ObterQuantidadeDeVisitantes() -> Inteiro
        Início
            Retorne QuantidadeDeVisitantes()
        Fim Função

    // Função para exibir o histórico de uma obra
    Função ExibirHistoricoObra(id: Inteiro) -> Caractere
        Início
            Retorne HistoricoDaObra(id)
        Fim Função

    // Função para criar a lista de obras
    Função CriarListaDeObras() -> Lista de Obra
        Início
            // Inicializa a lista de obras
            obras := CriarListaVaziaDeObras()

            // Adiciona as obras padrão apenas se a lista estiver vazia
            Se (Tamanho(obras) = 0) Então
                AdicionarObrasPadrao(obras)
            Fim Se

            Retorne obras
        Fim Função

    // Procedimento para adicionar obras padrão à lista
    Procedimento AdicionarObrasPadrao(var obras: Lista de Obra)
        Início
            AdicionarObra(obras, Nova Obra(1, "Título1", "Histórico1"))
            AdicionarObra(obras, Nova Obra(2, "Título2", "Histórico2"))
            AdicionarObra(obras, Nova Obra(3, "Título3", "Histórico3"))
            AdicionarObra(obras, Nova Obra(4, "Título4", "Histórico4"))
        Fim Procedimento

    // Função para criar uma lista vazia de obras
    Função CriarListaVaziaDeObras() -> Lista de Obra
        Início
            Retorne Nova Lista de Obra
        Fim Função

    // Procedimento para adicionar uma obra à lista de obras
    Procedimento AdicionarObra(var obras: Lista de Obra, obra: Obra)
        Início
            AdicionarElemento(obra, obras)
        Fim Procedimento

    // Função para criar uma lista vazia de visitantes
    Função CriarListaDeVisitantes() -> Lista de Visitante
        Início
            Retorne Nova Lista de Visitante
        Fim Função

    // Procedimento para adicionar um visitante à lista de visitantes
    Procedimento AdicionarVisitante(nome: Caractere, dataNascimento: Caractere)
        Início
            AdicionarElemento(Nova Visitante(nome, dataNascimento), visitantes)
        Fim Procedimento

    // Função para obter a quantidade de visitantes
    Função QuantidadeDeVisitantes() -> Inteiro
        Início
            Retorne Tamanho(visitantes)
        Fim Função

    // Função para obter o histórico de uma obra
    Função HistoricoDaObra(id: Inteiro) -> Caractere
        Início
            Para cada obra em obras Faça
                Se (obra.Id = id) Então
                    Retorne "Título: " + obra.Título + "\nHistórico: " + obra.Histórico
                Fim Se
            Fim Para

            Retorne "Obra não encontrada no museu."
        Fim Função
#### Fim Algoritmo
