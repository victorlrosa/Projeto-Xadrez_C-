using Chess_ConsoleApp.Mesa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_ConsoleApp.View
{
    class Tela
    {
        public static void Imprimirtabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("# ");
                    }
                    Console.Write(tabuleiro.Peca(i, j) + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
