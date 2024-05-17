    classe QuestionarioSatisfacao : Questionario
    
        QuestionarioSatisfacao()
        
            perguntas =
            [
                "Como você classificaria a qualidade geral das exposições apresentadas?",
                "Qual é o seu nível de satisfação com a interatividade e engajamento proporcionado pelas exposições?",
                "Como você avaliaria a adequação do ambiente (iluminação, espaço, acessibilidade) da exposição?",
                "Como você avalia o conhecimento adquirido sobre o tema da exposição?",
                "Considerando sua experiência completa, qual é a probabilidade de você recomendar esta exposição a amigos e familiares?"
            ];

            para (inteiro i = 0; i < perguntas.Contar; i++)
                QuestionarioEstaticos.respostas.Adicionar([]);

        Lista<real> CalcularPorcentagens()
        
            Lista<real> porcentagens = [];
            inteiro[] totalPorOpcao = novo inteiro[5];

            
            para cada (var resposta em QuestionarioEstaticos.respostas)
            
                para cada (var opcao em resposta)
                
                    totalPorOpcao[opcao - 1]++;
                
            real totalRespostas = QuestionarioEstaticos.respostas.Somar(r => r.Contar);

            
            para cada (inteiro totalOpcao em totalPorOpcao)
            
                real porcentagem = totalOpcao / totalRespostas * 100;
                porcentagens.Adicionar(porcentagem);
            
            retornar porcentagens;
        

        Lista<cadeia> ObterRelatorioCumulativo()
        
            Lista<cadeia> relatorio = novo Lista<cadeia>
            {
                $"Número Total de Visitantes: {QuestionarioEstaticos.contadorInteracoes}"
            };

            cadeia[] opcoes = { "Péssimo", "Ruim", "Regular", "Bom", "Ótimo" };

            
            para (inteiro i = 0; i < perguntas.Contar; i++)
            
                StringBuilder respostaFormatada = novo StringBuilder();
                respostaFormatada.Append('\n').Append(perguntas[i]).Append("\n");

                
                se (i < QuestionarioEstaticos.respostas.Contar)
                
                    inteiro[] contador = novo inteiro[5];
                    para cada (var resposta em QuestionarioEstaticos.respostas[i])
                    
                        se (resposta >= 1 E resposta <= 5)
                            contador[resposta - 1]++;
                                            
                    para (inteiro j = 0; j < contador.Comprimento; j++)
                        respostaFormatada.Append($" {opcoes[j]}: {contador[j]}  |  ");

                relatorio.Adicionar(respostaFormatada.ToString());
            
            retornar relatorio;

    fim classe