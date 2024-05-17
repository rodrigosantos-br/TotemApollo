    classe TecladoControle : UserControl
        privado capsAtivado: lógico
        privado shiftAtivado: lógico
        privado teclaProcessada: texto

        evento TeclaProcessada como EventHandler<string>

        metodo novo()
            InitializeComponent()

        metodo AbrirAreaSecreta()
            se chkCtrl.Checked e chkAlt.Checked entao
                AreaSecreta areaSecreta := novo AreaSecreta()
                areaSecreta.Mostrar()
                chkAlt.Checked := falso
                chkCtrl.Checked := falso

        metodo BtnEnter_Click(objeto sender, EventArgs e)
            TeclaProcessada?.Invocar(this, "Enter")

        metodo BtnBackspace_Click(objeto sender, EventArgs e)
            TeclaProcessada?.Invocar(this, "Backspace")

        metodo Tecla_Click(objeto sender, EventArgs e)
            Button tecla := sender como Button
            teclaProcessada := ProcessarTecla(chkShift.Checked, chkCaps.Checked, tecla.Text)
            chkShift.Checked := falso

            TeclaProcessada?.Invocar(this, teclaProcessada)

        metodo privado ProcessarTecla(shift: lógico, caps: lógico, teclaPressionada: texto) retorna texto
            capsAtivado := caps
            shiftAtivado := shift

            para cada letra em 'A' até 'Z' faca
                se teclaPressionada = letra.ToString() entao
                    retornar capsAtivado ou shiftAtivado ? teclaPressionada : teclaPressionada.ToLower()

            escolha teclaPressionada de
                caso "Space":
                    retornar " "
                caso contrario:
                    retornar nulo

        metodo RemoveUltimoCaractere(textBox: TextBox)
            se textBox.Texto.Comprimento > 0 entao
                textBox.Texto := textBox.Texto.Substring(0, textBox.Texto.Comprimento - 1)

        metodo AdicionarTeclado(painel: Panel)
            painel.Adicionar(this)

            se this.ParentForm <> nulo entao
                this.ParentForm.LocationChanged += Form_LocationChanged

            ReposicionarTeclado()

        metodo privado Form_LocationChanged(objeto sender, EventArgs e)
            ReposicionarTeclado()

        metodo privado ReposicionarTeclado()
            se this.ParentForm <> nulo entao
                areaDeTrabalho := Screen.FromControl(this.ParentForm).AreaDeTrabalho

                inteiro x := (areaDeTrabalho.Largura - this.Largura) / 2
                inteiro y := areaDeTrabalho.Altura - this.Altura - 150 // Ajuste da quantidade de pixels conforme necessário

                this.Localizacao := novo Ponto(x, y)

        metodo RemoverTeclado(painel: Panel)
            painel.Remover(this)

            se this.ParentForm <> nulo entao
                this.ParentForm.LocationChanged -= Form_LocationChanged
    fim classe
