using Chess_ConsoleApp.Mesa;

namespace Chess_ConsoleApp.Xadrez
{
    class CoordenadasXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public CoordenadasXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
