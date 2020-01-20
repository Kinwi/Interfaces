using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // RELAS DE LAS INTERFACES

    // 1. Una Interface nunca contendra implementaciones
    //      - No se pueden declarar campos en una interfaz
    //      - No se pueden declarar constructores
    //      - No se pueden definir modificadores de acceso a los metodos . Todos los metodos de una interfaz publicos
    //        a pelo . Ejemplo "void Dibujar()"
    //      - Una interfaz no puede heredad de una clase a una estructura y esto es porque una clase y una estructura
    //        contienen logica y entonces estariamos heredando logica implementada (PROHIBIDA)
             
    interface IRenderizador
    {
        void Renderizar();
        void Dibujar();
    }
}
