using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotemApollo.Modelos;

namespace TotemApolloTestes.Modelos
{
    public class ObraTestes
    {
        [Fact]
        public void TestarConstrutor()
        {
            // Arrange
            int idEsperado = 1;
            string tituloEsperado = "Titulo";
            string historicoEsperado = "Historico";

            // Act
            var obra = new Obra(idEsperado, tituloEsperado, historicoEsperado);

            // Assert
            Assert.Equal(idEsperado, obra.Id);
            Assert.Equal(tituloEsperado, obra.Titulo);
            Assert.Equal(historicoEsperado, obra.Historico);
        }

        [Fact]
        public void TestarPropriedades()
        {
            // Arrange
            var obra = new Obra(1, "Titulo", "Historico");

            // Act
            obra.Id = 2;
            obra.Titulo = "Novo Titulo";
            obra.Historico = "Novo Historico";

            // Assert
            Assert.Equal(2, obra.Id);
            Assert.Equal("Novo Titulo", obra.Titulo);
            Assert.Equal("Novo Historico", obra.Historico);
        }
    }
}
