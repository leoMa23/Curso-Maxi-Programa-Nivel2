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
using dominio;

namespace presentacion
{
    public partial class frmMain : Form
    {
        //Aca guardo los datos que obtengo de la base de datos
        private List<Articulos> listaArticulo;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Celulares");
            cboCampo.Items.Add("Televisores");
            cboCampo.Items.Add("Audio");
            cboCampo.Items.Add("Media");
            cboCampo2.Items.Add("Samsung");
            cboCampo2.Items.Add("Apple");
            cboCampo2.Items.Add("Sony");
            cboCampo2.Items.Add("Huawei");
            cboCampo2.Items.Add("Motorola");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch (Exception)
            {

                pbArticulos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTBXFep0MuaPmGHNTtX5RrbQnhjiQvlSugEZQ&usqp=CAU");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoArticulo alta = new frmNuevoArticulo();
            alta.ShowDialog();
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado;
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                frmNuevoArticulo modificar = new frmNuevoArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres eliminarlo?","Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }

            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado;
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

                frmVerDetalle detalle = new frmVerDetalle(seleccionado);
                detalle.ShowDialog();
                cargar();
            }

        }

        private bool validarFiltroUp()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione la categoria para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un rango de precio para filtrar");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() != null)
            {
                if(!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Solo números para filtrar un precio.");
                    return true;
                }
            }


            return false;
        }

        private bool validarFiltroDown()
        {
            if (cboCampo2.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione la categoria para filtrar.");
                return true;
            }
            if (cboCriterio2.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un rango de precio para filtrar");
                return true;
            }
            if (cboCampo2.SelectedItem.ToString() != null)
            {
                if(string.IsNullOrEmpty(txtFiltro2.Text))
                {
                    MessageBox.Show("Debes cargar el filtro con un precio..");
                    return true;
                }
                if (!(soloNumeros(txtFiltro2.Text)))
                {
                    MessageBox.Show("Solo números para filtrar un precio...");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltroUp())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                
                dgvArticulos.DataSource = negocio.filtrarUp(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        
        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltroDown())
                    return;
                string campo = cboCampo2.SelectedItem.ToString();
                string criterio = cboCriterio2.SelectedItem.ToString();
                string filtro = txtFiltro2.Text;
                
                dgvArticulos.DataSource = negocio.filtrarDown(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

            List<Articulos> listaFiltrada;
            string filtro = txtBuscador.Text;

            if(filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.IdCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
        
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            cboCriterio.Items.Clear();
            cboCriterio.Items.Add("Mayor a");
            cboCriterio.Items.Add("Menor a");
            cboCriterio.Items.Add("Igual a");
        }

        private void cboCampo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo2.SelectedItem.ToString();
            cboCriterio2.Items.Clear();
            cboCriterio2.Items.Add("Mayor a");
            cboCriterio2.Items.Add("Menor a");
            cboCriterio2.Items.Add("Igual a");
        }

        
    }
}
