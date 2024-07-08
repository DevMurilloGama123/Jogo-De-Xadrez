namespace tabuleiro
{
    internal class Tabuleiro
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


        public Peca peca(int linhas, int coluna)
        {
            return pecas[linhas, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linhas, pos.colunas];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if(existePeca(pos))
            {
                throw new TabuleiroExeception("Já existe uma peça nessa posição!");
            }
            pecas[pos.linhas, pos.colunas] = p;
            p.posicao = pos;
        }


        public bool posicaoValida(Posicao pos)
        {
            if(pos.linhas < 0 || pos.linhas >= linhas || pos.colunas < 0 || pos.colunas >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroExeception("Posição inválida! ");
            }
        }

    }
}
