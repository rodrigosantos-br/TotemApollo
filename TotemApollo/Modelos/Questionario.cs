using System.Text;

namespace TotemApollo.Modelos
{
    public class Questionario
    {
        // Lista de perguntas
        private List<string> perguntas;

        // Lista de respostas acumulativas
        public static List<List<int>> respostas;
        
        // Contador de interações
        private static int contadorInteracoes = 0;

        static Questionario()
        {
            respostas = new List<List<int>>();
        }

        public Questionario()
        {
            // Inicialize as perguntas
            perguntas = new List<string>()
        {
            "Como você classificaria a qualidade geral das exposições apresentadas?",
            "Qual é o seu nível de satisfação com a interatividade e engajamento proporcionado pelas exposições?",
            "Como você avaliaria a adequação do ambiente (iluminação, espaço, acessibilidade) da exposição?",
            "Como você avalia o conhecimento adquirido sobre o tema da exposição?",
            "Considerando sua experiência completa, qual é a probabilidade de você recomendar esta exposição a amigos e familiares?"
        };

            // Inicialize as listas de respostas para cada pergunta
            for (int i = 0; i < perguntas.Count; i++)
            {
                respostas.Add(new List<int>());
            }
        }

        // Adicionar respostas ao questionário
        public void AdicionarResposta(int indicePergunta, int resposta)
        {
            if (indicePergunta >= 0 && indicePergunta < perguntas.Count)
            {
                respostas[indicePergunta].Add(resposta);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(indicePergunta), "O índice da pergunta está fora dos limites.");
            }
        }

        public List<string> ObterPerguntas()
        {
            return perguntas;
        }

        // Calcular as porcentagens das respostas
        public List<double> CalcularPorcentagens()
        {
            List<double> porcentagens = new List<double>();

            // Total de respostas para cada opção
            int[] totalPorOpcao = new int[5];

            // Contar o número total de respostas para cada opção
            foreach (var resposta in respostas)
            {
                for (int i = 0; i < resposta.Count; i++)
                {
                    totalPorOpcao[resposta[i] - 1]++; // Incrementa o contador para a opção de resposta correspondente
                }
            }

            // Calcular a porcentagem para cada opção
            double totalRespostas = respostas.Sum(r => r.Count); // Total de todas as respostas
            foreach (int totalOpcao in totalPorOpcao)
            {
                double porcentagem = totalOpcao / totalRespostas * 100;
                porcentagens.Add(porcentagem);
            }

            return porcentagens;
        }

        // Método para obter o relatório cumulativo das respostas
        public List<string> ObterRelatorioCumulativo()
        {
            // Adicionar o número total de interações ao relatório
            List<string> relatorio = new List<string>
            {
                $"Número Total de Interações: {contadorInteracoes}"
            };

            // Iterar sobre todas as perguntas
            for (int i = 0; i < perguntas.Count; i++)
            {
                StringBuilder respostaFormatada = new StringBuilder();
                respostaFormatada.Append("\n").Append(perguntas[i]).Append(" \n");

                // Verificar se há respostas para esta pergunta na lista compartilhada
                if (i < respostas.Count)
                {
                    // Contagem das respostas
                    int[] contador = new int[5];
                    foreach (var resposta in respostas[i])
                    {
                        if (resposta >= 1 && resposta <= 5) // Verifica se a resposta está dentro do intervalo válido
                        {
                            contador[resposta - 1]++; // Subtrai 1 para ajustar ao índice do array
                        }
                    }

                    // Adicionar contagem ao relatório
                    for (int j = 0; j < contador.Length; j++)
                    {
                        respostaFormatada.Append($"\nOpção {j + 1}: {contador[j]} |");
                    }
                }
                // Adicionar a resposta formatada ao relatório
                relatorio.Add(respostaFormatada.ToString());
            }

            return relatorio;
        }

        public void IncrementarContadorInteracoes()
        {
            contadorInteracoes++;
        }

        public int ContadorInteracoes { get => contadorInteracoes; }
    }
}