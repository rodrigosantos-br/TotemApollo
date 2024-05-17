using System.Windows.Forms;

namespace TotemApolloTestes.ControlesTestes
{
    public class TecladoControleTestes
    {
        [Fact]
        public void TestarEventoTeclaProcessada()
        {
            // Arrange
            var tecladoControle = new TotemApollo.TecladoControle();
            bool eventoDisparado = false;
            string teclaEsperada = "a";

            // Assinar o evento TeclaProcessada
            tecladoControle.TeclaProcessada += (sender, tecla) =>
            {
                eventoDisparado = true;
                Assert.Equal(teclaEsperada, tecla);
            };

            // Act - Simula o clique na tecla "A"
            var teclaButton = new Button
            {
                Text = "A"
            };
            tecladoControle.Tecla_Click(teclaButton, EventArgs.Empty);

            // Assert
            Assert.True(eventoDisparado, "O evento TeclaProcessada não foi disparado.");
        }
    }
}
