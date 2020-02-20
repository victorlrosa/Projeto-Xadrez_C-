using Chess_ConsoleApp.Exceptions;
using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.Mesa.Enum;
using Chess_ConsoleApp.View;
using Chess_ConsoleApp.Xadrez;
using System;


namespace Chess_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                Tela.Imprimirtabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
