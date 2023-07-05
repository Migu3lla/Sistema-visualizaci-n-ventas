using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace TrabajoPractico
{
    public partial class GridFactura : Form
    {
        public GridFactura()
        {
            InitializeComponent();
        }
        

            private Compra _detalleCompra;

        public Compra detalleCompra
        {
            get { return _detalleCompra; }
            set { _detalleCompra = value; }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridFactura_Load(object sender, EventArgs e)
        {
            this.dataGridDetalle.DataSource = detalleCompra;
        }
    }
}
