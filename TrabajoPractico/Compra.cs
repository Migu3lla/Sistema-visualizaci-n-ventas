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
    public partial class Compra : Form
    {
        public Compra()
        {
            InitializeComponent();
        }

        private List<Producto> listProductos;
        private List<Producto> productosSeleccionados = new List<Producto>();
        public Producto Producto;
        

        private void Venta(object sender, EventArgs e)
        {
            listProductos = new List<Producto>();
            Producto Remera = new Producto();
            Remera.Nombre = "Remera";
            Remera.Precio = 1000;
            Remera.Cantidad = 1;

            Producto Pantalon = new Producto();
            Pantalon.Nombre = "Pantalon";
            Pantalon.Precio = 2500;
            Pantalon.Cantidad = 1;

            Producto Short = new Producto();
            Short.Nombre = "Short";
            Short.Precio = 2000;
            Short.Cantidad = 1;

            listProductos.Add(Remera);
            listProductos.Add(Pantalon);
            listProductos.Add(Short);

            listProd.DisplayMember = "Nombre";
            listProd.DataSource = listProductos;


            List<FormaDePago> formas = new List<FormaDePago>();


            Debito debito = new Debito();
            Credito credito = new Credito();
            Efectivo efectivo = new Efectivo();

            formas.Add(debito);
            formas.Add(credito);
            formas.Add(efectivo);


            cmbPago.DataSource = formas;

            

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkDescuento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(listProd.SelectedItem !=null)
            {

                Producto productoSeleccionado = (Producto)listProd.SelectedItem;
                productosSeleccionados.Add(productoSeleccionado);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string VerValor;
            

            FormaDePago formaSeleccionada = (FormaDePago)cmbPago.SelectedItem;
            Logica.Compra unaCompra = new Logica.Compra();

             unaCompra.CalcularValor(productosSeleccionados, checkIVA.Checked, checkDescuento.Checked);

            

            formaSeleccionada.CalcularTotal(unaCompra);
            VerValor = unaCompra.Valor.ToString();

            MessageBox.Show("El monto final es $" + VerValor);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridFactura detalle = new GridFactura();

        //  detalle.detalleCompra = (Compra)listProd.SelectedValue;
            detalle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            productosSeleccionados.Add((Producto)listProd.SelectedValue);

        }
    }
}
