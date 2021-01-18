using System;
namespace API.Models
{
    public static class TaxaDeJuros
    {
        public static float Juros { get; } = 0.01f;
        public static bool ValidarJuros(float valor) { return Juros == valor; }
    }
}
