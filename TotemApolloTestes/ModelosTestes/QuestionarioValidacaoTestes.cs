using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotemApollo.Modelos;

namespace TotemApolloTestes.Modelos
{
    public class QuestionarioValidacaoTestes
    {
        [Fact]
        public void TestarValidarRespostas_ComTodasRespondidas()
        {
            // Arrange
            var validacao = new QuestionarioValidacao();
            var respostas = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            var resultado = validacao.ValidarRespostas(respostas);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void TestarValidarRespostas_ComAlgumaNaoRespondida()
        {
            // Arrange
            var validacao = new QuestionarioValidacao();
            var respostas = new List<int> { 1, 2, -1, 4, 5 };

            // Act
            var resultado = validacao.ValidarRespostas(respostas);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TestarValidarRespostas_ComTodasNaoRespondidas()
        {
            // Arrange
            var validacao = new QuestionarioValidacao();
            var respostas = new List<int> { -1, -1, -1, -1, -1 };

            // Act
            var resultado = validacao.ValidarRespostas(respostas);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TestarValidarRespostas_ComListaVazia()
        {
            // Arrange
            var validacao = new QuestionarioValidacao();
            var respostas = new List<int>();

            // Act
            var resultado = validacao.ValidarRespostas(respostas);

            // Assert
            Assert.False(resultado);
        }
    }
}
