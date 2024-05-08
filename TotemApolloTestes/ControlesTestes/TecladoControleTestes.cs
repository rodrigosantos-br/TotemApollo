﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotemApollo.Controles;

namespace TotemApolloTestes.ControlesTestes
{
    public class TecladoControleTestes
    {
        [Fact]
        public void TestarEventoTeclaProcessada()
        {
            // Arrange
            var tecladoControle = new TotemApollo.TecladoControle();
            bool eventoDisparado = false;
            string teclaEsperada = "a";

            // Assinar o evento TeclaProcessada
            tecladoControle.TeclaProcessada += (sender, tecla) =>
            {
                eventoDisparado = true;
                Assert.Equal(teclaEsperada, tecla);
            };

            // Act - Simula o clique na tecla "A"
            var teclaButton = new Button();
            teclaButton.Text = "A";
            tecladoControle.Tecla_Click(teclaButton, EventArgs.Empty);

            // Assert
            Assert.True(eventoDisparado, "O evento TeclaProcessada não foi disparado.");
        }
    }
}