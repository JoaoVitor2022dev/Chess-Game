namespace Xadrez.tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
        public Tabuleiro(int linhas, int colunas)
        {
           this.linhas = linhas; 
           this.colunas = colunas;
           pecas = new Peca[linhas, colunas]; 
        }
        public Peca peca(int linha, int coluna)
        {
           return pecas[linha, coluna];  
        } 
        public Peca peca(Posicao posicao)
        {
          return  pecas[posicao.linha, posicao.coluna];
        }
         // valida se a peça existe...
        public bool existePeca(Posicao posicao)
        {
           validarPosicao(posicao);
           return peca(posicao) != null;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
           if (existePeca(pos))
           {
              throw new TabuleiroExecption("Já existe uma peça nesta posição!");
           }
           pecas[pos.linha, pos.coluna] = p;
           p.posicao = pos;
        }
        public Peca retirarPeca(Posicao pos)
        {
          if (peca(pos) == null )
          {
             return null;
          }
          Peca aux = peca(pos); 
          aux.posicao = null; 
          pecas[pos.linha, pos.coluna] = null; 
          return aux;
        }
        public bool posicaoValida(Posicao posicao)
        {
           if (posicao.linha <0 || posicao.linha > linhas || posicao.coluna < 0 || posicao.coluna > colunas)
           {
             return false;
           }
           return true;
        }

        //  funcionalidade de validar peças 
        public void validarPosicao(Posicao posicao)
        {
          if (!posicaoValida(posicao))
          {
             throw new TabuleiroExecption("Posição invalida!");
          }
        }
    } 
}