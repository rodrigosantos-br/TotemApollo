namespace TotemApollo.Modelos
{
    public class Museu
    {
        private readonly List<Obra> obras;
        private readonly List<Visitante> visitantes;
        private int obraAtualIndex; // Variável para armazenar o índice da obra atual

        public Museu()
        {
            visitantes = [];
            obras = [];

            // Adicione suas 4 obras aqui apenas se a lista estiver vazia.
            if (Obras.Count == 0)
            {
                Image imagem1 = Image.FromFile("Imagens\\imgObra1.jpeg");
                Image imagem2 = Image.FromFile("Imagens\\imgObra2.jpeg");
                Image imagem3 = Image.FromFile("Imagens\\imgObra3.jpeg");
                Image imagem4 = Image.FromFile("Imagens\\imgObra4.jpeg");

                obras.Add(new Obra(1, "A Grande Jornada Lunar",
                                      "Testemunhe a corajosa façanha da humanidade enquanto adentra" +
                                      " o espaço desconhecido. Esta exibição celebra a primeira viagem" +
                                      " tripulada à Lua, destacando os heróis que a tornaram possível" +
                                      " e os avanços tecnológicos que a viabilizaram.\r\n", imagem1));
                obras.Add(new Obra(2, "A Pioneira Apollo 11",
                                      "Descubra os segredos da missão Apollo 11, onde Neil Armstrong, Buzz" +
                                      " Aldrin e Michael Collins escreveram seus nomes na história. " +
                                      "Explore os trajes espaciais, artefatos e a emocionante jornada que" +
                                      " levou o homem à superfície lunar pela primeira vez.", imagem2));
                obras.Add(new Obra(3, "O Desembarque na Lua",
                                      "Reviva o momento transcendental em que a humanidade deu seu primeiro " +
                                      "passo na Lua. Esta exibição imersiva transporta os visitantes para a " +
                                      "superfície lunar, capturando a emoção e a grandiosidade do momento " +
                                      "icônico que mudou para sempre nossa compreensão do cosmos.", imagem3));
                obras.Add(new Obra(4, "Legado Lunar",
                                      "Explore o impacto duradouro da primeira viagem do homem à Lua e sua " +
                                      "influência na exploração espacial moderna. Dos primeiros passos na " +
                                      "superfície lunar até as futuras expedições interplanetárias, esta exposição " +
                                      "destaca o legado inspirador da conquista do espaço.", imagem4));
            }

            obraAtualIndex = 0; // Inicializa o índice da obra atual
        }

        // Método para avançar para a próxima obra
        public void AvancarParaProximaObra()
        {
            obraAtualIndex++;
            if (obraAtualIndex >= obras.Count)
            {
                obraAtualIndex = 0; // Volta para a primeira obra quando chegar na última
            }
        }

        // Método para retroceder para a obra anterior
        public void RetrocederParaObraAnterior()
        {
            obraAtualIndex--;
            if (obraAtualIndex < 0)
            {
                obraAtualIndex = obras.Count - 1; // Volta para a última obra quando chegar na primeira
            }
        }

        // Método para obter a obra atual
        public Obra ObraAtual()
        {
            return obras[obraAtualIndex];
        }

        public void CadastrarVisitante(string nome, string dataNascimento)
        {
            visitantes.Add(new Visitante(nome, dataNascimento));
        }

        public void RemoverUltimoVisitante()
        {
            if (visitantes.Count > 0)
            {
                visitantes.RemoveAt(visitantes.Count - 1);
            }
        }

        public int ObterQuantidadeDeVisitantes()
        {
            return visitantes.Count;
        }

        public string ExibirHistoricoObraAtual()
        {
            // Retorna o histórico da obra atual
            return ExibirHistoricoObra(ObraAtual().Id);
        }

        public string ExibirHistoricoObra(int id)
        {
            foreach (var obra in Obras)
            {
                if (obra.Id == id)
                {
                    // Retorna a informação formatada em uma string
                    return $"{obra.Titulo}\n\n    {obra.Historico}";
                }
            }
            // Retorna uma mensagem se a obra não for encontrada
            return "Obra não encontrada no museu.";
        }

        public List<Obra> Obras { get => obras; }

        public Obra Obra
        {
            get => default;
            set
            {
            }
        }
    }
}

