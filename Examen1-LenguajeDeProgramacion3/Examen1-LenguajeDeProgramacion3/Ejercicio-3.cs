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
    public partial class Ejercicio_3 : Form
    {
        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void Ejercicio_3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                
                if (i % 3 == 0 & i % 5 == 0)
                {
                    ltbNumeros.Items.Add(i + " Kevin Lopez");
                }
                else if ( i % 3 == 0)
                {
                    ltbNumeros.Items.Add(i + " Kevin");
                }
                else if (i % 5 == 0)
                {
                    ltbNumeros.Items.Add(i + " Lopez");
                }
                else
                {
                    ltbNumeros.Items.Add(i);
                }
            }
        }
    }
}
