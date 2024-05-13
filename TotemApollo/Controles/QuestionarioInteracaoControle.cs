using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotemApollo.Modelos;

namespace TotemApollo.Controles
{
    internal class QuestionarioInteracaoControle
    {
        private readonly QuestionarioInteracao questionarioInteracao;
        private readonly QuestionarioValidacao validacao;
        private int indicePerguntaAtual;
        private List<Button> botoesResposta;

        public QuestionarioInteracaoControle(List<Button> botoesResposta)
        {
            questionarioInteracao = new QuestionarioInteracao();
            validacao = new QuestionarioValidacao();
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
            return validacao.ValidarRespostas(botoesResposta);
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
                ExibirProximaPergunta(lblPergunta);
            }
        }

        public void VerificarResposta(string respostaUsuario, Button botaoResposta)
        {
            // Verifica se a resposta do usuário está correta
            bool respostaCorreta = questionarioInteracao.VerificarResposta(IndicePerguntaAtual - 1, respostaUsuario);

            // Atualiza a cor dos botões de resposta
            for (int i = 0; i < botoesResposta.Count; i++)
            {
                // Se for a resposta do usuário, muda a cor de acordo com a correção
                if (botoesResposta[i].Text.ToUpper() == respostaUsuario.ToUpper())
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

        public int IndicePerguntaAtual { get => indicePerguntaAtual; set => indicePerguntaAtual = value; }
    }
}
