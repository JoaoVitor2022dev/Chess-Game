namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }  // pode ser acessada somente pelas classes dela...
        public int qteMovimento { get; protected set; } 
        public Tabuleiro tabuleiro { get; protected set; }
        public Peca(Posicao posicao,Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao; 
            this.cor = cor; 
            this.tabuleiro = tabuleiro; 
            this.qteMovimento = 0;
        }
    }
}