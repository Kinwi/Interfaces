using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Linea:IFigura
    {
        public int puntoXInicial { get; set; }
        public int puntoXFinal { get; set; }
        public int puntoYInicial { get; set; }
        public int puntoYFinal{ get; set; }

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public void Dibujar()
        {
            throw new NotImplementedException();
        }
    }
}
