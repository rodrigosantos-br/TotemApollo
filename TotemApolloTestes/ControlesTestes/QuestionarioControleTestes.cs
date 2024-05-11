using TotemApollo.Controles;

namespace TotemApolloTestes.ControlesTestes
{
    public class QuestionarioControleTestes
    {
        [Fact]
        public void TestarObterPorcentagens()
        {
            // Arrange
            var questionarioControle = new QuestionarioSatisfacaoControle();

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
            var questionarioControle = new QuestionarioSatisfacaoControle();

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
            var questionarioControle = new QuestionarioSatisfacaoControle();

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
            var questionarioControle = new QuestionarioSatisfacaoControle();
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
            var questionarioControle = new QuestionarioSatisfacaoControle();
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
            var questionarioControle = new QuestionarioSatisfacaoControle();

            // Act
            var contadorInteracoesInicial = questionarioControle.ObterContadorInteracoes();
            questionarioControle.IncrementarContadorInteracoes();
            var contadorInteracoesDepois = questionarioControle.ObterContadorInteracoes();

            // Assert
            Assert.Equal(0, contadorInteracoesInicial); // O contador deve iniciar em 0
            Assert.Equal(1, contadorInteracoesDepois); // Após incrementar, o contador deve ser 1
        }




        [Fact]
        public void TestarObterRelatorioCumulativo()
        {
            // Arrange
            var questionarioControle = new QuestionarioSatisfacaoControle();

            // Act
            var relatorio = questionarioControle.ObterRelatorioCumulativo();

            // Assert
            Assert.NotNull(relatorio);
            Assert.NotEmpty(relatorio); // O relatório não deve estar vazio
            // Você pode adicionar mais verificações específicas ao conteúdo do relatório, se necessário
        }
    }
}
