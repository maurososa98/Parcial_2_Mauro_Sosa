using Entidades.Excepciones;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entidades
{
    public static class GenerarRandom
    {
        private static Random random = new Random();
        public static double DoubleAleatorio(double minimoValor, double maximoValor)
        {
            return random.NextDouble() * (maximoValor - minimoValor) + minimoValor;
        }

        public static int EnteroAleatorio(int minimoValor, int maximoValor)
        {
            return random.Next(minimoValor, maximoValor);
        }

    } 
}
