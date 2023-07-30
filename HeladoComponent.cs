using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Skalemi Company
// Si te surge alguna duda, contáctame.
// michaelvinces.skalemi@gmail.com

namespace Decorator_Heladería
{
    // Clase Abtracta
    public abstract class HeladoComponent
    {
        // Propiedades abstractas que solo reciben el parametro
        public abstract double Costo { get; } // Precio
        public abstract string Descripcion { get; } // Detalle del producto
    }
}
