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
                   if(posicao.linhas == 3)
                {
                    Posicao esquerda = new Posicao(posicao.linhas, posicao.colunas - 1);
                    if (tab.posicaoValida(esquerda) && existeInimigo(esquerda) && tab.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.linhas - 1, esquerda.colunas] = true;
                    }

                    Posicao direita = new Posicao(posicao.linhas, posicao.colunas + 1);
                    if (tab.posicaoValida(direita) && existeInimigo(direita) && tab.peca(direita) == partida.vulneravelEnPassant)
                    {
                        mat[direita.linhas  -1, direita.colunas] = true;
                    }
                }
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
                if (posicao.linhas == 4)
                {
                    Posicao esquerda = new Posicao(posicao.linhas, posicao.colunas - 1);
                    if (tab.posicaoValida(esquerda) && existeInimigo(esquerda) && tab.peca(esquerda) == partida.vulneravelEnPassant)
                    {
                        mat[esquerda.linhas + 1, esquerda.colunas] = true;
                    }

                    Posicao direita = new Posicao(posicao.linhas, posicao.colunas + 1);
                    if (tab.posicaoValida(direita) && existeInimigo(direita) && tab.peca(direita) == partida.vulneravelEnPassant)
                    {
                        mat[direita.linhas+ + 1, direita.colunas] = true;
                    }
                }
            }

            return mat;
        }
    }
}