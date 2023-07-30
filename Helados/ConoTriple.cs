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
    public class ConoTriple : HeladoComponent
    {
        public override double Costo => 2.00; // Define el precio del producto
        public override string Descripcion => "Cono Triple"; 
     }
}
