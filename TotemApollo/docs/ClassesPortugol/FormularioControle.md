#### Algoritmo FormularioControle

    // Procedimento para limpar os controles
    Procedimento LimparControles(controle: Lista de Controle)
        Início
            Para cada controle em controle Faça
                Se (TipoDoControle(controle) = "TextBox") Então
                    LimparTextBox(controle)
                Senão Se (TipoDoControle(controle) = "ComboBox") Então
                    LimparComboBox(controle)
                Senão Se (TipoDoControle(controle) = "CheckBox") Então
                    LimparCheckBox(controle)
                Senão Se (TipoDoControle(controle) = "RadioButton") Então
                    LimparRadioButton(controle)
                Fim Se

                // Recursivamente limpar os controles filhos, se houver
                Se (Tamanho(controle.Controls) > 0) Então
                    LimparControles(controle.Controls)
                Fim Se
            Fim Para
        Fim Procedimento

    // Função para obter o tipo do controle
    Função TipoDoControle(controle: Controle) -> Caractere
        Início
            Retorne ObterTipo(controle)
        Fim Função

    // Procedimento para limpar TextBox
    Procedimento LimparTextBox(controle: Controle)
        Início
            ((controle) Como TextBox).Clear()
        Fim Procedimento

    // Procedimento para limpar ComboBox
    Procedimento LimparComboBox(controle: Controle)
        Início
            ((controle) Como ComboBox).SelectedIndex := -1
        Fim Procedimento

    // Procedimento para limpar CheckBox
    Procedimento LimparCheckBox(controle: Controle)
        Início
            ((controle) Como CheckBox).Checked := Falso
        Fim Procedimento

    // Procedimento para limpar RadioButton
    Procedimento LimparRadioButton(controle: Controle)
        Início
            ((controle) Como RadioButton).Checked := Falso
        Fim Procedimento

#### Fim Algoritmo
