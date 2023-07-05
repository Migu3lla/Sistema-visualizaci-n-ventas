using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class Compra
    {
        private float _valor;

        public float Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private List<Producto> unaLista = new List<Producto>();

        public List<Producto> UnaLista
        {
            get { return unaLista; }
            set { unaLista = value; }
        }


        private bool _IVA;

        public bool IVA
        {
            get { return _IVA; }
            set { _IVA = value; }
        }

        private bool _descuento;

        public bool Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }


        public float CalcularValor(List<Producto> unaLista, bool iva, bool desc)
        {
            Valor = 0;
            foreach (Producto p in unaLista) //sumar productos de la lista entre si
            {
                Valor += p.Precio;
            }

            if (iva)
            {
                Valor += Valor * 21 / 100;
            }

            if (desc)
            {
                Valor -= 50;
            }

            return Valor;
        }

        

        

}
}
