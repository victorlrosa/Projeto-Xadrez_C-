using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.Mesa.Enum;

namespace Chess_ConsoleApp.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            // acima
            pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // ne
            pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // direita
            pos.DefinirValores(Posicao.Linhas, Posicao.Colunas + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // se
            pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas + 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // abaixo
            pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // so
            pos.DefinirValores(Posicao.Linhas + 1, Posicao.Colunas - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // esquerda
            pos.DefinirValores(Posicao.Linhas, Posicao.Colunas - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            // no
            pos.DefinirValores(Posicao.Linhas - 1, Posicao.Colunas - 1);
            if (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            return mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
