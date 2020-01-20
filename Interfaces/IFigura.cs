using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IFigura : ICalculador
    {
        // Interface : Es un contrato entre una interface y una clase que implementa dicha interfaz
        //Las interfaces no pueden tener instancias. Pero si podrian tener las clases que implementan dicha interface
        // Los metodos implementados de una interface tienen que ser publicos
        // Las interfaces no tienen modificadores de acceso, ni virtual, no contienen implementacion es decir nada entre
        // {}. Tampoco pueden incluir campos


        // Estamos viendo que tambien una interfaz puede implementar otra interface . En el ejempl la interfaz "ICalculador" implementa la interfaz "IFigura".

        void Dibujar();
        int Calcular(int x, int y);
      
    }
}
