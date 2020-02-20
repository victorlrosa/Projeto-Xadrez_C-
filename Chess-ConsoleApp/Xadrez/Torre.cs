using Chess_ConsoleApp.Mesa;
using Chess_ConsoleApp.Mesa.Enum;

namespace Chess_ConsoleApp.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
