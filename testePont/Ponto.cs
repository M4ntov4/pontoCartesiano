using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.cuzin;

namespace testePont
{
    class Ponto
    {
        int posicaoX;
        int posicaoY;

        public int PosicaoY { get => posicaoY; set => posicaoY = value; }
        public int PosicaoX { get => posicaoX; set => posicaoX = value; }

        public Ponto()
        {
            this.PosicaoY = 0;
            this.PosicaoX = 0;
        }

        public Ponto(Ponto Teste)
        {
            this.PosicaoX = Teste.posicaoX;
            this.PosicaoY = Teste.PosicaoY;
        }

        public Ponto(int x, int y)
        {
            this.PosicaoX = x;
            this.PosicaoY = y;
        }


    }
}
