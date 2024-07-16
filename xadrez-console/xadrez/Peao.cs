using tabuleiro;

namespace xadrez
{

    class Peao : Peca
    {

        private PartidaDeXadrez partida;

        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p != null && p.cor != cor;
        }

        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            if (cor == Cor.Branca)
            {
                pos.definirValores(posicao.linhas - 1, posicao.colunas);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linhas, pos.colunas] = true;
                }
                pos.definirValores(posicao.linhas - 2, posicao.colunas);
                Posicao p2 = new Posicao(posicao.linhas - 1, posicao.colunas);
                if (tab.posicaoValida(p2) && livre(p2) && tab.posicaoValida(pos) && livre(pos) && qtdMovimentos == 0)
                {
                    mat[pos.linhas, pos.colunas] = true;
                }
                pos.definirValores(posicao.linhas - 1, posicao.colunas - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linhas, pos.colunas] = true;
                }
                pos.definirValores(posicao.linhas - 1, posicao.colunas + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linhas, pos.colunas] = true;
                }

                // #jogadaespecial en passant
                
            }
            else
            {
                pos.definirValores(posicao.linhas + 1, posicao.colunas);
                if (tab.posicaoValida(pos) && livre(pos))
                {
                    mat[pos.linhas, pos.colunas] = true;
                }
                pos.definirValores(posicao.linhas + 2, posicao.colunas);
                Posicao p2 = new Posicao(posicao.linhas + 1, posicao.colunas);
                if (tab.posicaoValida(p2) && livre(p2) && tab.posicaoValida(pos) && livre(pos) && qtdMovimentos == 0)
                {
                    mat[pos.linhas, pos.colunas] = true;
                }
                pos.definirValores(posicao.linhas + 1, posicao.colunas - 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linhas, pos.colunas] = true;
                }
                pos.definirValores(posicao.linhas + 1, posicao.colunas + 1);
                if (tab.posicaoValida(pos) && existeInimigo(pos))
                {
                    mat[pos.linhas, pos.colunas] = true;
                }

                // #jogadaespecial en passant
               
            }

            return mat;
        }
    }
}