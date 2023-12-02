using System;
using System;
using System.Globalization;

namespace Xadrez.tabuleiro
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        public Posicao(int linha, int coluna)
        {
            this.Linha = linha; 
            this.Coluna = coluna;
        } 
        public override string ToString()
        {
            return $" Linha: {this.Linha}, Coluna: {this.Coluna}";
        }
    }
}