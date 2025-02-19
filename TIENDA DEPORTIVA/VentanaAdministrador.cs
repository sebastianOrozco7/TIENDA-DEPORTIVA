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
            comboBoxOpcionesAgregar.Visible = false;

            TexBoxPrendaRopa.Visible = false;
            TexBoxMarcaRopa.Visible = false;
            TexBoxTallaRopa.Visible = false;
            TexBoxPrecioRopa.Visible = false;
            TexBoxColorRopa.Visible = false;

            textBoxNombreImplementacion.Visible = false;
            textBoxMarcaImplementacion.Visible = false;
            textBoxMaterialImplementacion.Visible = false;
            textBoxPrecioImplementacion.Visible = false;

            

        }
        //lista para agregar la ropa deportiva
        List<RopaDeportiva> ListaRopaDeportiva = new List<RopaDeportiva>();

        private void comboBoxAdministrador_SelectedIndexChanged(object sender, EventArgs e)
        {

            string OpcionSeleccionada = comboBoxAdministrador.SelectedItem.ToString();
           
            if(OpcionSeleccionada == "Agregar")
            {
                comboBoxOpcionesAgregar.Visible = true;
            }
        }

        private void comboBoxOpcionesAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string OpcionSelecionadaComboboxAgregar = comboBoxOpcionesAgregar.SelectedItem?.ToString() ?? "";
            switch (OpcionSelecionadaComboboxAgregar)
            {
                case "Ropa Deportiva":
                    TexBoxPrendaRopa.Visible = true;
                    TexBoxMarcaRopa.Visible = true;
                    TexBoxTallaRopa.Visible = true;
                    TexBoxPrecioRopa.Visible = true;
                    TexBoxColorRopa.Visible = true;
                    break;

                case "Implementacion Deportiva":
                    textBoxNombreImplementacion.Visible = true;
                    textBoxMarcaImplementacion.Visible = true;
                    textBoxMaterialImplementacion.Visible = true;
                    textBoxPrecioImplementacion.Visible = true;
                    break;
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

        }
    }
}
