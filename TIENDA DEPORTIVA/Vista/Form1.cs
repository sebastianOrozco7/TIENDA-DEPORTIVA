using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDA_DEPORTIVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            VentanaAdministrador ventanaAdministrador = new VentanaAdministrador();
            ventanaAdministrador.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCliente ventanaCliente = new VentanaCliente();
            ventanaCliente.Show();
        }
    }
}
