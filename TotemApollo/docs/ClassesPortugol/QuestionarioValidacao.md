    classe QuestionarioValidacao
    
        funcao ValidarRespostas(Lista<int> respostas)

            se (respostas.Contar == 0)
                retornar falso; 

            para cada (inteiro resposta em respostas)
            
                se (resposta == -1)
                    retornar falso;
            
            retornar verdadeiro;
        

        funcao ValidarRespostas(Lista<Botao> botoesResposta)
        
            para cada (Botao botao em botoesResposta)
            
                se (botao.CorFundo != CoresSistema.Controle) 
                    retornar verdadeiro;
                
            
            retornar falso;
    fimclasse
