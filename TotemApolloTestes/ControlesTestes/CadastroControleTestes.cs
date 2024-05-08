using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotemApollo.Controles;

namespace TotemApolloTestes.ControlesTestes
{
    public class CadastroControleTestes
    {
        [Fact]
        public void TestarCadastroControle_ComDadosValidos()
        {
            // Arrange
            string nome = "João";
            string dataNascimento = "01/01/1990";

            // Act
            var controle = new CadastroControle(nome, dataNascimento);

            // Assert
            Assert.Equal("", controle.Mensagem);
        }

        [Fact]
        public void TestarCadastroControle_ComNomeInvalido()
        {
            // Arrange
            string nome = "";
            string dataNascimento = "01/01/1990";

            // Act
            var controle = new CadastroControle(nome, dataNascimento);

            // Assert
            Assert.Contains("Não foi possível cadastrar o visitante. ", controle.Mensagem);
            Assert.Contains("Nome não pode ser vazio.", controle.Mensagem);
        }

        [Fact]
        public void TestarCadastroControle_ComDataNascimentoInvalida()
        {
            // Arrange
            string nome = "João";
            string dataNascimento = "";

            // Act
            var controle = new CadastroControle(nome, dataNascimento);

            // Assert
            Assert.Contains("Não foi possível cadastrar o visitante. ", controle.Mensagem);
            Assert.Contains("Data de nascimento não pode ser vazia.", controle.Mensagem);
        }
    }
}
