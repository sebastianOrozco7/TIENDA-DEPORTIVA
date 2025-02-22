using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIENDA_DEPORTIVA.Controlador
{
    public class ImplementacionDeportiva
    {
        public int CodigoRef {  get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Material { get; set; }
        public float Precio { get; set; }

        public ImplementacionDeportiva(int codigoref, string nombre, string marca, string material, float precio)
        {
            CodigoRef = codigoref;
            Nombre = nombre;
            Marca = marca;
            Material = material;
            Precio = precio;
        }

        public ImplementacionDeportiva()
        {

        }

        public void Agregar(ImplementacionDeportiva implementacion, List<ImplementacionDeportiva> lista)
        {
            lista.Add(implementacion);
        }

        public void Eliminar(int CodigoEliminar, List<ImplementacionDeportiva> lista)
        {
            ImplementacionDeportiva implemento = lista.Find(i => i.CodigoRef == CodigoEliminar);

            if(implemento != null)
            {
                lista.Remove(implemento);
            }
        }
    }

}
