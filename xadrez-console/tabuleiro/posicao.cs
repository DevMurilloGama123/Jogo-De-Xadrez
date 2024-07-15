namespace tabuleiro
{
    internal class Posicao
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

         public Posicao(int Linha, int Coluna)
        {
            this.linhas = Linha;
            this.colunas = Coluna;
        }

        public void definirValores(int linha,  int coluna)
        {
            this.linhas = linha;
            this.colunas = coluna;  
        }

        public override string ToString()
        {
            return linhas + ", " + colunas;
        }
    }
}
