using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Clase Abstracta : NO SE PUEDE INSTANCIAR. 
    abstract class FiguraBase
    {
        // CLASES ABSTRACTAS

        // Se declara una clase como abstracta para no poder crear instancias de la misma. Es decir, no podemos
        // crear objetos de esta, no podemos hacer FiguraBase figura = new FiguraBase().
        // Es logico que no vayamos a hacer instanciacion de la misma porque esta solo sirve para dar 
        // una futura funcionalidad a clases heredadas

        //METODOS ABSTRACTOS . No contiene un cuerpo de metodo y no puedes ser privado

        protected string colorFigura;

        public void ObtenerUbicacion() 
        {
            Console.WriteLine("X,Y");
        
        }

        // Metodo para saber a que distancia de la parte superior de la aplicacion esta nuestra figura geometrica
        // Queremos que cada clase implemente de forma diferente este metodo por eso debemos poner "abstract" antes
        // del tipo de retorno del metodo. Solo se ha definado como es la estructura
        public abstract void ObtenerTop();
      

    }
}
