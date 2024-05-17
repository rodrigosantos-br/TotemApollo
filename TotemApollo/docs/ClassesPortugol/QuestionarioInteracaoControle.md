    usando Sistema.Texto;

    classe QuestionarioInteracao : Questionario
        privado Lista<cadeia> respostasCorretas;
        privado Lista<cadeia> explicaçõesRespostasCorretas;
        privado inteiro acertos;
        privado inteiro erros;

        QuestionarioInteracao()
            perguntas =
            [
                "1 - Qual foi a data da primeira viagem à lua?\n\n" +
                "a) 5 de maio de 1985\n" +
                "b) 21 de agosto de 1970\n" +
                "c) 20 de julho de 1969\n" +
                "d) 3 de abril de 1971\n" +
                "e) 12 de junho de 1965",
                "2 - Quem foi o primeiro ser humano a pisar na lua?\n\n" +
                "a) Buzz Aldrin\n" +
                "b) Yuri Gagarin\n" +
                "c) Neil Armstrong\n" +
                "d) John Glenn\n" +
                "e) Alan Shepard",
                "3 - Qual foi o nome da nave espacial que levou os astronautas até a lua?\n\n" +
                "a) Endeavour\n" +
                "b) Voyager 1\n" +
                "c) Discovery\n" +
                "d) Apollo 11\n" +
                "e) Challenger",
                "4 - Quantos astronautas participaram da primeira missão à lua?\n\n" +
                "a) Dois\n" +
                "b) Três\n" +
                "c) Quatro\n" +
                "d) Cinco\n" +
                "e) Seis",
                "5 - Qual foi a frase famosa dita por Neil Armstrong ao pisar na lua?\n\n" +
                "a) A próxima fronteira está diante de nós\n" +
                "b) Aqui, o céu não é o limite, é apenas o começo\n" +
                "c) Um momento histórico para todos nós\n" +
                "d) Que lugar incrível para explorar\n" +
                "e) Um pequeno passo para o homem, um salto gigante para a humanidade\n",
                ""
            ];

            explicaçõesRespostasCorretas = nova Lista<cadeia>
            {
                "Resposta Correta C)\nA primeira viagem à Lua ocorreu em 20 de julho de 1969.Neil Armstrong e Buzz Aldrin caminharam na Lua nessa data.",
                "Resposta Correta C)\nO primeiro ser humano a pisar na Lua foi Neil Armstrong.",
                "Resposta Correta D)\nA nave espacial que levou os astronautas até a Lua foi a Apollo 11.",
                "Resposta Correta A)\nNa primeira missão à Lua participaram dois astronautas: Neil Armstrong e Buzz Aldrin.",
                "Resposta Correta E)\nA frase famosa dita por Neil Armstrong ao pisar na Lua foi: 'Um pequeno passo para o homem, um salto gigante para a humanidade.'"
            ];

            respostasCorretas = nova Lista<cadeia>
            {
                "C",
                "C",
                "D",
                "A",
                "E",
            ];

            para (inteiro i = 0; i < perguntas.Contar; i++)
                QuestionarioEstaticos.respostas.Adicionar([]);

            acertos = 0;
            erros = 0;
        fim

        metodo inteiro ObterNumeroPerguntas()
            retornar perguntas.Contar;
        fim

        metodo cadeia ObterPergunta(inteiro indicePergunta)
            se (indicePergunta < 0 OU indicePergunta >= perguntas.Contar)
                lançar NovaExcecaoDeIndiceForaDosLimites("O índice da pergunta está fora dos limites.");
        
            retornar perguntas[indicePergunta];
        fim

        metodo cadeia ObterExplicacaoRespostaCorreta(inteiro indicePergunta)
            se (indicePergunta >= 0 E indicePergunta < explicaçõesRespostasCorretas.Contar)
                retornar explicaçõesRespostasCorretas[indicePergunta];
            senao
                retornar "Explicação não encontrada.";
        fim

        metodo cadeia ObterRespostaPorIndice(inteiro indicePergunta, inteiro indiceResposta)
            se (indicePergunta < 0 OU indicePergunta >= perguntas.Contar)
                lançar NovaExcecaoDeIndiceForaDosLimites("O índice da pergunta está fora dos limites.");

        metodo logico VerificarResposta(inteiro indicePergunta, cadeia respostaUsuario)
        se (indicePergunta < 0 OU indicePergunta >= perguntas.Contar)
            lançar NovaExcecaoDeIndiceForaDosLimites("O índice da pergunta está fora dos limites.");

        cadeia respostaCorreta = respostasCorretas[indicePergunta];

        se (respostaUsuario.ToUpper() == respostaCorreta.ToUpper())
            acertos++;
            retornar verdadeiro;
        senao
            erros++;
            retornar falso;
    fim

    metodo cadeia ExibirGabarito()
        StringBuilder sb = novo StringBuilder();
        sb.AppendLine($"          Total de Visitantes:     {ContadorInteracoes}\n");
        sb.AppendLine($"Total de acertos: {acertos}     |     Total de erros: {erros}");
        retornar sb.ToString();
    fim
