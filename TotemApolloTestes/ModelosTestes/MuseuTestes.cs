using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotemApollo.Modelos;

namespace TotemApolloTestes.Modelos
{
    public class MuseuTestes
    {
        [Fact]
        public void TestarCadastrarVisitante()
        {
            // Arrange
            var museu = new Museu();

            // Act
            museu.CadastrarVisitante("João", "01/01/1980");

            // Assert
            Assert.Equal(1, museu.ObterQuantidadeDeVisitantes());
        }

        [Fact]
        public void TestarExibirHistoricoObra_QuandoObraExiste()
        {
            // Arrange
            var museu = new Museu();
            int idObraExistente = 1;

            // Act
            string historico = museu.ExibirHistoricoObra(idObraExistente);

            // Assert
            Assert.Contains("Titulo1", historico);
            Assert.Contains("Historico1", historico);
        }

        [Fact]
        public void TestarExibirHistoricoObra_QuandoObraNaoExiste()
        {
            // Arrange
            var museu = new Museu();
            int idObraInexistente = 999;

            // Act
            string mensagem = museu.ExibirHistoricoObra(idObraInexistente);

            // Assert
            Assert.Equal("Obra não encontrada no museu.", mensagem);
        }
    }
}
