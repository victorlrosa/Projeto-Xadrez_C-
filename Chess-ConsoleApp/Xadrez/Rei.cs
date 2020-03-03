using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.Mesa.Enum;

namespace Chess_ConsoleApp.Xadrez
{
    class Rei : Peca
    {
        private PartidaXadrez partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(cor, tab)
        {
            this.partida = partida;
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

            //#JogadaEspecial Roque Pequeno
            if (QtdMovimentos == 0 && !partida.Xeque)
            {
                Posicao posT1 = new Posicao(Posicao.Linhas, Posicao.Colunas + 3);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.Linhas, Posicao.Colunas + 1);
                    Posicao p2 = new Posicao(Posicao.Linhas, Posicao.Colunas + 2);
                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null)
                    {
                        mat[Posicao.Linhas, Posicao.Colunas + 2] = true;
                    }
                }
            }

            //#JogadaEspecial Roque Grande
            if (QtdMovimentos == 0 && !partida.Xeque)
            {
                Posicao posT2 = new Posicao(Posicao.Linhas, Posicao.Colunas - 4);
                if (TesteTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.Linhas, Posicao.Colunas - 1);
                    Posicao p2 = new Posicao(Posicao.Linhas, Posicao.Colunas - 2);
                    Posicao p3 = new Posicao(Posicao.Linhas, Posicao.Colunas - 3);

                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null && Tabuleiro.Peca(p3) == null)
                    {
                        mat[Posicao.Linhas, Posicao.Colunas - 2] = true;
                    }
                }
            }

            return mat;
        }

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QtdMovimentos == 0;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
