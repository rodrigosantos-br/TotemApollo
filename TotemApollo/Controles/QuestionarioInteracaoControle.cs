using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotemApollo.Modelos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TotemApollo.Controles
{
    internal class QuestionarioInteracaoControle
    {
        private readonly QuestionarioInteracao questionarioInteracao;
        private readonly QuestionarioValidacao validacao;
        private int indicePerguntaAtual;
        private List<Button> botoesResposta;
        
        private Dictionary<string, int> acumuladoRespostas;

        public QuestionarioInteracaoControle(List<Button> botoesResposta)
        {
            questionarioInteracao = new QuestionarioInteracao();
            validacao = new QuestionarioValidacao();
            IndicePerguntaAtual = 0;
            this.botoesResposta = botoesResposta;
            
            acumuladoRespostas = new Dictionary<string, int>();
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
                // Se o índice da pergunta atual for menor que zero, não há pergunta anterior, então mantenha o índice atual como zero
                IndicePerguntaAtual = 0;
            }
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
                
                // VerificarResposta(string.Empty, null); // Isso está causando o problema
                ExibirProximaPergunta(lblPergunta); // Chame ExibirProximaPergunta recursivamente
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

        public string ExibirGabarito()
        { 
            return questionarioInteracao.ExibirGabarito();
        }

        public int IndicePerguntaAtual { get => indicePerguntaAtual; set => indicePerguntaAtual = value; }
    }
}
