
namespace TotemApollo.Modelos
{
    public class QuestionarioValidacao
    {
        // Método para validar se todas as questões foram respondidas
        public bool ValidarRespostas(List<int> respostas)
        {
            if (respostas.Count == 0)
            {
                return false; // Retorna false se a lista estiver vazia
            }

            foreach (int resposta in respostas)
            {
                if (resposta == -1) // Se a resposta for -1, significa que não foi respondida
                    return false;
            }
            return true;
        }
    }
}
