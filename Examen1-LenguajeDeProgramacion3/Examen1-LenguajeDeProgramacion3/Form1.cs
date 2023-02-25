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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_1 ejercicio1Form = new Ejercicio_1();
            ejercicio1Form.MdiParent = this;
            ejercicio1Form.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_2 ejercicio2Form = new Ejercicio_2();
            ejercicio2Form.MdiParent = this;
            ejercicio2Form.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_3 ejercicio3Form = new Ejercicio_3();
            ejercicio3Form.MdiParent = this;
            ejercicio3Form.Show();
        }
    }
}
