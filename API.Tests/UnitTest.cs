using System;
using Xunit;
using API.Models;

namespace API.Tests
{
    public class UnitTest
    {
        [Fact]
        public void CálculoCorreto()
        {
            Assert.True(CalculaJuros.ValidarCálculo(100, 5, 105.10m), "Resultado do cálculo incorreto.");
        }

        [Fact]
        public void TaxaCorreta()
        {
            Assert.True(TaxaDeJuros.ValidarJuros(0.01f), "Taxa de juros incorreta.");
        }
    }
}
