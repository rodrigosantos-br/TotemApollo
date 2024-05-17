using TotemApollo.Controles;
using TotemApollo.Modelos;

public class CadastroControleTestes
{
    [Fact]
    public void Construtor_DadosValidos_DeveCadastrarVisitante()
    {
        // Arrange
        string nome = "Fulano de Tal";
        string dataNascimento = "1980-01-01";

        // Act
        var cadastroControle = new CadastroControle(nome, dataNascimento);

        // Assert
        Assert.True(cadastroControle.Mensagem == "");
    }

    [Theory]
    [InlineData("João", "1990-01-01")]
    [InlineData("Maria", "2000-12-31")]
    public void ValidarNome_EDataNascimentoValidos_DeveRetornarMensagensVazias(string nome, string dataNascimento)
    {
        // Arrange
        var validacao = new CadastroValidacao(nome, dataNascimento);

        // Act
        string mensagemNome = validacao.MensagemNome;
        string mensagemDataNascimento = validacao.MensagemDataNascimento;

        // Assert
        Assert.Empty(mensagemNome);
        Assert.Empty(mensagemDataNascimento);
    }
}
