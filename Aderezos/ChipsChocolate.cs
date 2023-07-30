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
    public class ChipsChocolate:AgregadoDecorator
    {
        public ChipsChocolate(HeladoComponent helado) : base(helado) { }
        public override double Costo => _helado.Costo+0.25; // Agrega al costo calculado previamente el valor de Chips de Chocolate
        public override string Descripcion => string.Format($"{_helado.Descripcion}\n - Chips de Chocolate");
    }
}
