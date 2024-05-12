using System;
using System.Collections.Generic;

namespace TotemApollo.Modelos
{
    internal class QuestionarioInteracao : Questionario
    {
        private List<string> respostasCorretas;

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

            respostasCorretas = new List<string>
            {
                "C",
                "C",
                "D",
                "A",
                "E",
            };

            for (int i = 0; i < perguntas.Count; i++)
            {
                QuestionarioEstaticos.respostas.Add([]);
            }
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

        public string ObterRespostaPorIndice(int indicePergunta, int indiceResposta)
        {
            if (indicePergunta < 0 || indicePergunta >= perguntas.Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            // Supondo que as respostas sejam representadas por letras de A a E
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

            if (respostaUsuario.ToUpper() == respostaCorreta.ToUpper())
            {
                // Resposta correta
                return true;
            }
            else
            {
                // Resposta incorreta
                return false;
            }
        }
    }
}