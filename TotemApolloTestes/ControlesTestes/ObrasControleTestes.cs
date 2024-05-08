using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotemApollo.Controles;

namespace TotemApolloTestes.ControlesTestes
{
    public class ObrasControleTestes
    {
        [Fact]
        public void TestarExibirHistoricoObra_ComObraExistente()
        {
            // Arrange
            var obrasControle = new ObrasControle();
            int idObraExistente = 1;
            string historicoEsperado = "Título: Titulo1\nHistórico: Historico1";

            // Act
            var historicoObra = obrasControle.ExibirHistoricoObra(idObraExistente);

            // Assert
            Assert.Equal(historicoEsperado, historicoObra);
        }

        [Fact]
        public void TestarExibirHistoricoObra_ComObraInexistente()
        {
            // Arrange
            var obrasControle = new ObrasControle();
            int idObraInexistente = 10;
            string mensagemEsperada = "Obra não encontrada no museu.";

            // Act
            var historicoObra = obrasControle.ExibirHistoricoObra(idObraInexistente);

            // Assert
            Assert.Equal(mensagemEsperada, historicoObra);
        }
    }
}
