using System.Windows.Forms;
using TotemApollo.Controles;

namespace TotemApollo.Testes
{
    public class QuestionarioSatisfacaoControleTestes
    {
        private readonly QuestionarioSatisfacaoControle controle;

        public QuestionarioSatisfacaoControleTestes()
        {
            controle = new QuestionarioSatisfacaoControle();
        }

        [Fact]
        public void TesteObterRespostasDoFormulario()
        {
            // Arrange
            var checkboxes1 = new[] { new CheckBox() { Checked = true }, new CheckBox() { Checked = false } };
            var checkboxes2 = new[] { new CheckBox() { Checked = false }, new CheckBox() { Checked = true } };
            var opcoes = new List<CheckBox[]> { checkboxes1, checkboxes2 };

            // Act
            var respostas = controle.ObterRespostasDoFormulario(opcoes);

            // Assert
            Assert.Equal([1, 2], respostas);
        }
    }
}
