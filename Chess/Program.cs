using tabuleiro;
using xadrez;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.tabuleiro;

namespace Chess {
    class program {
        static void Main(string[] args) {

            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 1));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 1));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}