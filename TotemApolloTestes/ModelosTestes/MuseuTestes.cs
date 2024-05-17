using System;
using System.Collections.Generic;
using System.Drawing;
using Xunit;
using TotemApollo.Modelos;

namespace TotemApollo.Tests
{
    public class MuseuTests
    {
        [Fact]
        public void ObraAtual_DeveRetornarPrimeiraObra_Inicialmente()
        {
            // Arrange
            var museu = new Museu();

            // Act
            var obraAtual = museu.ObraAtual();

            // Assert
            Assert.Equal("A Grande Jornada Lunar", obraAtual.Titulo);
        }

        [Fact]
        public void AvancarParaProximaObra_DeveAvancarParaProximaObra()
        {
            // Arrange
            var museu = new Museu();

            // Act
            museu.AvancarParaProximaObra();
            var obraAtual = museu.ObraAtual();

            // Assert
            Assert.Equal("A Pioneira Apollo 11", obraAtual.Titulo);
        }

        [Fact]
        public void AvancarParaProximaObra_DeveVoltarParaPrimeiraObra_QuandoPassarUltimaObra()
        {
            // Arrange
            var museu = new Museu();

            // Act
            for (int i = 0; i < 4; i++)
            {
                museu.AvancarParaProximaObra();
            }
            var obraAtual = museu.ObraAtual();

            // Assert
            Assert.Equal("A Grande Jornada Lunar", obraAtual.Titulo);
        }

        [Fact]
        public void RetrocederParaObraAnterior_DeveRetrocederParaObraAnterior()
        {
            // Arrange
            var museu = new Museu();
            museu.AvancarParaProximaObra();

            // Act
            museu.RetrocederParaObraAnterior();
            var obraAtual = museu.ObraAtual();

            // Assert
            Assert.Equal("A Grande Jornada Lunar", obraAtual.Titulo);
        }

        [Fact]
        public void RetrocederParaObraAnterior_DeveIrParaUltimaObra_QuandoEstiverNaPrimeiraObra()
        {
            // Arrange
            var museu = new Museu();

            // Act
            museu.RetrocederParaObraAnterior();
            var obraAtual = museu.ObraAtual();

            // Assert
            Assert.Equal("Legado Lunar", obraAtual.Titulo);
        }

        [Fact]
        public void CadastrarVisitante_DeveAdicionarVisitante()
        {
            // Arrange
            var museu = new Museu();

            // Act
            museu.CadastrarVisitante("João", "2000-01-01");
            var quantidadeVisitantes = museu.ObterQuantidadeDeVisitantes();

            // Assert
            Assert.Equal(1, quantidadeVisitantes);
        }

        [Fact]
        public void RemoverUltimoVisitante_DeveRemoverVisitante()
        {
            // Arrange
            var museu = new Museu();
            museu.CadastrarVisitante("João", "2000-01-01");

            // Act
            museu.RemoverUltimoVisitante();
            var quantidadeVisitantes = museu.ObterQuantidadeDeVisitantes();

            // Assert
            Assert.Equal(0, quantidadeVisitantes);
        }

        [Fact]
        public void ExibirHistoricoObraAtual_DeveRetornarHistoricoCorreto()
        {
            // Arrange
            var museu = new Museu();

            // Act
            var historico = museu.ExibirHistoricoObraAtual();

            // Assert
            Assert.Contains("A Grande Jornada Lunar", historico);
        }

        [Fact]
        public void ExibirHistoricoObra_DeveRetornarMensagem_QuandoObraNaoExistir()
        {
            // Arrange
            var museu = new Museu();

            // Act
            var historico = museu.ExibirHistoricoObra(999);

            // Assert
            Assert.Equal("Obra não encontrada no museu.", historico);
        }
    }
}
