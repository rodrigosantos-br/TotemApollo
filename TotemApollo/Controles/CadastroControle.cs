using TotemApollo.Modelos;

namespace TotemApollo.Controles
{
    public class CadastroControle
    {
        private Museu museu;
        private CadastroValidacao validacao;
        private string mensagem;

        public CadastroControle(string nome, string dataNascimento)
        {
            this.validacao = new CadastroValidacao(nome, dataNascimento);
            if (validacao.MensagemNome == "" && validacao.MensagemDataNascimento == "")
            {
                this.museu = new Museu();
                this.museu.CadastrarVisitante(nome, dataNascimento);
                this.mensagem = "";
            }
            else
            {
                this.mensagem = "Não foi possível cadastrar o visitante. ";
                if (validacao.MensagemNome != "")
                {
                    this.mensagem += validacao.MensagemNome;
                }
                if (validacao.MensagemDataNascimento != "")
                {
                    this.mensagem += validacao.MensagemDataNascimento;
                }
            }
        }

        public void RemoverUltimoVisitante()
        {
            museu.RemoverUltimoVisitante();
        }

        public string Mensagem { get => mensagem; }
    }
}
