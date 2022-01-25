using System.Linq;
using Xunit;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeOferta
    {
        [Theory]
        [InlineData(4, new double[] {800, 400, 300, 100})]
        [InlineData(2, new double[] { 800, 900 })]
        public void NaoPermiteNovosLances(int qtdeEsperada, double[] ofertas)
        {
            // Arrange
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            foreach (var valor in ofertas)
            {
                leilao.RecebeLance(fulano, valor);
            }

            leilao.TerminaPregao();

            // Act
            leilao.RecebeLance(fulano, 1000);

            // Assert
            var qtdeEsperado = qtdeEsperada;
            var qtdeObtida = leilao.Lances.Count();
            Assert.Equal(qtdeEsperado, qtdeObtida);
        }
    }
}
