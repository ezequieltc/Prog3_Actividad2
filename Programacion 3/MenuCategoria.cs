using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using dominio;
using negocio;

namespace Programacion_3
{
    public partial class MenuCategoria : Form
    {
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        public MenuCategoria()
        {
            InitializeComponent();
        }
        private void MenuCategoria_Load(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = categoriaNegocio.listarCategorias();
            dgvCategoria.Rows[0].Selected = true;
            Categoria seleccion = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            textBoxDescripcion.Text = seleccion.ToString();
        }
        private void ClickEnCelda(object sender, DataGridViewCellEventArgs e)
        {
            Categoria seleccion = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            textBoxDescripcion.Text = seleccion.ToString();
        }

        private void DobleClickDescripcion(object sender, EventArgs e)
        {
            textBoxDescripcion.ReadOnly = false;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(textBoxAgregar.Text.Length > 0 && !Regex.IsMatch(textBoxAgregar.Text, @"^\s"))
            {
                try
                {
                    buttonAgregar.Enabled = true;   
                    categoriaNegocio.agregar(textBoxAgregar.Text);
                    textBoxAgregar.Text = "";
                    MessageBox.Show("Categoría agregada correctamente.");
                    dgvCategoria.DataSource = categoriaNegocio.listarCategorias();
                    dgvCategoria.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("La descripción no puede estar en blanco ni empezar con espacios.");
            }
            
        }

        private void checkBoxEdicion_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDescripcion.Enabled = checkBoxEdicion.Checked;
            buttonGuardar.Enabled = checkBoxEdicion.Checked;


        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Categoria tmpCategoria = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            if (textBoxDescripcion.Text.Length > 0 && !Regex.IsMatch(textBoxDescripcion.Text, @"^\s"))
            {
                try
                {
                    tmpCategoria.Descripcion = textBoxDescripcion.Text;
                    categoriaNegocio.actualizar(tmpCategoria);
                    MessageBox.Show("Categoria actualizada correctamente.");
                    dgvCategoria.DataSource = categoriaNegocio.listarCategorias();
                    dgvCategoria.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("La descripción no puede estar en blanco ni empezar con espacios.");
            }
            
        }

        private void buttonDescartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

