using TotemApollo.Modelos;

namespace TotemApollo.Controles
{
    public class QuestionarioControle
    {
        private readonly Questionario questionario;
        private readonly QuestionarioValidacao validacao;
        private int indicePerguntaAtual;


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

        public List<int> ObterRespostasDoFormulario(params CheckBox[][] opcoes)
        {
            List<int> respostas = [];

            foreach (var pergunta in opcoes)
            {
                respostas.Add(ObterRespostaParaPergunta(pergunta));
            }
            return respostas;
        }

        private int ObterRespostaParaPergunta(params CheckBox[] opcoes)
        {
            foreach (var opcao in opcoes)
            {
                if (opcao.Checked)
                {
                    // Você pode atribuir um valor específico para cada opção ou usar o índice da opção na matriz
                    return Array.IndexOf(opcoes, opcao) + 1;
                }
            }
            // Se nenhuma opção estiver selecionada, retorna -1 ou outro valor de sua escolha para indicar que não há resposta selecionada
            return -1;
        }

        public void IncrementarContadorInteracoes()
        {
            questionario.IncrementarContadorInteracoes();
        }

        public void DecrementarContadorInteracoes()
        {
            questionario.DecrementarContadorInteracoes();
        }


        public int ObterContadorInteracoes()
        {
            return questionario.ContadorInteracoes;
        }

        public List<string> ObterRelatorioCumulativo()
        {
            return questionario.ObterRelatorioCumulativo();
        }

        public void DesmarcarOutrosCheckBoxes(CheckBox checkBox)
        {
            foreach (Control control in Application.OpenForms[0].Controls)
            {
                if (control is CheckBox chk && chk != checkBox)
                {
                    chk.Checked = false; // Define o estado de seleção como falso
                }
            }
        }

        public void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == null) return;

            if (checkBox.Checked)
            {

                // Lógica para manipular a imagem do CheckBox
                switch (checkBox.Name)
                {
                    case "chkPessimo":
                        checkBox.BackgroundImage = Properties.Resources.estrelaPessimo;
                        DesmarcarOutrosCheckBoxes(checkBox);
                        break;
                    case "chkRuim":
                        checkBox.BackgroundImage = Properties.Resources.estrelaRuim;
                        DesmarcarOutrosCheckBoxes(checkBox);
                        break;
                    case "chkRegular":
                        checkBox.BackgroundImage = Properties.Resources.estrelaRegular;
                        DesmarcarOutrosCheckBoxes(checkBox);
                        break;
                    case "chkBom":
                        checkBox.BackgroundImage = Properties.Resources.estrelaBom;
                        DesmarcarOutrosCheckBoxes(checkBox);
                        break;
                    case "chkOtimo":
                        checkBox.BackgroundImage = Properties.Resources.estrelaOtimo;
                        DesmarcarOutrosCheckBoxes(checkBox);
                        break;
                    default:
                        // Se não corresponder a nenhum nome conhecido, não faz nada
                        break;
                }
            }
            else
            {
                // Define a imagem para o estado cinza quando não estiver selecionado
                switch (checkBox.Name)
                {
                    case "chkPessimo":
                        checkBox.BackgroundImage = Properties.Resources.estrelaPessimoCinza;
                        break;
                    case "chkRuim":
                        checkBox.BackgroundImage = Properties.Resources.estrelaRuimCinza;
                        break;
                    case "chkRegular":
                        checkBox.BackgroundImage = Properties.Resources.estrelaRegularCinza;
                        break;
                    case "chkBom":
                        checkBox.BackgroundImage = Properties.Resources.estrelaBomCinza;
                        break;
                    case "chkOtimo":
                        checkBox.BackgroundImage = Properties.Resources.estrelaOtimoCinza;
                        break;
                    default:
                        // Se não corresponder a nenhum nome conhecido, não faz nada
                        break;
                }
            }
        }
        public int IndicePerguntaAtual { get => indicePerguntaAtual; set => indicePerguntaAtual = value; }
    }
}
