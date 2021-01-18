using System;

namespace API.Models
{
    public static class CalculaJuros
    {
        public static decimal Total(decimal ValorInicial, int Tempo)
        {
            //Inicialização de uma variável local para definir as casas decimais
            //(evita que 105.10 vire 105.1)
            decimal ValorFinal = Decimal.Parse("0.00");

            //Adiciona o resultado truncado do cálculo de juros
            //o cálculo é multiplicado por 100 e depois de truncado é dividido por 100
            //isso é para manter a precisão das duas casas decimais
            ValorFinal += Math.Truncate(100 *(ValorInicial * (decimal)Math.Pow(1 + TaxaDeJuros.Juros, Tempo))) / 100;

            //Retorna o valor desejado
            return ValorFinal;
        }

        public static bool ValidarCálculo(decimal ValorInicial, int Tempo, decimal ResultadoEsperado)
        {
            return Total(ValorInicial, Tempo) == ResultadoEsperado;
        }
    }
}