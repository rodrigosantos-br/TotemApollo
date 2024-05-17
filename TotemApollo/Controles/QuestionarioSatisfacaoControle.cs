using TotemApollo.Modelos;

namespace TotemApollo.Controles
{
    public class QuestionarioSatisfacaoControle
    {
        private readonly QuestionarioSatisfacao questionarioSatisfacao;
        private readonly QuestionarioValidacao validacao;
        private int indicePerguntaAtual;
        private List<CheckBox> checkboxes;
        
        public QuestionarioSatisfacaoControle()
        {
            questionarioSatisfacao = new QuestionarioSatisfacao();
            validacao = new QuestionarioValidacao();
            indicePerguntaAtual = 0;
        }

        public List<double> ObterPorcentagens()
        {
            return questionarioSatisfacao.CalcularPorcentagens();
        }

        public List<string> ObterPerguntas()
        {
            return questionarioSatisfacao.ObterPerguntas();
        }

        public void AdicionarRespostas(int indicePergunta, int resposta)
        {
            questionarioSatisfacao.AdicionarResposta(indicePergunta, resposta);
        }

        public static bool ValidarRespostas(List<int> respostas)
        {
            return QuestionarioValidacao.ValidarRespostas(respostas);
        }

        public void AdicionarRespostasDoFormulario(List<int> respostas)
        {
            // Verificar se o índice da pergunta está dentro dos limites
            if (indicePerguntaAtual < 0 || indicePerguntaAtual >= questionarioSatisfacao.ObterPerguntas().Count)
            {
                throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
            }

            // Adicionar as respostas ao questionário
            for (int i = 0; i < respostas.Count; i++)
            {
                // Verificar se o índice da pergunta + i está dentro dos limites
                int indice = indicePerguntaAtual + i;
                if (indice >= 0 && indice < questionarioSatisfacao.ObterPerguntas().Count)
                {
                    questionarioSatisfacao.AdicionarResposta(indice, respostas[i]);
                }
                else
                {
                    throw new IndexOutOfRangeException("O índice da pergunta está fora dos limites.");
                }
            }

            // Avançar para a próxima pergunta
            indicePerguntaAtual += respostas.Count;
        }

        public List<int> ObterRespostasDoFormulario(List<CheckBox[]> opcoes)
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
            questionarioSatisfacao.IncrementarContadorInteracoes();
        }

        public void DecrementarContadorInteracoes()
        {
            questionarioSatisfacao.DecrementarContadorInteracoes();
        }


        public int ObterContadorInteracoes()
        {
            return questionarioSatisfacao.ContadorInteracoes;
        }

        public List<string> ObterRelatorioCumulativo()
        {
            return questionarioSatisfacao.ObterRelatorioCumulativo();
        }

        public void MostrarProximaPergunta(Label labelPergunta, CheckBox[] checkboxes)
        {
            // Verificar se o índice da próxima pergunta está dentro do intervalo válido
            if (IndicePerguntaAtual >= 0 && IndicePerguntaAtual < ObterPerguntas().Count)
            {
                // Obter a próxima pergunta
                string proximaPergunta = ObterPerguntas()[IndicePerguntaAtual];

                // Atualizar o texto da pergunta no formulário
                labelPergunta.Text = proximaPergunta;

                // Redefinir todas as checkboxes para desmarcadas
                foreach (var checkbox in checkboxes)
                {
                    checkbox.Checked = false;
                }
            }
        }

        private void DesmarcarOutrosCheckBoxes(CheckBox checkBox)
        {
            foreach (var otherCheckBox in checkboxes)
            {
                if (otherCheckBox != checkBox)
                {
                    otherCheckBox.Checked = false;
                }
            }
        }

        public void AssociarCheckBoxes(List<CheckBox> checkboxes)
        {
            this.checkboxes = checkboxes;
            foreach (var checkBox in checkboxes)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
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
