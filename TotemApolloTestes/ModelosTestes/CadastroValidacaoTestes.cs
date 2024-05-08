using TotemApollo.Modelos;
namespace TotemApolloTestes.Modelos
{
    public class CadastroValidacaoTestes
    {
        [Fact]
        public void ValidarNome_DeveRetornarMensagemCorreta_QuandoNomeVazio()
        {
            // Arrange
            string nome = "";
            string dataNascimento = "01/01/2000";
            string mensagemEsperada = " Nome não pode ser vazio. ";

            // Act
            var cadastro = new CadastroValidacao(nome, dataNascimento);
            var mensagemNome = cadastro.MensagemNome;

            // Assert
            Assert.Equal(mensagemEsperada, mensagemNome);
        }

        [Fact]
        public void ValidarNome_DeveRetornarMensagemCorreta_QuandoNomeCurto()
        {
            // Arrange
            string nome = "Jo";
            string dataNascimento = "01/01/2000";
            string mensagemEsperada = " Nome deve ter entre 3 e 20 caracteres. ";

            // Act
            var cadastro = new CadastroValidacao(nome, dataNascimento);
            var mensagemNome = cadastro.MensagemNome;

            // Assert
            Assert.Equal(mensagemEsperada, mensagemNome);
        }

        [Fact]
        public void ValidarDataNascimento_DeveRetornarMensagemCorreta_QuandoDataNascimentoVazia()
        {
            // Arrange
            string nome = "João";
            string dataNascimento = "";
            string expectedMensagem = "Data de nascimento não pode ser vazia.";

            // Act
            var cadastro = new CadastroValidacao(nome, dataNascimento);
            var mensagemDataNascimento = cadastro.MensagemDataNascimento;

            // Assert
            Assert.Equal(expectedMensagem, mensagemDataNascimento);
        }
    }
}