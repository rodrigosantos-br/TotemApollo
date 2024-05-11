namespace TotemApollo.Modelos
{
    public class Obra(int id, string titulo, string historico, Image imagem)
    {
        public int Id { get; set; } = id;
        public string Titulo { get; set; } = titulo;
        public string Historico { get; set; } = historico;
        public Image Imagem { get; set; } = imagem;
    }
}
