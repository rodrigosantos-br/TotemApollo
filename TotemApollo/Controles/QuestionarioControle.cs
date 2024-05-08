using System.Windows.Forms;
using TotemApollo.Modelos;

namespace TotemApollo.Controles
{
    public class QuestionarioControle
    {
        private Questionario questionario;
        private QuestionarioValidacao validacao;

        public QuestionarioControle()
        {
            questionario = new Questionario();
            validacao = new QuestionarioValidacao();
        }

        public List<double> ObterPorcentagens()
        {
            return questionario.CalcularPorcentagens();
        }

        public List<string> ObterPerguntas()
        {
            return questionario.ObterPerguntas();
        }

        public void AdicionarRespostas(int indicePergunta, int resposta)
        {
            questionario.AdicionarResposta(indicePergunta, resposta);
        }


        public bool ValidarRespostas(List<int> respostas)
        {
            return validacao.ValidarRespostas(respostas);
        }

        // Método para obter a resposta para uma pergunta específica
        private int ObterRespostaParaPergunta(params RadioButton[] opcoes)
        {
            for (int i = 0; i < opcoes.Length; i++)
            {
                if (opcoes[i].Checked)
                {
                    return i + 1; // Retorna o número da opção (começando em 1)
                }
            }
            return -1; // Retorna -1 se nenhuma opção estiver selecionada
        }

        // Método para obter o número total de interações
        public void IncrementarContadorInteracoes()
        {
            questionario.IncrementarContadorInteracoes();
        }

        // Método para desativar outros CheckBoxes
        public void DesativarOutrosCheckBoxes(CheckBox checkBox)
        {
            foreach (Control control in Application.OpenForms[0].Controls) // Aqui você pode especificar qual formulário está em foco
            {
                if (control is CheckBox chk && chk != checkBox)
                {
                    chk.Enabled = false;
                }
            }
        }

        // Método para habilitar todos os CheckBoxes
        public void HabilitarCheckBoxes()
        {
            foreach (Control control in Application.OpenForms[0].Controls) // Aqui você pode especificar qual formulário está em foco
            {
                if (control is CheckBox chk)
                {
                    chk.Enabled = true;
                }
            }
        }

        // Método para obter o número total de interações
        public int ObterContadorInteracoes()
        {
            return questionario.ContadorInteracoes;
        }

        public List<int> ObterRespostasDoFormulario(params RadioButton[][] opcoes)
        {
            List<int> respostas = new List<int>();

            foreach (var pergunta in opcoes)
            {
                respostas.Add(ObterRespostaParaPergunta(pergunta));
            }
            return respostas;
        }

        // Método para obter o relatório cumulativo das respostas
        public List<string> ObterRelatorioCumulativo()
        {
            return questionario.ObterRelatorioCumulativo();
        }
    }
}