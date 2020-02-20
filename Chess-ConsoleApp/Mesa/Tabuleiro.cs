using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_ConsoleApp.Mesa
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

        public Peca Peca(int linha,int coluna)
        {
            return Pecas[linha, coluna];
        }
        public void ColocarPeca(Peca p,Posicao pos)
        {
            Pecas[pos.Linhas, pos.Colunas] = p;
            p.Posicao = pos;
        }
    }
}
