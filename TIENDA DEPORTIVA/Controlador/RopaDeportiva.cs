using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_DEPORTIVA.Controlador
{
    internal class RopaDeportiva
    {
        public int CodigoRef { get; set; }
        public string Prenda {  get; set; }
        public string Marca {  get; set; }
        public string Talla { get; set; }
        public string Color {  get; set; }
        public float Precio { get; set; }

        public RopaDeportiva(int CodigoRef, string Prenda, string Marca, string Talla, string Color, float Precio)
        {
            this.CodigoRef = CodigoRef;
            this.Prenda = Prenda;
            this.Marca = Marca;
            this.Talla = Talla;
            this.Color = Color;
            this.Precio = Precio;
        }

        public RopaDeportiva()
        {

        }

        public void Agregar(RopaDeportiva ropa, List<RopaDeportiva> lista)
        {
            lista.Add(ropa);
        }

        public void Eliminar(int CodigoEliminar, List<RopaDeportiva> lista)
        {
            RopaDeportiva prenda = lista.Find(i => i.CodigoRef == CodigoEliminar);

            if (prenda != null)
            {
                lista.Remove(prenda);
            }
        }

    }
}
