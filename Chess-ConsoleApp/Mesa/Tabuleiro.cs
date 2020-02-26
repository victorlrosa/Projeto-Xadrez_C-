using Chess_ConsoleApp.Exceptions;
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

        public Peca Peca(Posicao posicao)
        {
            return Pecas[posicao.Linhas, posicao.Colunas];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        public void ColocarPeca(Peca p,Posicao pos)
        {
            if (ExistePeca(pos))
                throw new TabuleiroException("Já existe uma peça nessa posição!");

            Pecas[pos.Linhas, pos.Colunas] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (Peca(pos) == null)
            {
                return null;
            }
            Peca aux = Peca(pos);
            aux.Posicao = null;
            Pecas[pos.Linhas, pos.Colunas] = null;
            return aux;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if(posicao.Linhas <0 || posicao.Linhas >= Linhas || posicao.Colunas<0 || posicao.Colunas >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
