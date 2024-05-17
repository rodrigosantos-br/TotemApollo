using System;
using System.Collections.Generic;
using Xunit;
using TotemApollo.Modelos;

namespace TotemApollo.Tests
{
    public class QuestionarioSatisfacaoTests
    {
        [Fact]
        public void CalcularPorcentagens_DeveRetornarPorcentagensCorretas1()
        {
            // Arrange
            var questionario = new QuestionarioSatisfacao();

            // Simular respostas para testar o cálculo de porcentagens
            QuestionarioEstaticos.respostas.Clear();
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);

            // Act
            List<double> porcentagens = questionario.CalcularPorcentagens();

            // Assert
            Assert.Equal(5, porcentagens.Count);
            Assert.All(porcentagens, p => Assert.Equal(20.0, p));
        }

        [Fact]
        public void ObterRelatorioCumulativo_DeveRetornarRelatorioCorreto1()
        {
            // Arrange
            var questionario = new QuestionarioSatisfacao();

            // Simular respostas para testar o relatório cumulativo
            QuestionarioEstaticos.contadorInteracoes = 5;
            QuestionarioEstaticos.respostas.Clear();
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);
            QuestionarioEstaticos.respostas.Add([1, 2, 3, 4, 5]);

            // Act
            List<string> relatorio = questionario.ObterRelatorioCumulativo();

            // Assert
            Assert.Equal(6, relatorio.Count);
            Assert.Contains("Número Total de Visitantes: 5", relatorio[0]);
            Assert.Contains("Péssimo: 1", relatorio[1]);
            Assert.Contains("Ruim: 1", relatorio[1]);
            Assert.Contains("Regular: 1", relatorio[1]);
            Assert.Contains("Bom: 1", relatorio[1]);
            Assert.Contains("Ótimo: 1", relatorio[1]);
        }
    }
}
