using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
