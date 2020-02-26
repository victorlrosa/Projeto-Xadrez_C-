using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.Mesa.Enum;
using Chess_ConsoleApp.Xadrez;
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
                Console.Write(8 - i + "  ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a b c d e f g h");
            
        }

        public static CoordenadasXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new CoordenadasXadrez(coluna, linha);

        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branca)
                Console.Write(peca);
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            
        }
    }
}
