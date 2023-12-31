using Xadrez.tabuleiro.Enums;

namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }  // pode ser acessada somente pelas classes dela...
        public int qteMovimento { get; protected set; } 
        public Tabuleiro tabuleiro { get; protected set; }
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null; 
            this.cor = cor; 
            this.tabuleiro = tabuleiro; 
            this.qteMovimento = 0;
        }
        public void quantidadeMovimentos()
        {
            this.qteMovimento++;
        }
    }
}