﻿using System;
using tabuleiro;
using xadrez;

namespace TESTE_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Posicao P = new Posicao(3, 4);
                //Console.WriteLine("posição: " + P);
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(18, 9));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 7));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(5, 1));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            /*PosicaoXadrez pos = new PosicaoXadrez('a',1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());*/
                       


            Console.ReadLine();
        }
    }
}
