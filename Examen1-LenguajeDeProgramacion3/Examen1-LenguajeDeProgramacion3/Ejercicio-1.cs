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
    public partial class Ejercicio_1 : Form
    {
        public Ejercicio_1()
        {
            InitializeComponent();
        }

        private void Ejercicio_1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }


        private void Calcular()
        {
            //Declaracion de variables 
            double capital = 200000;
            double interes = 1.5/100;
            double periodo = 12;
            double interesTotal = 0;
            //Cuerpo del procediento
            

            for (int i = 0; i < 12; i++)
            {

                interesTotal = capital * interes;
                ltbDatos.Items.Add(interesTotal);
            }

            
        }

    }
}
