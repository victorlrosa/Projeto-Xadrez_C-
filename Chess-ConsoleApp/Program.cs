using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.View;
using System;


namespace Chess_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.Imprimirtabuleiro(tab);
            Console.ReadKey();
        }
    }
}
