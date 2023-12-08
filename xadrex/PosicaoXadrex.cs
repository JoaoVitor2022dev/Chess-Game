using Xadrez.tabuleiro;

namespace Xadrez.xadrex
{
    class PosicaoXadrex
    {
        public int linha { get; private set; }
        public char coluna { get; set; }
        public PosicaoXadrex(char coluna, int linha)
        {
           this.linha = linha; 
           this.coluna = coluna;
        }
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return $" {this.coluna}, {this.linha}";
        }
    }
}