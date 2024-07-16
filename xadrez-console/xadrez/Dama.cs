using tabuleiro;

namespace xadrez
{

    class Dama : Peca
    {

        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "D";
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

            // esquerda
            pos.definirValores(posicao.linhas, posicao.colunas - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas, pos.colunas - 1);
            }

            // direita
            pos.definirValores(posicao.linhas, posicao.colunas + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas, pos.colunas + 1);
            }

            // acima
            pos.definirValores(posicao.linhas - 1, posicao.colunas);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas - 1, pos.colunas);
            }

            // abaixo
            pos.definirValores(posicao.linhas + 1, posicao.colunas);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas + 1, pos.colunas);
            }

            // NO
            pos.definirValores(posicao.linhas - 1, posicao.colunas - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas - 1, pos.colunas - 1);
            }

            // NE
            pos.definirValores(posicao.linhas - 1, posicao.colunas + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas - 1, pos.colunas + 1);
            }

            // SE
            pos.definirValores(posicao.linhas + 1, posicao.colunas + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas + 1, pos.colunas + 1);
            }

            // SO
            pos.definirValores(posicao.linhas + 1, posicao.colunas - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.definirValores(pos.linhas + 1, pos.colunas - 1);
            }

            return mat;
        }
    }
}