namespace TotemApollo.Modelos
{
    public class Visitante
    {
        public Visitante(string nome, string dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; }
        public string DataNascimento { get; }
    }
}
