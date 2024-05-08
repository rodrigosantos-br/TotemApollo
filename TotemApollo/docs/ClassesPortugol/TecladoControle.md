#### Algoritmo TecladoControle
    variáveis
        capsAtivado: lógico
        shiftAtivado: lógico
        teclaProcessada: caractere

    evento TeclaProcessada(sender: referência a TecladoControle, tecla: caractere)

    procedimento TecladoControle()
        início
            capsAtivado := falso
            shiftAtivado := falso
            teclaProcessada := ""

            // Inicializa o componente
            InicializarComponente()
        fim_procedimento

    procedimento AbrirAreaSecreta()
        início
            se (chkCtrl.Marcado e chkAlt.Marcado) então
                var areaSecreta := nova AreaSecreta()
                areaSecreta.Mostrar()
                chkAlt.Marcado := falso
                chkCtrl.Marcado := falso
            fim_se
        fim_procedimento

    procedimento BtnEnter_Clicar(sender: objeto, e: EventArgs)
        início
            TeclaProcessada(this, "Enter")
        fim_procedimento

    procedimento BtnBackspace_Clicar(sender: objeto, e: EventArgs)
        início
            TeclaProcessada(this, "Backspace")
        fim_procedimento

    procedimento Tecla_Clicar(sender: objeto, e: EventArgs)
        início
            var tecla := (sender como Botão)
            teclaProcessada := ProcessarTecla(chkShift.Marcado, chkCaps.Marcado, tecla.Texto)
            chkShift.Marcado := falso

            // Dispara o evento TeclaPressionada
            TeclaProcessada(this, teclaProcessada)
        fim_procedimento

    função ProcessarTecla(shift: lógico, caps: lógico, teclaPressionada: caractere) -> caractere
        início
            capsAtivado := caps
            shiftAtivado := shift

            // Verifica se a tecla é uma letra
            para cada letra em intervalo('A', 'Z') faça
                se (teclaPressionada = letra) então
                    retorne capsAtivado ou shiftAtivado ? teclaPressionada : para_minusculo(teclaPressionada)
                fim_se
            fim_para

            caso teclaPressionada de
                'Espaço':
                    retorne " "
                senão:
                    retorne nulo
            fim_caso
        fim_função

    procedimento RemoverÚltimoCaractere(caixaDeTexto: CaixaDeTexto)
        início
            se (tamanho(caixaDeTexto.Texto) > 0) então
                caixaDeTexto.Texto := subcadeia(caixaDeTexto.Texto, 0, tamanho(caixaDeTexto.Texto) - 1)
            fim_se
        fim_procedimento

    procedimento AdicionarTeclado(painel: Painel)
        variáveis
            áreaDeTrabalho: Retângulo
            x, y: inteiro
        início
            // Obtém a área de trabalho da tela principal
            áreaDeTrabalho := ObterÁreaDeTrabalhoTelaPrincipal()

            // Calcula a posição para centralizar horizontalmente e colocar na parte inferior da tela
            x := (áreaDeTrabalho.Largura - isso.Largura) / 2
            y := áreaDeTrabalho.Altura - isso.Altura - 120 // Ajuste a quantidade de pixels conforme necessário

            // Define a posição do controle
            isso.Posição := novo Ponto(x, y)

            // Adiciona o ControleTeclado ao formulário
            adicionar_elemento(isso, painel)
        fim_procedimento

    procedimento RemoverTeclado(painel: Painel)
        início
            remover_elemento(isso, painel)
        fim_procedimento
#### Fim Algoritmo