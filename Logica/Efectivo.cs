using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Efectivo : FormaDePago
    {

        public override void CalcularTotal(Compra unaCompra)
        {
            unaCompra.Valor -= unaCompra.Valor * 10 / 100; 
        }

        public override string ToString()
        {
            return "Efectivo";
        }
    }
}
