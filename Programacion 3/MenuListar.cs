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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Programacion_3
{
    public partial class MenuListar : Form
    {
        
        public MenuListar()
        {
            InitializeComponent();

        }

        private void MenuListar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio load = new ArticuloNegocio();
            
            dgvArticulos.DataSource = load.listarArticulos();
            MarcaNegocio loadMarca = new MarcaNegocio();
            List<Marca> Marcas= loadMarca.listarMarcas();
            CategoriaNegocio loadCategoria = new CategoriaNegocio();
            List<Categoria> Categorias = loadCategoria.listarCategorias();
            comboBoxCategoria.DataSource = Categorias;
            comboBoxMarca.DataSource = Marcas;
        }

        private void CambioTexto(object sender, EventArgs e)
        {

        }

        private void ClickEnCelda(object sender, DataGridViewCellEventArgs e)
        {
            //Marca tmpmarca = new Marca();
            //Categoria tmpCat = new Categoria();
            //Articulo tmpArticulo = new Articulo();
            DataGridViewRow filaSeleccionada = dgvArticulos.SelectedRows[0];
            textBoxCodigo.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
            //tmpArticulo.Codigo = filaSeleccionada.Cells["Codigo"].Value.ToString();
            textBoxNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            //tmpArticulo.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
            textBoxDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            //tmpArticulo.Descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            numericUpDownPrecio.Value = decimal.Parse(filaSeleccionada.Cells["Precio"].Value.ToString());
            //tmpArticulo.Precio = decimal.Parse(filaSeleccionada.Cells["Precio"].Value.ToString());
            comboBoxMarca.Text = filaSeleccionada.Cells["Marca"].Value.ToString();
            //tmpmarca.Descripcion = filaSeleccionada.Cells["Marca"].Value.ToString();
            //tmpArticulo.Marca = tmpmarca;
            comboBoxCategoria.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
            //tmpArticulo.Categoria.Descripcion = filaSeleccionada.Cells["Categoria"].Value.ToString();

        }

        private void ModoEdicion(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = checkBoxEstado.Checked;
            buttonEliminar.Enabled = checkBoxEstado.Checked;
            textBoxCodigo.ReadOnly = !checkBoxEstado.Checked;
            textBoxCodigo.Enabled = checkBoxEstado.Checked;
            textBoxDescripcion.ReadOnly = !checkBoxEstado.Checked;
            textBoxDescripcion.Enabled = checkBoxEstado.Checked;
            textBoxNombre.ReadOnly = !checkBoxEstado.Checked;
            textBoxNombre.Enabled = checkBoxEstado.Checked;
            numericUpDownPrecio.ReadOnly = !checkBoxEstado.Checked;
            comboBoxCategoria.Enabled = checkBoxEstado.Checked;
            comboBoxMarca.Enabled = checkBoxEstado.Checked;
        }

        private void CambioMarcaFil(object sender, EventArgs e)
        {
            //    BoxMarcaFiltro.Items.Clear();
            //    foreach (string marca in marcas)
            //    {
            //        if (marca.StartsWith(BoxMarcaFiltro.Text, StringComparison.CurrentCultureIgnoreCase))
            //        {
            //            BoxMarcaFiltro.Items.Add(marca);
            //        }
            //    }
            //    BoxMarcaFiltro.SelectionStart = BoxMarcaFiltro.Text.Length;
            //    BoxMarcaFiltro.SelectionLength = 0;
        }

        private void CambioCategoria(object sender, EventArgs e)
        {
        //    comboBoxCat.Items.Clear();
        //    foreach (string categoria in categorias)
        //    {
        //        if (categoria.StartsWith(comboBoxCat.Text, StringComparison.CurrentCultureIgnoreCase))
        //        {
        //            comboBoxCat.Items.Add(categoria);
        //        }
        //        
        //    }
        //    comboBoxCat.SelectionLength = 0;
        //    comboBoxCat.SelectionStart = comboBoxCat.Text.Length;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Articulo tmpArticulo = new Articulo();
            tmpArticulo.Codigo = textBoxCodigo.Text;
            tmpArticulo.Descripcion = textBoxDescripcion.Text;
            tmpArticulo.Nombre = textBoxNombre.Text;
            tmpArticulo.Marca = (Marca)comboBoxMarca.SelectedItem;
            tmpArticulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;

        }
    }
}
