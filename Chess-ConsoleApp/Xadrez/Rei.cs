using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.Mesa.Enum;

namespace Chess_ConsoleApp.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
