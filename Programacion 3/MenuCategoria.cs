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
        public MenuCategoria()
        {
            InitializeComponent();
        }
        private void MenuCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
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
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            if(textBoxAgregar.Text.Length > 0 && !Regex.IsMatch(textBoxAgregar.Text, @"^\s"))
            {
                try
                {
                    categoriaNegocio.agregar(textBoxAgregar.Text);
                    textBoxAgregar.Text = "";
                    dgvCategoria.DataSource = categoriaNegocio.listarCategorias();
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
            
        }
    }
}

