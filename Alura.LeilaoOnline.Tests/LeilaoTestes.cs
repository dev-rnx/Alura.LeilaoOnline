using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    class LeilaoTestes
    {
        public void LeilaoComVariosLances()
        {
            // Arrange
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);

            // Act
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;
            Assert.Equal(valorEsperado, valorObtido);

        }

        public void LeilaoComApenasUmLance()
        {
            // Arrange
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            leilao.RecebeLance(fulano, 800);

            // Act
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;
            Assert.Equal(valorEsperado, valorObtido);
        }

    }
}
