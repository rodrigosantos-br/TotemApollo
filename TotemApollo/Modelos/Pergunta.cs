namespace TotemApollo.Modelos
{
    public class Pergunta(string texto, List<string> opcoesResposta)
    {
        public string Texto { get; } = texto;
        public List<string> OpcoesResposta { get; } = opcoesResposta;
    }
}
