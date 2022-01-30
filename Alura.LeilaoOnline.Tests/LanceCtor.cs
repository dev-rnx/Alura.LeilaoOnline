using System;
using Xunit;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            // Arrange
            var valorNegativo = -100;

            // Assert
            var excecaoObtida = Assert.Throws<ArgumentException>(
                // Act
                () => new Lance(null, valorNegativo)
            );

            var msgObtida = "Valor do lance deve ser igual ou maior que zero.";
            Assert.Equal(msgObtida, excecaoObtida.Message);
        }
    }
}
