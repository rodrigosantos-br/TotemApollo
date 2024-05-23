using TotemApollo.Modelos;

namespace TotemApollo.Controles
{
    public class QuestionarioInteracaoControle
    {
        private readonly QuestionarioInteracao questionarioInteracao;
        private int indicePerguntaAtual;
        private readonly List<Button> botoesResposta;

        public QuestionarioInteracaoControle(List<Button> botoesResposta)
        {
            questionarioInteracao = new QuestionarioInteracao();
            IndicePerguntaAtual = 0;
            this.botoesResposta = botoesResposta;
        }

        // Método para obter o número de perguntas
        public int ObterNumeroPerguntas()
        {
            return questionarioInteracao.ObterNumeroPerguntas();
        }

        public bool ValidarRespostas()
        {
            return QuestionarioValidacao.ValidarRespostas(botoesResposta);
        }
        public void MostrarExplicacaoResposta(Label labelExplicacao)
        {
            int indicePerguntaAtual = IndicePerguntaAtual - 1; // Obtém o índice da pergunta atual
            string explicacao = questionarioInteracao.ObterExplicacaoRespostaCorreta(indicePerguntaAtual).ToString();
            labelExplicacao.Text = explicacao;
        }

        public void ExibirPerguntaAnterior(Label lblPergunta)
        {
            // Decrementa o índice da pergunta atual
            IndicePerguntaAtual--;

            // Verifica se o índice da pergunta atual é maior ou igual a zero
            if (IndicePerguntaAtual >= 0)
            {
                // Exibe a pergunta correspondente ao novo índice
                lblPergunta.Text = questionarioInteracao.ObterPergunta(IndicePerguntaAtual);

                // Atualiza os botões de resposta
                for (int i = 0; i < botoesResposta.Count; i++)
                {
                    botoesResposta[i].Text = questionarioInteracao.ObterRespostaPorIndice(IndicePerguntaAtual, i);
                    botoesResposta[i].BackColor = SystemColors.Control; // Reseta a cor de fundo para a cor padrão
                }
            }
            else
            {
                // Se o índice da pergunta atual for menor que zero, não há pergunta anterior, então mantém o índice atual como zero
                IndicePerguntaAtual = 0;
            }
        }


        public void DecrementarContadoresPorResposta(int indicePergunta)
        {
            questionarioInteracao.DecrementarContadoresPorResposta(indicePergunta);
        }

        public void ExibirProximaPergunta(Label lblPergunta)
        {
            if (IndicePerguntaAtual < questionarioInteracao.ObterNumeroPerguntas())
            {
                lblPergunta.Text = questionarioInteracao.ObterPergunta(IndicePerguntaAtual);

                // Atualiza os botões de resposta
                for (int i = 0; i < botoesResposta.Count; i++)
                {
                    botoesResposta[i].Text = questionarioInteracao.ObterRespostaPorIndice(IndicePerguntaAtual, i);
                    botoesResposta[i].BackColor = SystemColors.Control; // Reseta a cor de fundo para a cor padrão
                }
                IndicePerguntaAtual++;
            }
            else
            {
                // Reinicia o índice da pergunta atual para exibir a primeira pergunta quando não houver mais perguntas disponíveis
                IndicePerguntaAtual = 0;

                ExibirProximaPergunta(lblPergunta); // Chama ExibirProximaPergunta recursivamente
            }
        }

        public void ResetarContadorVisitanteAtual()
        {
            questionarioInteracao.ResetarContadoresVisitanteAtual();
        }


        public void VerificarResposta(string respostaUsuario, Button botaoResposta)
        {
            ArgumentNullException.ThrowIfNull(botaoResposta);
            // Verifica se a resposta do usuário está correta
            bool respostaCorreta = questionarioInteracao.VerificarResposta(IndicePerguntaAtual - 1, respostaUsuario);

            // Atualiza a cor dos botões de resposta
            for (int i = 0; i < botoesResposta.Count; i++)
            {
                // Se for a resposta do usuário, muda a cor de acordo com a correção
                if (botoesResposta[i].Text.Equals(respostaUsuario, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (respostaCorreta)
                    {
                        // Resposta correta em verde
                        botoesResposta[i].BackColor = Color.Green;
                    }
                    else
                    {
                        // Resposta incorreta em vermelho
                        botoesResposta[i].BackColor = Color.Red;
                    }
                }
                else
                {
                    // Respostas não selecionadas voltam à cor padrão
                    botoesResposta[i].BackColor = SystemColors.Control;
                }
            }
        }

        public string ExibirRelatorioInteracao()
        {
            return questionarioInteracao.ExibirRelatorioInteracao();
        }

        public int IndicePerguntaAtual { get => indicePerguntaAtual; set => indicePerguntaAtual = value; }
    }
}
