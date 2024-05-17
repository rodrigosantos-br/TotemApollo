using System;
using Xunit;
using TotemApollo.Modelos;
using System.Collections.Generic;

namespace TotemApollo.Tests
{
    public class QuestionarioInteracaoTests
    {
        [Fact]
        public void ObterPergunta_DeveRetornarPerguntaCorreta()
        {
            // Arrange
            var questionario = new QuestionarioInteracao();

            // Act
            string pergunta = questionario.ObterPergunta(0);

            // Assert
            Assert.Contains("Qual foi a data da primeira viagem à lua?", pergunta);
        }

        [Fact]
        public void ObterExplicacaoRespostaCorreta_DeveRetornarExplicacaoCorreta()
        {
            // Arrange
            var questionario = new QuestionarioInteracao();

            // Act
            string explicacao = questionario.ObterExplicacaoRespostaCorreta(0);

            // Assert
            Assert.Contains("A primeira viagem à Lua ocorreu em 20 de julho de 1969.", explicacao);
        }

        [Fact]
        public void ObterExplicacaoRespostaCorreta_DeveRetornarMensagemParaIndiceInvalido()
        {
            // Arrange
            var questionario = new QuestionarioInteracao();

            // Act
            string explicacao = questionario.ObterExplicacaoRespostaCorreta(5);

            // Assert
            Assert.Equal("Explicação não encontrada.", explicacao);
        }

        [Fact]
        public void ObterRespostaPorIndice_DeveRetornarRespostaCorreta()
        {
            // Arrange
            var questionario = new QuestionarioInteracao();

            // Act
            string resposta = questionario.ObterRespostaPorIndice(0, 2);

            // Assert
            Assert.Equal("C", resposta);
        }

        [Fact]
        public void VerificarResposta_DeveRetornarTrueParaRespostaCorreta()
        {
            // Arrange
            var questionario = new QuestionarioInteracao();

            // Act
            bool resultado = questionario.VerificarResposta(0, "C");

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void VerificarResposta_DeveRetornarFalseParaRespostaIncorreta()
        {
            // Arrange
            var questionario = new QuestionarioInteracao();

            // Act
            bool resultado = questionario.VerificarResposta(0, "A");

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void ExibirGabarito_DeveRetornarStringComTotais()
        {
            // Arrange
            var questionario = new QuestionarioInteracao();

            // Act
            questionario.VerificarResposta(0, "C");
            questionario.VerificarResposta(1, "A");
            string gabarito = questionario.ExibirGabarito();

            // Assert
            Assert.Contains("Total de acertos: 1", gabarito);
            Assert.Contains("Total de erros: 1", gabarito);
        }
    }
}
