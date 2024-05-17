    classe FormularioControle
        metodo LimparControles(controle: vetor de Controle)
            para cada controle em controle faca
                se controle for TextBox entao
                    controle.Clear()
                senao se controle for ComboBox entao
                    controle.SelectedIndex := -1
                senao se controle for CheckBox entao
                    controle.Checked := falso

                se controle.Controls.Tamanho > 0 entao
                    LimparControles(controle.Controls)

        metodo IniciarTimer(objetoAlvo: Controle, intervalo: inteiro)
            temporizador := novo Timer()
            temporizador.Intervalo := intervalo 
            temporizador.AoClicar := (sender, e) ->
                objetoAlvo.Visible := falso 
                temporizador.Parar() 
                temporizador.LiberarRecursos() 
            temporizador.Iniciar() 

        metodo IniciarTimer(controle: Controle, intervalo: inteiro, callback: acao)
            temporizador := novo Timer()
            temporizador.Intervalo := intervalo
            temporizador.AoClicar := (s, e) ->
                controle.Visible := falso
                temporizador.Parar()
                callback?.Invocar()
            temporizador.Iniciar()
    fim classe
