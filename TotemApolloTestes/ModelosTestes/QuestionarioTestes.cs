using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotemApollo.Modelos;

namespace TotemApolloTestes.Modelos
{
    public class QuestionarioTestes
    {
        

        [Fact]
        public void TestarAdicionarResposta_ComIndiceInvalido()
        {
            // Arrange
            var questionario = new Questionario();
            int indicePerguntaInvalido = -1;
            int resposta = 4;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => questionario.AdicionarResposta(indicePerguntaInvalido, resposta));
        }

        [Fact]
        public void TestarCalcularPorcentagens()
        {
            // Arrange
            var questionario = new Questionario();
            // Adicionar algumas respostas ao questionário
            questionario.AdicionarResposta(0, 1);
            questionario.AdicionarResposta(1, 2);
            questionario.AdicionarResposta(2, 3);
            questionario.AdicionarResposta(3, 4);
            questionario.AdicionarResposta(4, 5);
            questionario.AdicionarResposta(0, 1);
            questionario.AdicionarResposta(1, 2);
            questionario.AdicionarResposta(2, 3);
            questionario.AdicionarResposta(3, 4);
            questionario.AdicionarResposta(4, 5);

            // Act
            var porcentagens = questionario.CalcularPorcentagens();

            // Assert
            Assert.NotNull(porcentagens);
            Assert.Equal(5, porcentagens.Count); // Deve haver uma porcentagem para cada opção de resposta
            Assert.Equal(20.0, porcentagens[0]); // 2 respostas para a opção 1 (20%)
            Assert.Equal(20.0, porcentagens[1]); // 2 respostas para a opção 2 (20%)
            Assert.Equal(20.0, porcentagens[2]); // 2 respostas para a opção 3 (20%)
            Assert.Equal(20.0, porcentagens[3]); // 2 respostas para a opção 4 (20%)
            Assert.Equal(20.0, porcentagens[4]); // 2 respostas para a opção 5 (20%)
        }

        [Fact]
        public void TestarIncrementarContadorInteracoes()
        {
            // Arrange
            var questionario = new Questionario();
            int contadorInicial = questionario.ContadorInteracoes;

            // Act
            questionario.IncrementarContadorInteracoes();

            // Assert
            Assert.Equal(contadorInicial + 1, questionario.ContadorInteracoes);
        }
    }
}
