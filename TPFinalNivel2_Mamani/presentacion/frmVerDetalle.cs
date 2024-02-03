using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace presentacion
{
    public partial class frmVerDetalle : Form
    {
        public frmVerDetalle()
        {
            InitializeComponent();
        }

        public frmVerDetalle(Articulos articulo)
        {
            InitializeComponent();

            cargarImagen(articulo.ImagenUrl);

            
            StringBuilder detalles = new StringBuilder();
            detalles.AppendLine($"Código: {articulo.Codigo}");
            detalles.AppendLine($"Nombre: {articulo.Nombre}");
            detalles.AppendLine($"Descripción: {articulo.Descripcion}");
            detalles.AppendLine($"ID Marca: {articulo.IdMarca}");
            detalles.AppendLine($"ID Categoría: {articulo.IdCategoria}");
            detalles.AppendLine($"Precio: {articulo.Precio}");

            txtDetalles.Text = detalles.ToString();
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbDetalle.Load(imagen);
            }
            catch (Exception)
            {

                pbDetalle.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBXFep0MuaPmGHNTtX5RrbQnhjiQvlSugEZQ&usqp=CAU");
            }
        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
