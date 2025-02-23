using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIENDA_DEPORTIVA.Controlador;

namespace TIENDA_DEPORTIVA
{
    public partial class VentanaCliente : Form
    {
        //listas en las que se va a almacenar los productos
        private List<RopaDeportiva> ListaRopaDeportivaCliente;
        private List<ImplementacionDeportiva> ListaImplementacionCliente;

        //pongo las listas como parametros para que las listas de administrador lleguen a las listas de cliente
        public VentanaCliente(List<RopaDeportiva> lista,List<ImplementacionDeportiva> lista2)
        {
            InitializeComponent();
            ListaRopaDeportivaCliente = lista;//paso la informacion de las lista de ropa de admin
            ListaImplementacionCliente = lista2;//paso la informacion de las lista de implementacion de admin
            CargarDatos();
        }

        public VentanaCliente() { InitializeComponent(); }


        //metodo para pasar las listas ya con la informacion a los datagridview de cliente
        private void CargarDatos()
        {
            dataGridViewRopaCliente.DataSource = null;
            dataGridViewRopaCliente.DataSource = ListaRopaDeportivaCliente;
            dataGridViewImplementacionCliente.DataSource = null;
            dataGridViewImplementacionCliente.DataSource = ListaImplementacionCliente;
        }

        private void BuscarCodigoRopa(int CodigoBuscar)
        {
            RopaDeportiva prenda = ListaRopaDeportivaCliente.Find(p => p.CodigoRef == CodigoBuscar);

            if (prenda != null)
            {
                int unidades = Convert.ToInt32(textBoxUnidadesCompradasRopa.Text);

                float Total = PrecioTotal(prenda.Precio,unidades);

                TotalCompraRopa.Text = Total.ToString();
               
            }
            else
            {
                MessageBox.Show("CODIGO DE REFERENCIA DEL PRODUCTO NO ENCONTRADO");
            }
        }

        private void BuscarCodigoImplementacion(int CodigoBuscar)
        {
            ImplementacionDeportiva Implemento = ListaImplementacionCliente.Find(I => I.CodigoRef == CodigoBuscar);

            if (Implemento != null)
            {
                int unidades = Convert.ToInt32(textBoxUnidadesCompradasImplementacion.Text);

                float Total = PrecioTotal(Implemento.Precio, unidades);

                TotalCompraImplementacion.Text = Total.ToString();

            }
            else
            {
                MessageBox.Show("CODIGO DE REFERENCIA DEL PRODUCTO NO ENCONTRADO");
            }
        }


        private float PrecioTotal(float precio, int unidades)
        {
            float Total = precio * unidades;

            return Total;
        }
        

        private void buttonenviarCliente_Click(object sender, EventArgs e)
        {
            int CodigoRef = Convert.ToInt32(textBoxCodigoProductoRopa.Text);
            BuscarCodigoRopa(CodigoRef);

            textBoxCodigoProductoRopa.Clear();
            textBoxUnidadesCompradasRopa.Clear();
        }

        private void buttonEnviarCiente2_Click(object sender, EventArgs e)
        {
            int CodigoRef = Convert.ToInt32(textBoxCodigoProductoImplementacion.Text);
            BuscarCodigoImplementacion(CodigoRef);

            textBoxCodigoProductoImplementacion.Clear();
            textBoxUnidadesCompradasImplementacion.Clear();
        }
    }
}
