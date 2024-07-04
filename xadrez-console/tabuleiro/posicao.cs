namespace tabuleiro
{
    internal class posicao
    {
        public int Linha { get; set; }
        public int Colunas { get; set; }

         public posicao(int Linha, int Colunas)
        {
            this.Linha = Linha;
            this.Colunas = Colunas;
        }

        public override string ToString()
        {
            return Linha + ", " + Colunas;
        }
    }
}
