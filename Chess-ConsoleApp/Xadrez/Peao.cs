using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.Mesa.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_ConsoleApp.Xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tabuleiro, Cor cor): base(cor,tabuleiro)
        {

        }
        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            if(Cor == Cor.Branca)
            {
                pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas);
                if(Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }

                pos.DefinirValores(Posicao.Linhas - 2, Posicao.Colunas);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QtdMovimentos == 0)
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }

                pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas - 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }

                pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas + 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }
            }

            if (Cor == Cor.Preta)
            {
                pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }

                pos.DefinirValores(Posicao.Linhas + 2, Posicao.Colunas);
                if (Tabuleiro.PosicaoValida(pos) && Livre(pos) && QtdMovimentos == 0)
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }

                pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas - 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }

                pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas + 1);
                if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linhas, pos.Colunas] = true;
                }
            }

            return mat;
        }
        public override string ToString()
        {
            return "P";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool Livre(Posicao pos)
        {
            return Tabuleiro.Peca(pos) == null;
        }
    }
}
