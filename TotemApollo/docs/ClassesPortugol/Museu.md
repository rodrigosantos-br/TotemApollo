    classe Museu
        privado somente leitura obras: Lista<Obra>
        privado somente leitura visitantes: Lista<Visitante>
        privado obraAtualIndex: inteiro // Variável para armazenar o índice da obra atual

        metodo novo()
            visitantes := []
            obras := []

            se Obras.Comprimento == 0 entao
                Imagem imagem1 := Imagem.DoArquivo("Imagens\\imgObra1.jpeg")
                Imagem imagem2 := Imagem.DoArquivo("Imagens\\imgObra2.jpeg")
                Imagem imagem3 := Imagem.DoArquivo("Imagens\\imgObra3.jpeg")
                Imagem imagem4 := Imagem.DoArquivo("Imagens\\imgObra4.jpeg")

                obras.Adicionar(novo Obra(1, "A Grande Jornada Lunar",
                                            "Testemunhe a corajosa façanha da humanidade enquanto adentra" +
                                            " o espaço desconhecido. Esta exibição celebra a primeira viagem" +
                                            " tripulada à Lua, destacando os heróis que a tornaram possível" +
                                            " e os avanços tecnológicos que a viabilizaram.\r\n", imagem1))
                obras.Adicionar(novo Obra(2, "A Pioneira Apollo 11",
                                            "Descubra os segredos da missão Apollo 11, onde Neil Armstrong, Buzz" +
                                            " Aldrin e Michael Collins escreveram seus nomes na história. " +
                                            "Explore os trajes espaciais, artefatos e a emocionante jornada que" +
                                            " levou o homem à superfície lunar pela primeira vez.", imagem2))
                obras.Adicionar(novo Obra(3, "O Desembarque na Lua",
                                            "Reviva o momento transcendental em que a humanidade deu seu primeiro " +
                                            "passo na Lua. Esta exibição imersiva transporta os visitantes para a " +
                                            "superfície lunar, capturando a emoção e a grandiosidade do momento " +
                                            "icônico que mudou para sempre nossa compreensão do cosmos.", imagem3))
                obras.Adicionar(novo Obra(4, "Legado Lunar",
                                            "Explore o impacto duradouro da primeira viagem do homem à Lua e sua " +
                                            "influência na exploração espacial moderna. Dos primeiros passos na " +
                                            "superfície lunar até as futuras expedições interplanetárias, esta exposição " +
                                            "destaca o legado inspirador da conquista do espaço.", imagem4))
            fim se

            obraAtualIndex:= 0 

        metodo AvancarParaProximaObra()
            obraAtualIndex++
            se obraAtualIndex >= obras.Comprimento entao
                obraAtualIndex := 0 
            fim se

        metodo RetrocederParaObraAnterior()
            obraAtualIndex--
            se obraAtualIndex < 0 entao
                obraAtualIndex := obras.Comprimento - 1 
            fim se

        metodo ObraAtual(): Obra
            retornar obras[obraAtualIndex]

        metodo CadastrarVisitante(nome: texto, dataNascimento: texto)
            visitantes.Adicionar(novo Visitante(nome, dataNascimento))

        metodo RemoverUltimoVisitante()
            se visitantes.Comprimento > 0 entao
                visitantes.RemoverNo(visitantes.Comprimento - 1)
            fim se

        metodo ObterQuantidadeDeVisitantes(): inteiro
            retornar visitantes.Comprimento

        metodo ExibirHistoricoObraAtual(): texto
            retornar ExibirHistoricoObra(ObraAtual().Id)

        metodo ExibirHistoricoObra(id: inteiro): texto
            para cada obra em Obras faca
                se obra.Id == id entao
                    retornar $"{obra.Titulo}\n\n    {obra.Historico}"
                fim se
            fim para

            retornar "Obra não encontrada no museu."

        publico somente leitura propriedade Obras: Lista<Ob
