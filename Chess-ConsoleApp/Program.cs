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
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.Imprimirtabuleiro(partida.Tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("Formato inválido das coordenadas!");
                        Console.ReadKey();
                    }
                    catch(IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Digite as coodernadas dentro do padrão! Ex:(a1)");
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.ReadKey();
        }
    }
}
