using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using dominio;
using negocio;
using System.Text.RegularExpressions;
namespace Programacion_3
{
    public partial class MenuAgregar : Form
    {
        public MenuAgregar()
        {
            InitializeComponent();
        }
        private void MenuAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio loadNegocio = new CategoriaNegocio();
            comboBoxCategoria.DataSource = loadNegocio.listarCategorias();
            MarcaNegocio loadMarca = new MarcaNegocio();
            comboBoxMarca.DataSource = loadMarca.listarMarcas();

        }

        private void buttonDescartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CambioItem(object sender, EventArgs e)
        {
            try
            {
                pictureBoxImagen.Load(listBoxNombres.Text);
            }
            catch(Exception ex)
            {
                pictureBoxImagen.Image = Properties.Resources.noImage;
            }
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            buscarArchivo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            buscarArchivo.ShowDialog();
            string[] seleccion = buscarArchivo.FileNames;
            foreach(string archivo in seleccion)
            {
                if (!Regex.IsMatch(archivo, @"\.(jpg|jpeg|png)$"))
                {
                    MessageBox.Show("Solo se permiten archivos de imagen.");
                    return;
                }
                else
                {
                    listBoxNombres.Items.Add(archivo);
                }

            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            List<string> listaImagenes = new List<string>();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo nuevoArticulo = new Articulo();
            nuevoArticulo.Codigo = textBoxCodigo.Text;
            nuevoArticulo.Descripcion = textBoxDescripcion.Text;
            nuevoArticulo.Nombre = textBoxNombre.Text;
            nuevoArticulo.Precio = numericUpDownPrecio.Value;
            nuevoArticulo.Marca = (Marca)comboBoxMarca.SelectedItem;
            nuevoArticulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
            foreach(string item in listBoxNombres.Items)
            {
                listaImagenes.Add(item);
            }
            if (listaImagenes.Count() != 0)
            {
                int id = articuloNegocio.insertar(nuevoArticulo);
                try { 
                    imagenNegocio.insertar(listaImagenes, id);
                    MessageBox.Show("Articulo agregado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Se necesita agregar una o más imagenes");
            }

            
        }
    }
}
