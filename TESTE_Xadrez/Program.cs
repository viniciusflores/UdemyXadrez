﻿using System;
using tabuleiro;

namespace TESTE_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posicao P = new Posicao(3, 4);
            //Console.WriteLine("posição: " + P);

            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
