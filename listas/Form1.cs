using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listas
{
    public partial class Form1 : Form
    {
        Estructura catalogo = new Estructura();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassBases nuevo;
            nuevo = new ClassBases(Convert.ToInt32(textBox1.Text));
            catalogo.agregar(nuevo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = catalogo.lista();
        }
    }
}
