using System;
using System.Globalization;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            posicao P;

            P = new posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.WriteLine();
        }
    }
}