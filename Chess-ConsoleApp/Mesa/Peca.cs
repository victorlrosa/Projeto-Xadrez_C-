using Chess_ConsoleApp.Mesa.Enum;

namespace Chess_ConsoleApp.Mesa
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Posicao posicao, Cor cor, int qtdMovimentos, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
