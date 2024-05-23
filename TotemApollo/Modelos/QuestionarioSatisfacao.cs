using System.Text;

namespace TotemApollo.Modelos
{
    public class QuestionarioSatisfacao : Questionario
    {
        public QuestionarioSatisfacao()
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
                QuestionarioEstaticos.respostas.Add([]);
            }
        }

        public List<double> CalcularPorcentagens()
        {
            List<double> porcentagens = [];
            int[] totalPorOpcao = new int[5];

            // Acessando a lista de respostas da instância atual
            foreach (var resposta in QuestionarioEstaticos.respostas)
            {
                foreach (var opcao in resposta)
                {
                    totalPorOpcao[opcao - 1]++;
                }
            }

            double totalRespostas = QuestionarioEstaticos.respostas.Sum(r => r.Count);

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
                $"Número Total de Visitantes: {QuestionarioEstaticos.contadorInteracoes}"
            ];

            string[] opcoes = ["Péssimo", "Ruim", "Regular", "Bom", "Ótimo"];

            for (int i = 0; i < perguntas.Count; i++)
            {
                StringBuilder respostaFormatada = new();
                respostaFormatada.Append('\n').Append(perguntas[i]).Append('\n');

                if (i < QuestionarioEstaticos.respostas.Count)
                {
                    int[] contador = new int[5];
                    foreach (var resposta in QuestionarioEstaticos.respostas[i])
                    {
                        if (resposta >= 1 && resposta <= 5)
                        {
                            contador[resposta - 1]++;
                        }
                    }

                    // Adiciona as respostas lado a lado na mesma linha
                    for (int j = 0; j < contador.Length; j++)
                    {
                        respostaFormatada.Append($" {opcoes[j]}: {contador[j]}  |  ");
                    }
                }

                relatorio.Add(respostaFormatada.ToString());
            }

            return relatorio;
        }
    }
}
