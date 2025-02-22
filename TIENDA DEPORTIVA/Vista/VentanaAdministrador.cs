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
    public partial class VentanaAdministrador : Form
    {
        public VentanaAdministrador()
        {
            InitializeComponent();
            
            panelRopa.Visible = false;
            panelImplementacion.Visible = false;
            panelEliminar.Visible = false;
            

        }
        ImplementacionDeportiva implemento = new ImplementacionDeportiva();
        RopaDeportiva prenda = new RopaDeportiva();
        //lista para agregar la ropa deportiva
        List<RopaDeportiva> ListaRopaDeportiva = new List<RopaDeportiva>();
        //lista para agregar la implementacion deportiva
        List<ImplementacionDeportiva> ListaImplementacionDeportiva = new List<ImplementacionDeportiva>();
        //variable que va a contener el codigo para la eliminacion de un producto
        public int CodigoElimar { get; set; }

        private void comboBoxAdministrador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string OpcionSeleccionada = comboBoxAdministrador.SelectedItem.ToString();
           
            if(OpcionSeleccionada == "Agregar")
            {
                panelRopa.Visible = true;
                panelImplementacion.Visible = true;
            }

            else if(OpcionSeleccionada == "Eliminar")
            {
                panelEliminar.Visible = true;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            RopaDeportiva prenda = new RopaDeportiva();
            prenda.Prenda = TexBoxPrendaRopa.Text;
            prenda.Marca = TexBoxMarcaRopa.Text;
            prenda.Talla = TexBoxTallaRopa.Text;
            prenda.Color = TexBoxColorRopa.Text;
            prenda.Precio = Convert.ToSingle(TexBoxPrecioRopa.Text);
            prenda.CodigoRef = Convert.ToInt32(textBoxCodigoRopa.Text);

            prenda.Agregar(prenda,ListaRopaDeportiva);

            dataGridViewInventarioRopa.DataSource = null;//limpia la fuente de datos
            dataGridViewInventarioRopa.DataSource = ListaRopaDeportiva;//le paso la lista para que me la muestre en el dataG

            //mensaje para que el administrador vea que se agrego correctamente
            MessageBox.Show("Prenda Agregada Con Exito");
            // Limpiar los campos del formulario después de agregar
            TexBoxPrendaRopa.Clear();
            TexBoxMarcaRopa.Clear();
            TexBoxTallaRopa.Clear();
            TexBoxColorRopa.Clear();
            TexBoxPrecioRopa.Clear();
            textBoxCodigoRopa.Clear();

        }

        private void buttonAgregar2_Click(object sender, EventArgs e)
        {
            implemento.Nombre = textBoxNombreImplementacion.Text;
            implemento.Marca = textBoxMarcaImplementacion.Text;
            implemento.Material = textBoxMaterialImplementacion.Text;
            implemento.Precio = Convert.ToSingle(textBoxPrecioImplementacion.Text);
            implemento.CodigoRef = Convert.ToInt32(textBoxCodigoImplementacion.Text);

            implemento.Agregar(implemento, ListaImplementacionDeportiva);

            dataGridViewInventarioImplementacion.DataSource = null;
            dataGridViewInventarioImplementacion.DataSource = ListaImplementacionDeportiva;


            //mensaje para que el administrador vea que se agrego correctamente
            MessageBox.Show("Implemento Agregado Con Exito");
            // Limpiar los campos del formulario después de agregar
            TexBoxPrendaRopa.Clear();
            TexBoxMarcaRopa.Clear();
            TexBoxTallaRopa.Clear();
            TexBoxColorRopa.Clear();
            TexBoxPrecioRopa.Clear();
            textBoxCodigoImplementacion.Clear();

        }

        private void buttonEliminarImplemento_Click(object sender, EventArgs e)
        {
            int CodigoImplementoEliminar = Convert.ToInt32(textBoxElimarImplemento.Text);

            implemento.Eliminar(CodigoImplementoEliminar, ListaImplementacionDeportiva);

            textBoxElimarImplemento.Clear();

            ActualizarListaDeImplementacion();
        }

        public void ActualizarListaDeImplementacion()
        {
            dataGridViewInventarioImplementacion.DataSource = null;
            dataGridViewInventarioImplementacion.DataSource = ListaImplementacionDeportiva;
            dataGridViewInventarioImplementacion.Refresh();
        }

        private void buttonEliminarRopa_Click(object sender, EventArgs e)
        {
            int CodigoRopaEliminar = Convert.ToInt32(textBoxElimarRopa.Text);

            prenda.Eliminar(CodigoRopaEliminar, ListaRopaDeportiva);

            textBoxElimarRopa.Clear();

            ActualizarListaDeRopa();
        }

        public void ActualizarListaDeRopa()
        {
            dataGridViewInventarioRopa.DataSource = null;
            dataGridViewInventarioRopa.DataSource = ListaRopaDeportiva;
            dataGridViewInventarioRopa.Refresh();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            VentanaCliente cliente = new VentanaCliente(ListaRopaDeportiva,ListaImplementacionDeportiva);
            cliente.Show();
        }
    }
}
