using TotemApollo.Modelos;

namespace TotemApolloTestes.Modelos
{
    public class VisitanteTestes
    {
        [Fact]
        public void TestarConstrutor()
        {
            // Arrange
            string nomeEsperado = "João";
            string dataNascimentoEsperada = "01/01/1980";

            // Act
            var visitante = new Visitante(nomeEsperado, dataNascimentoEsperada);

            // Assert
            Assert.Equal(nomeEsperado, visitante.Nome);
            Assert.Equal(dataNascimentoEsperada, visitante.DataNascimento);
        }
    }
}
