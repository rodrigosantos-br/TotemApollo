namespace TotemApollo.Modelos
{
    public class Visitante(string nome, string dataNascimento)
    {
        public string Nome { get; } = nome;
        public string DataNascimento { get; } = dataNascimento;
    }
}
