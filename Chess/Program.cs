using Chess.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.tabuleiro;

namespace Chess{
    class program{
        static void Main(string[] args){
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição " + P);

            Console.ReadLine();

        }
    }
}