﻿using System;
using System.Globalization;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));



                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroExeception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();    
        }
    }
}