using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemApollo.Modelos
{
    public class Obra
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Historico { get; set; }
        public Image Imagem { get; set; }

        public Obra(int id, string titulo, string historico, Image imagem)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Historico = historico;
            this.Imagem = imagem;
        }
    }
}
