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
        private List<Articulo> listaArticulos;
        private List<Imagen> listaImagenes;
        private List<Imagen> listaImagenesSelec = new List<Imagen>();
        private List<Marca> Marcas = new List<Marca>();
        private List<Categoria> Categorias = new List<Categoria>();
        private int contadorImg = 1;
        public MenuListar()
        {
            InitializeComponent();

        }

        private void MenuListar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio load = new ArticuloNegocio();
            listaArticulos = load.listarArticulos();
            dgvArticulos.DataSource = listaArticulos;
            MarcaNegocio loadMarca = new MarcaNegocio();
            Marcas= loadMarca.listarMarcas();
            CategoriaNegocio loadCategoria = new CategoriaNegocio();
            Categorias = loadCategoria.listarCategorias();
            ImagenNegocio loadImagenes = new ImagenNegocio();
            listaImagenes = loadImagenes.listarImagenes();
            comboBoxCategoria.DataSource = Categorias;
            comboBoxMarca.DataSource = Marcas;
        }


        private void ClickEnCelda(object sender, DataGridViewCellEventArgs e)
        {
            contadorImg = 1;
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            listaImagenesSelec.Clear();
            textBoxCodigo.Text = seleccion.Codigo;
            textBoxNombre.Text = seleccion.Nombre;
            textBoxDescripcion.Text = seleccion.Descripcion;
            numericUpDownPrecio.Value = seleccion.Precio;
            comboBoxMarca.Text = seleccion.Marca.ToString();
            comboBoxCategoria.Text = seleccion.Categoria.ToString();
            foreach(Imagen img in listaImagenes)
            {
                if (img.IdArticulo == seleccion.Id)
                {
                    listaImagenesSelec.Add(img);
                }
            }
            cargarImagen(listaImagenesSelec[contadorImg-1].UrlImagen);
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artTmp = new ArticuloNegocio();
            DataGridViewRow filaSeleccionada = dgvArticulos.SelectedRows[0];
            Articulo tmpArticulo = new Articulo();
            tmpArticulo.Id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());

            tmpArticulo.Codigo = textBoxCodigo.Text;
            tmpArticulo.Descripcion = textBoxDescripcion.Text;
            tmpArticulo.Nombre = textBoxNombre.Text;
            tmpArticulo.Marca = (Marca)comboBoxMarca.SelectedItem;
            tmpArticulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
            tmpArticulo.Precio = numericUpDownPrecio.Value;
            try
            {
                artTmp.actualizar(tmpArticulo);
                dgvArticulos.DataSource = artTmp.listarArticulos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el articulo\n" + ex.ToString());
            }


        }

        private  void cargarImagen(string direccion) 
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pictureBoxItem.Load(direccion);
              }
            catch(Exception ex)
            {
                pictureBoxItem.Load("https://t4.ftcdn.net/jpg/04/73/25/49/360_F_473254957_bxG9yf4ly7OBO5I0O5KABlN930GwaMQz.jpg");
            }

        }
        private void buttonSiguienteImg_Click(object sender, EventArgs e)
        {
            if (contadorImg < listaImagenesSelec.Count())
            {
                contadorImg += 1;
                labelImg.Text = contadorImg.ToString();
                cargarImagen(listaImagenesSelec[contadorImg-1].UrlImagen);
            }

        }

        private void buttonAnteriorImg_Click(object sender, EventArgs e)
        {
            if (contadorImg > 1)
            {
                contadorImg -= 1;
                labelImg.Text = contadorImg.ToString();
                cargarImagen(listaImagenesSelec[contadorImg - 1].UrlImagen);
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            string seleccion = comboBoxMarca.Text;
            bool nuevo = true;
            foreach(Marca marca in Marcas)
            {
                if (marca.Descripcion.Equals(seleccion))
                {
                    nuevo = false;
                }
            }
            if (nuevo) 
            { 
                Console.WriteLine("Marca nueva - " + seleccion);
                DialogResult result =  MessageBox.Show("Desea agregar la marca " + seleccion + "?", "Agregar Marca" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        MarcaNegocio tmpMarca = new MarcaNegocio();
                        tmpMarca.agregar(seleccion);
                        Marcas = tmpMarca.listarMarcas();
                        comboBoxMarca.DataSource = Marcas;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar nueva Marca\n" + ex.ToString(), "Error");
                    }
                }
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string seleccion = comboBoxCategoria.Text;
            bool nuevo = true;
            foreach (Categoria categoria in Categorias)
            {
                if (categoria.Descripcion.Equals(seleccion))
                {
                    nuevo = false;
                }
            }
            if (nuevo)
            {
                DialogResult result = MessageBox.Show("Desea agregar la categoria " + seleccion + "?", "Agregar Categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        CategoriaNegocio tmpCateforia = new CategoriaNegocio();
                        tmpCateforia.agregar(seleccion);
                        Categorias = tmpCateforia.listarCategorias();
                        comboBoxCategoria.DataSource = Categorias;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar nueva Categoria\n" + ex.ToString(), "Error");
                    }
                }
            }
        }
    }
}
