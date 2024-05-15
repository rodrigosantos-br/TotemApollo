using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TotemApollo.Modelos
//{
//    internal class Relatorio
//    {
//        private Questionario questionario;
//        private QuestionarioSatisfacao questionarioSatisfacao;
//        private QuestionarioInteracao questionarioInteracao;

//        public Relatorio()
//        {
//            questionario = new Questionario();
//            questionarioSatisfacao = new QuestionarioSatisfacao();
//            questionarioInteracao = new QuestionarioInteracao();
//        }

//        public List<double> CalcularPorcentagens()
//        {
//            List<double> porcentagens = [];
//            int[] totalPorOpcao = new int[5];

//            // Acessando a lista de respostas da instância atual
//            foreach (var resposta in QuestionarioEstaticos.respostas)
//            {
//                foreach (var opcao in resposta)
//                {
//                    totalPorOpcao[opcao - 1]++;
//                }
//            }

//            double totalRespostas = QuestionarioEstaticos.respostas.Sum(r => r.Count);

//            foreach (int totalOpcao in totalPorOpcao)
//            {
//                double porcentagem = totalOpcao / totalRespostas * 100;
//                porcentagens.Add(porcentagem);
//            }

//            return porcentagens;
//        }


//        public List<string> ObterRelatorioCumulativo()
//        {
//            List<string> relatorio =
//            [
//                $"Número Total de Interações: {QuestionarioEstaticos.contadorInteracoes}"
//            ];

//            string[] opcoes = ["Péssimo", "Ruim", "Regular", "Bom", "Ótimo"];

//            for (int i = 0; i < questionario.Perguntas.Count; i++)
//            {
//                StringBuilder respostaFormatada = new();
//                respostaFormatada.Append('\n').Append(questionario.Perguntas[i]).Append(" \n");

//                if (i < QuestionarioEstaticos.respostas.Count)
//                {
//                    int[] contador = new int[5];
//                    foreach (var resposta in QuestionarioEstaticos.respostas[i])
//                    {
//                        if (resposta >= 1 && resposta <= 5)
//                        {
//                            contador[resposta - 1]++;
//                        }
//                    }

//                    for (int j = 0; j < contador.Length; j++)
//                    {
//                        respostaFormatada.Append($"\n{opcoes[j]}: \t\t{contador[j]} |");
//                    }
//                }
//                relatorio.Add(respostaFormatada.ToString());
//            }

//            return relatorio;
//        }
//    }
//}
