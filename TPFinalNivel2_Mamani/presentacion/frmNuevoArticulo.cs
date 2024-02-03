using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;


namespace presentacion
{
    public partial class frmNuevoArticulo : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;
        public frmNuevoArticulo()
        {
            InitializeComponent();
        }

        public frmNuevoArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.IdMarca = (Marcas)cboMarca.SelectedItem;    
                articulo.IdCategoria = (Categorias)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txtImagenUrl.Text;
                
                float Preciof = float.Parse(txtPrecio.Text);
                articulo.Precio = Preciof;


                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    string nombreArchivo = Path.GetFileName(archivo.FileName);
                    string rutaImagenLocal = Path.Combine(ConfigurationManager.AppSettings["images-folder"], nombreArchivo);

                    if(!File.Exists(rutaImagenLocal))
                    {
                        try
                        {
                            File.Copy(archivo.FileName, rutaImagenLocal);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    else
                    { 
                        MessageBox.Show("La imagen ya existe localmente. No se copiará");
                        return;
                    }
                }

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente"); 
                }

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmNuevoArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();
            try
            {

                cboMarca.DataSource = marcanegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categorianegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cboMarca.SelectedValue = articulo.IdMarca.Id;
                    cboCategoria.SelectedValue = articulo.IdCategoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbNuevoArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbNuevoArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBXFep0MuaPmGHNTtX5RrbQnhjiQvlSugEZQ&usqp=CAU");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                archivo = new OpenFileDialog();
                archivo.Filter = "jpg|*.jpg| png|*.png";

                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtImagenUrl.Text = archivo.FileName;
                    cargarImagen(archivo.FileName);
                    
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show($"Error al cargar la imagen: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
    }
       
}
