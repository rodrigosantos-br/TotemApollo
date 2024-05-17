using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Xunit;
using TotemApollo.Modelos;

namespace TotemApollo.Testes
{
    public class QuestionarioValidacaoTestes
    {
        [Fact]
        public void TesteValidarRespostas_Int()
        {
            // Arrange
            var respostasVazias = new List<int>();
            var respostasPreenchidas = new List<int> { 1, 2, 3 };
            var respostasComNaoRespondidas = new List<int> { 1, -1, 3 };

            // Act
            var resultadoVazio = QuestionarioValidacao.ValidarRespostas(respostasVazias);
            var resultadoPreenchido = QuestionarioValidacao.ValidarRespostas(respostasPreenchidas);
            var resultadoNaoRespondidas = QuestionarioValidacao.ValidarRespostas(respostasComNaoRespondidas);

            // Assert
            Assert.False(resultadoVazio);
            Assert.True(resultadoPreenchido);
            Assert.False(resultadoNaoRespondidas);
        }

        [Fact]
        public void TesteValidarRespostas_Button()
        {
            // Arrange
            var botoesSemSelecao = new List<Button>
            {
                new Button { BackColor = SystemColors.Control },
                new Button { BackColor = SystemColors.Control }
            };
            var botoesComSelecao = new List<Button>
            {
                new Button { BackColor = Color.Red },
                new Button { BackColor = SystemColors.Control }
            };

            // Act
            var resultadoSemSelecao = QuestionarioValidacao.ValidarRespostas(botoesSemSelecao);
            var resultadoComSelecao = QuestionarioValidacao.ValidarRespostas(botoesComSelecao);

            // Assert
            Assert.False(resultadoSemSelecao);
            Assert.True(resultadoComSelecao);
        }
    }
}
