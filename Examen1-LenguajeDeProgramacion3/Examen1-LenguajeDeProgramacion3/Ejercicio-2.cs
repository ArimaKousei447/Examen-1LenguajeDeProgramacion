using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1_LenguajeDeProgramacion3
{
    public partial class Ejercicio_2 : Form
    {
        //Declaracion de varibles
        double subTotal = 0;
        double total = 0;
        double descuento;
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Declaracion de varibles
            double precio;
            
            


            //Cuerpo de programa

            ltbNombreProducto.Items.Add(txtNombreProducto.Text);
            ltbPrecioProducto.Items.Add(txtPrecioProducto.Text);
            precio = Convert.ToDouble( txtPrecioProducto.Text);
            subTotal +=  precio ;
            txtSubtotal.Text = Convert.ToString(subTotal);
            txtPrecioProducto.Clear();
            txtNombreProducto.Clear();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            descuento = subTotal * 0.15;
            total = subTotal - descuento;
            MessageBox.Show("El total a pagar de su compra es: "+ total);
        }
    }
}
