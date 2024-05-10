using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TotemApollo.Modelos
{
    public class Questionario
    {
        private readonly List<string> perguntas;
        public static readonly List<List<int>> respostas = [];
        public static int contadorInteracoes;

        public Questionario()
        {
            perguntas =
            [
                "Como você classificaria a qualidade geral das exposições apresentadas?",
                "Qual é o seu nível de satisfação com a interatividade e engajamento proporcionado pelas exposições?",
                "Como você avaliaria a adequação do ambiente (iluminação, espaço, acessibilidade) da exposição?",
                "Como você avalia o conhecimento adquirido sobre o tema da exposição?",
                "Considerando sua experiência completa, qual é a probabilidade de você recomendar esta exposição a amigos e familiares?"
            ];

            for (int i = 0; i < perguntas.Count; i++)
            {
                respostas.Add([]);
            }
        }

        public void AdicionarResposta(int indicePergunta, int resposta)
        {
            if (indicePergunta >= 0 && indicePergunta < perguntas.Count)
            {
                respostas[indicePergunta].Add(resposta);
            }
            else
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }
        }

        public List<string> ObterPerguntas()
        {
            return perguntas;
        }

        public List<double> CalcularPorcentagens()
        {
            List<double> porcentagens = [];
            int[] totalPorOpcao = new int[5];

            // Acessando a lista de respostas da instância atual
            foreach (var resposta in respostas)
            {
                foreach (var opcao in resposta)
                {
                    totalPorOpcao[opcao - 1]++;
                }
            }

            double totalRespostas = respostas.Sum(r => r.Count);

            foreach (int totalOpcao in totalPorOpcao)
            {
                double porcentagem = totalOpcao / totalRespostas * 100;
                porcentagens.Add(porcentagem);
            }

            return porcentagens;
        }


        public List<string> ObterRelatorioCumulativo()
        {
            List<string> relatorio =
            [
                $"Número Total de Interações: {contadorInteracoes}"
            ];

            string[] opcoes = ["Péssimo", "Ruim", "Regular", "Bom", "Ótimo"];

            for (int i = 0; i < perguntas.Count; i++)
            {
                StringBuilder respostaFormatada = new();
                respostaFormatada.Append('\n').Append(perguntas[i]).Append(" \n");

                if (i < respostas.Count)
                {
                    int[] contador = new int[5];
                    foreach (var resposta in respostas[i])
                    {
                        if (resposta >= 1 && resposta <= 5)
                        {
                            contador[resposta - 1]++;
                        }
                    }

                    for (int j = 0; j < contador.Length; j++)
                    {
                        respostaFormatada.Append($"\n{opcoes[j]}: \t\t{contador[j]} |");
                    }
                }
                relatorio.Add(respostaFormatada.ToString());
            }

            return relatorio;
        }

        public void IncrementarContadorInteracoes()
        {
            contadorInteracoes++;
        }

        public void DecrementarContadorInteracoes()
        {
            contadorInteracoes--;
        }

        public int ContadorInteracoes => contadorInteracoes;
    }
}
