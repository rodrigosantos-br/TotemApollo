namespace TotemApollo.Modelos
{
    public class QuestionarioValidacao
    {
        // Método para validar se todas as questões foram respondidas
        public static bool ValidarRespostas(List<int> respostas)
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

        // Método para validar se pelo menos uma resposta foi selecionada
        public static bool ValidarRespostas(List<Button> botoesResposta)
        {
            foreach (Button botao in botoesResposta)
            {
                if (botao.BackColor != SystemColors.Control) // Se a cor de fundo do botão não for a padrão, significa que foi selecionado
                    return true;
            }
            return false; // Retorna false se nenhum botão foi selecionado
        }
    }
}
