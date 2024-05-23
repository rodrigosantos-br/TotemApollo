namespace TotemApollo.Modelos
{
    public class CadastroValidacao
    {
        private string nome;
        private readonly string dataNascimento;
        private string mensagemNome;
        private string mensagemDataNascimento;

        public CadastroValidacao(string nome, string dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.ValidarNome();
            this.ValidarDataNascimento();
        }

        private void ValidarNome()
        {
            mensagemNome = "";
            // Verificar se o nome não está vazio
            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagemNome = "\nNome não pode ser vazio.";
                return;
            }

            // Verificar o comprimento do nome
            if (nome.Length < 3 || nome.Length > 20)
            {
                mensagemNome = "\nNome deve ter entre 3 e 20 caracteres.";
                return;
            }

            // Transformar a primeira letra do nome em maiúscula
            nome = char.ToUpper(nome[0]) + nome[1..].ToLower();
        }

        private void ValidarDataNascimento()
        {
            mensagemDataNascimento = "";
            // Verificar se a data de nascimento não está vazia
            if (string.IsNullOrWhiteSpace(dataNascimento))
            {
                mensagemDataNascimento = "\nData de nascimento não pode ser vazia.";
                return;
            }
        }

        public string MensagemNome { get => mensagemNome; }
        public string MensagemDataNascimento { get => mensagemDataNascimento; }
    }
}
