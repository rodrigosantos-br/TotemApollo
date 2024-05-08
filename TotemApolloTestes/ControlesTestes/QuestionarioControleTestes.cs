using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotemApollo.Controles;

namespace TotemApolloTestes.ControlesTestes
{
    public class QuestionarioControleTestes
    {
        [Fact]
        public void TestarObterPorcentagens()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();

            // Act
            var porcentagens = questionarioControle.ObterPorcentagens();

            // Assert
            Assert.NotNull(porcentagens);
            Assert.Equal(5, porcentagens.Count); // Verificar se há 5 porcentagens (para 5 perguntas)
        }

        [Fact]
        public void TestarObterPerguntas()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();

            // Act
            var perguntas = questionarioControle.ObterPerguntas();

            // Assert
            Assert.NotNull(perguntas);
            Assert.Equal(5, perguntas.Count); // Verificar se há 5 perguntas
        }

        [Fact]
        public void TestarAdicionarRespostas_ComTodasPerguntasRespondidas()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();

            // Act
            questionarioControle.AdicionarRespostas(0, 3);
            questionarioControle.AdicionarRespostas(1, 4);
            questionarioControle.AdicionarRespostas(2, 5);
            questionarioControle.AdicionarRespostas(3, 2);
            questionarioControle.AdicionarRespostas(4, 1);

            // Assert
            var porcentagens = questionarioControle.ObterPorcentagens();
            Assert.Equal(20.0, porcentagens[0]); // 20% das respostas são 3
            Assert.Equal(20.0, porcentagens[1]); // 20% das respostas são 4
            Assert.Equal(20.0, porcentagens[2]); // 20% das respostas são 5
            Assert.Equal(20.0, porcentagens[3]); // 20% das respostas são 2
            Assert.Equal(20.0, porcentagens[4]); // 20% das respostas são 1
        }


        [Fact]
        public void TestarValidarRespostas_ComRespostasValidas()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();
            var respostas = new List<int> { 3, 4, 5, 2, 1 }; // Todas as respostas são válidas (de 1 a 5)

            // Act
            var resultadoValidacao = questionarioControle.ValidarRespostas(respostas);

            // Assert
            Assert.True(resultadoValidacao);
        }

        [Fact]
        public void TestarValidarRespostas_ComPerguntaNaoRespondida()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();
            var respostas = new List<int> { 3, 4, -1, 2, 1 }; // Uma pergunta não foi respondida (valor -1)

            // Act
            var resultadoValidacao = questionarioControle.ValidarRespostas(respostas);

            // Assert
            Assert.False(resultadoValidacao);
        }

        [Fact]
        public void TestarObterContadorInteracoes()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();

            // Act
            var contadorInteracoesInicial = questionarioControle.ObterContadorInteracoes();
            questionarioControle.IncrementarContadorInteracoes();
            var contadorInteracoesDepois = questionarioControle.ObterContadorInteracoes();

            // Assert
            Assert.Equal(0, contadorInteracoesInicial); // O contador deve iniciar em 0
            Assert.Equal(1, contadorInteracoesDepois); // Após incrementar, o contador deve ser 1
        }

        [Fact]
        public void TestarObterRespostasDoFormulario_ComTodosSelecionados()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();
            var radioButton1 = new RadioButton() { Checked = true };
            var radioButton2 = new RadioButton() { Checked = true };
            var radioButton3 = new RadioButton() { Checked = true };
            var radioButton4 = new RadioButton() { Checked = true };
            var radioButton5 = new RadioButton() { Checked = true };

            // Act
            var respostas = questionarioControle.ObterRespostasDoFormulario(
                new RadioButton[] { radioButton1 },
                new RadioButton[] { radioButton2 },
                new RadioButton[] { radioButton3 },
                new RadioButton[] { radioButton4 },
                new RadioButton[] { radioButton5 }
            );

            // Assert
            Assert.NotNull(respostas);
            Assert.Equal(5, respostas.Count); // Deve haver uma resposta para cada pergunta
            Assert.Equal(1, respostas[0]); // A primeira pergunta tem resposta 1
            Assert.Equal(1, respostas[1]); // A segunda pergunta tem resposta 1
            Assert.Equal(1, respostas[2]); // A terceira pergunta tem resposta 1
            Assert.Equal(1, respostas[3]); // A quarta pergunta tem resposta 1
            Assert.Equal(1, respostas[4]); // A quinta pergunta tem resposta 1
        }


        [Fact]
        public void TestarObterRelatorioCumulativo()
        {
            // Arrange
            var questionarioControle = new QuestionarioControle();

            // Act
            var relatorio = questionarioControle.ObterRelatorioCumulativo();

            // Assert
            Assert.NotNull(relatorio);
            Assert.NotEmpty(relatorio); // O relatório não deve estar vazio
            // Você pode adicionar mais verificações específicas ao conteúdo do relatório, se necessário
        }
    }
}
