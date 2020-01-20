using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Todo lo que se encuentra en la interface debe estar definido en las clases que la implementan . Es por eso
    // que tendremos que tener el metodo "Dibujar()" aunque no queramos. Es por contrato


    // Clase Heredada + Interface Heredada

    // Es posible heredar de una clase y de una Interface a la vez como estamos viendo en el ejemplo
    // para ello hay que seguir la regla de que primero ira la clase de la que queremos heredar ("FiguraBase") y 
    // mas tarde vendra la interface ("IFigura") de la cual estamos implementando los metodos. Podriamos tambien 
    // implementar mas interfaces una detras de otra separadas por comas
    class Circulo :FiguraBase,IFigura
    {
        public int Radio { get; set; }

        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Dibujar()
        {
            
        }
    }
}
