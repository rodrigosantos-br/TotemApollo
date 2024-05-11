using System;
using System.Collections.Generic;

namespace TotemApollo.Modelos
{
    internal class QuestionarioInteracao : Questionario
    {
        private List<string> respostasCorretas;

        public QuestionarioInteracao()
        {
            perguntas = new List<string>
            {
                "Pergunta1",
                "Pergunta2",
                "Pergunta3",
                "Pergunta4",
                "Pergunta5",
            };

            respostasCorretas = new List<string>
            {
                "RespostaCorreta1",
                "RespostaCorreta2",
                "RespostaCorreta3",
                "RespostaCorreta4",
                "RespostaCorreta5",
            };

            for (int i = 0; i < perguntas.Count; i++)
            {
                QuestionarioEstaticos.respostas.Add([]);
            }
        }

        public bool VerificarResposta(int indicePergunta, int respostaUsuario)
        {
            if (indicePergunta < 0 || indicePergunta >= perguntas.Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            string respostaCorreta = respostasCorretas[indicePergunta];

            if (respostaUsuario == ObterIndiceRespostaCorreta(respostaCorreta))
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

        public string ObterRespostaCorreta(int indicePergunta)
        {
            if (indicePergunta < 0 || indicePergunta >= perguntas.Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            return respostasCorretas[indicePergunta];
        }

        private int ObterIndiceRespostaCorreta(string respostaCorreta)
        {
            return respostasCorretas.IndexOf(respostaCorreta);
        }
    }
}