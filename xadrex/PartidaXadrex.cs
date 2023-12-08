using Xadrez.tabuleiro;
using Xadrez.tabuleiro.Enums;
using Xadrez.xadrex;

namespace Xadrez.tabuleiro
{
    class PartidaXadrex
    {
        public Tabuleiro tab { get; set; }
        private int turno; 
        private Cor jogadorAtual;
        public bool terminada { get; private set; }
        public PartidaXadrex()
        {
           tab = new Tabuleiro(8, 8);
           turno = 1; 
           jogadorAtual = Cor.Branca;
           colocarPeca();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.quantidadeMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino); 
            tab.colocarPeca(p, destino);
        }
        private void colocarPeca()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrex('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrex('d', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrex('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrex('d', 8).toPosicao());
        }
    }
}