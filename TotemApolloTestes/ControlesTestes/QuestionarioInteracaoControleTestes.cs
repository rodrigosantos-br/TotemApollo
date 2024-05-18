using TotemApollo.Controles;
using System.Windows.Forms;
using System.Drawing;

namespace TotemApolloTestes.ControlesTestes
{
    public class QuestionarioInteracaoControleTestes
    {
        [Fact]
        public void ExibirProximaPergunta_DeveAvancarParaAPrximaPergunta()
        {
            // Arrange
            var botoesResposta = new List<Button>
            {
                new Button(),
                new Button(),
                new Button(),
                new Button()
            };
            var controle = new QuestionarioInteracaoControle(botoesResposta);
            var lblPergunta = new Label();

            // Act
            controle.ExibirProximaPergunta(lblPergunta);

            // Assert
            Assert.Equal(1, controle.IndicePerguntaAtual); // Verifica se o índice foi incrementado
            Assert.NotEmpty(lblPergunta.Text); // Verifica se a pergunta atual foi exibida
        }

        [Fact]
        public void VerificarResposta_DeveMarcarRespostaCorretaComVerde()
        {
            // Arrange
            var botoesResposta = new List<Button>
            {
                new Button() { Text = "A" },
                new Button() { Text = "B" },
                new Button() { Text = "C" },
                new Button() { Text = "D" }
            };
            var controle = new QuestionarioInteracaoControle(botoesResposta);
            var botaoResposta = botoesResposta[2]; // Resposta correta é a terceira (índice 2)
            controle.IndicePerguntaAtual = 2; // Definindo o índice da pergunta atual
            string respostaUsuario = "C";

            // Act
            controle.VerificarResposta(respostaUsuario, botaoResposta);

            // Assert
            Assert.Equal(Color.Green, botaoResposta.BackColor); // Verifica se a cor de fundo do botão é verde
        }

        [Fact]
        public void VerificarResposta_DeveMarcarRespostaIncorretaComVermelho()
        {
            // Arrange
            var botoesResposta = new List<Button>
            {
                new Button() { Text = "A" },
                new Button() { Text = "B" },
                new Button() { Text = "C" },
                new Button() { Text = "D" }
            };
            var controle = new QuestionarioInteracaoControle(botoesResposta);
            var botaoResposta = botoesResposta[1]; // Resposta incorreta é a segunda (índice 1)
            controle.IndicePerguntaAtual = 3; // Definindo o índice da pergunta atual
            string respostaUsuario = "B";

            // Act
            controle.VerificarResposta(respostaUsuario, botaoResposta);

            // Assert
            Assert.Equal(Color.Red, botaoResposta.BackColor); // Verifica se a cor de fundo do botão é vermelho
        }

        [Fact]
        public void ValidarRespostas_DeveRetornarTrueSeAlgumaRespostaFoiSelecionada()
        {
            // Arrange
            var botoesResposta = new List<Button>
            {
                new Button() { BackColor = Color.Green }, // Simula uma resposta selecionada
                new Button() { BackColor = SystemColors.Control }, // Simula uma resposta não selecionada
                new Button() { BackColor = SystemColors.Control }, // Simula uma resposta não selecionada
                new Button() { BackColor = SystemColors.Control } // Simula uma resposta não selecionada
            };
            var controle = new QuestionarioInteracaoControle(botoesResposta);

            // Act
            var resultado = controle.ValidarRespostas();

            // Assert
            Assert.True(resultado); // Deve retornar true, pois pelo menos uma resposta foi selecionada
        }

        [Fact]
        public void ValidarRespostas_DeveRetornarFalseSeNenhumaRespostaFoiSelecionada()
        {
            // Arrange
            var botoesResposta = new List<Button>
            {
                new Button() { BackColor = SystemColors.Control }, // Simula uma resposta não selecionada
                new Button() { BackColor = SystemColors.Control }, // Simula uma resposta não selecionada
                new Button() { BackColor = SystemColors.Control }, // Simula uma resposta não selecionada
                new Button() { BackColor = SystemColors.Control } // Simula uma resposta não selecionada
            };
            var controle = new QuestionarioInteracaoControle(botoesResposta);

            // Act
            var resultado = controle.ValidarRespostas();

            // Assert
            Assert.False(resultado); // Deve retornar false, pois nenhuma resposta foi selecionada
        }
    }
}
