namespace tabuleiro
{
    internal class Posicao
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

         public Posicao(int Linhas, int Colunas)
        {
            this.linhas = Linhas;
            this.colunas = Colunas;
        }

        public override string ToString()
        {
            return linhas + ", " + colunas;
        }
    }
}
