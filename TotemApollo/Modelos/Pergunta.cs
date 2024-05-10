using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotemApollo.Modelos
{
    public class Pergunta(string texto, List<string> opcoesResposta)
    {
        public string Texto { get; } = texto;
        public List<string> OpcoesResposta { get; } = opcoesResposta;
    }
}
