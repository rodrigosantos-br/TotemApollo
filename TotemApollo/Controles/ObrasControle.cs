using TotemApollo.Modelos;

namespace TotemApollo.Controles
{
    public class ObrasControle
    {
        private readonly Museu museu;

        public ObrasControle()
        {
            museu = new Museu();
        }

        // Método para obter a obra atual
        public Obra ObraAtual()
        {
            return museu.ObraAtual();
        }

        // Método para obter a imagem da obra atual
        public Image ObterImagemObraAtual()
        {
            return museu.ObraAtual().Imagem;
        }

        // Método para obter a descrição da obra atual
        public string ObterDescricaoObraAtual()
        {
            return museu.ExibirHistoricoObraAtual();
        }

        // Métodos para avançar e retroceder entre as obras
        public void AvancarParaProximaObra()
        {
            museu.AvancarParaProximaObra();
        }

        public void RetrocederParaObraAnterior()
        {
            museu.RetrocederParaObraAnterior();
        }

        // Método para exibir a obra atual nos controles fornecidos
        public void ExibirObraAtual(PictureBox pbxImagemObra, Label lblDescricao)
        {
            // Define a imagem da obra no PictureBox
            pbxImagemObra.Image = ObterImagemObraAtual();

            // Define a descrição da obra no Label
            lblDescricao.Text = ObterDescricaoObraAtual();
        }
    }
}

