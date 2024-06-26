﻿using System.Text;

namespace TotemApollo.Modelos
{
    public class QuestionarioInteracao : Questionario
    {
        private readonly List<string> respostasCorretas;
        private readonly List<string> explicaçõesRespostasCorretas;
        private int acertosVisitanteAtual;
        private int errosVisitanteAtual;
        private int acertos;
        private int erros;


        public QuestionarioInteracao()
        {
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

            explicaçõesRespostasCorretas =
            [
                "Resposta Correta C)\nA primeira viagem à Lua ocorreu em 20 de julho de 1969.Neil Armstrong e Buzz Aldrin caminharam na Lua nessa data.",
                "Resposta Correta C)\nO primeiro ser humano a pisar na Lua foi Neil Armstrong.",
                "Resposta Correta D)\nA nave espacial que levou os astronautas até a Lua foi a Apollo 11.",
                "Resposta Correta A)\nNa primeira missão à Lua participaram dois astronautas: Neil Armstrong e Buzz Aldrin.",
                "Resposta Correta E)\nA frase famosa dita por Neil Armstrong ao pisar na Lua foi: 'Um pequeno passo para o homem, um salto gigante para a humanidade.'"
            ];

            respostasCorretas =
            [
                "C",
                "C",
                "D",
                "A",
                "E",
            ];

            for (int i = 0; i < perguntas.Count; i++)
            {
                QuestionarioEstaticos.respostas.Add([]);
            }
            acertosVisitanteAtual = 0;
            errosVisitanteAtual = 0;
            acertos = 0;
            erros = 0;
        }

        public int ObterNumeroPerguntas()
        {
            return perguntas.Count;
        }

        public string ObterPergunta(int indicePergunta)
        {
            if (indicePergunta < 0 || indicePergunta >= perguntas.Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            return perguntas[indicePergunta];
        }

        public string ObterExplicacaoRespostaCorreta(int indicePergunta)
        {
            if (indicePergunta >= 0 && indicePergunta < explicaçõesRespostasCorretas.Count)
            {
                return explicaçõesRespostasCorretas[indicePergunta];
            }
            else
            {
                return "Explicação não encontrada.";
            }
        }

        public string ObterRespostaPorIndice(int indicePergunta, int indiceResposta)
        {
            if (indicePergunta < 0 || indicePergunta >= perguntas.Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            // Respostas representadas por letras de A a E
            char resposta = (char)('A' + indiceResposta);
            return resposta.ToString();
        }

        public bool VerificarResposta(int indicePergunta, string respostaUsuario)
        {
            if (indicePergunta < 0 || indicePergunta >= perguntas.Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            string respostaCorreta = respostasCorretas[indicePergunta];

            if (respostaUsuario.Equals(respostaCorreta, StringComparison.CurrentCultureIgnoreCase))
            {
                // Resposta correta
                acertosVisitanteAtual++;
                acertos++;
                return true;
            }
            else
            {
                // Resposta incorreta
                errosVisitanteAtual++;
                erros++;
                return false;
            }
        }

        public void DecrementarContadoresPorResposta(int indicePergunta)
        {
            if (indicePergunta < 0 || indicePergunta >= perguntas.Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            if (acertosVisitanteAtual > 0)
            {
                acertosVisitanteAtual--;
                acertos--;
            }
            else if (errosVisitanteAtual > 0)
            {
                errosVisitanteAtual--;
                erros--;
            }
        }

        public void ResetarContadoresVisitanteAtual()
        {
            acertosVisitanteAtual = 0;
            errosVisitanteAtual = 0;
        }

        // Método para obter o total de interações, respostas acumuladas e respostas individuais.
        public string ExibirRelatorioInteracao()
        {
            StringBuilder sb = new();
            sb.AppendLine($"          Total de Visitantes:     {ContadorInteracoes}\n");
            sb.AppendLine($"Total de acertos: {acertos}     |     Total de erros: {erros}\n");
            sb.AppendLine($"Você      Acertou: {acertosVisitanteAtual}    |   Errou: {errosVisitanteAtual}");
            return sb.ToString();
        }
    }
}