using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private float _precio;

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        

    }
}
