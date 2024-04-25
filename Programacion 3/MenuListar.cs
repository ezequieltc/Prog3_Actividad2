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
        }

        private void CambioTexto(object sender, EventArgs e)
        {

        }

        private void ClickEnCelda(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvArticulos.SelectedRows[0];
            textBoxCodigo.Text = filaSeleccionada.Cells["Codigo"].Value.ToString();
            textBoxNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            textBoxDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            numericUpDownPrecio.Value = decimal.Parse(filaSeleccionada.Cells["Precio"].Value.ToString());
        }

        private void ModoEdicion(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = checkBoxEstado.Checked;
            buttonEliminar.Enabled = checkBoxEstado.Checked;
            textBoxCodigo.ReadOnly = !checkBoxEstado.Checked;
            textBoxDescripcion.ReadOnly = !checkBoxEstado.Checked;
            textBoxNombre.ReadOnly = !checkBoxEstado.Checked;
            numericUpDownPrecio.ReadOnly = !checkBoxEstado.Checked;
            comboBoxCategoria.Enabled = checkBoxEstado.Checked;
            comboBoxMarca.Enabled = checkBoxEstado.Checked;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
