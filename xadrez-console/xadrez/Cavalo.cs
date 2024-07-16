using tabuleiro;

namespace xadrez
{

    class Cavalo : Peca
    {

        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.definirValores(posicao.linhas - 1, posicao.colunas - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }
            pos.definirValores(posicao.linhas - 2, posicao.colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }
            pos.definirValores(posicao.linhas - 2, posicao.colunas + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }
            pos.definirValores(posicao.linhas - 1, posicao.colunas + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }
            pos.definirValores(posicao.linhas + 1, posicao.colunas + 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }
            pos.definirValores(posicao.linhas + 2, posicao.colunas + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }
            pos.definirValores(posicao.linhas + 2, posicao.colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }
            pos.definirValores(posicao.linhas + 1, posicao.colunas - 2);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
            }

            return mat;
        }
    }
}