namespace TotemApollo.Modelos
{
    public class Questionario
    {
        protected List<string> perguntas;

        public Questionario()
        {
            
        }

        public void AdicionarResposta(int indicePergunta, int resposta)
        {
            if (indicePergunta >= 0 && indicePergunta < perguntas.Count)
            {
                QuestionarioEstaticos.respostas[indicePergunta].Add(resposta);
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


        public void IncrementarContadorInteracoes()
        {
            QuestionarioEstaticos.contadorInteracoes++;
        }

        public void DecrementarContadorInteracoes()
        {
            QuestionarioEstaticos.contadorInteracoes--;
        }

        public int ContadorInteracoes => QuestionarioEstaticos.contadorInteracoes;
    }
}
