﻿using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Programacion_3
{
    public partial class MenuMarca : Form
    {
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        public MenuMarca()
        {
            InitializeComponent();
        }
        private void MenuMarca_Load(object sender, EventArgs e)
        {
            dgvMarca.DataSource = marcaNegocio.listarMarcas();
            dgvMarca.Rows[0].Selected = true;
            Marca seleccion = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            textBoxDescripcion.Text = seleccion.ToString();
        }
        private void ClickEnCelda(object sender, DataGridViewCellEventArgs e)
        {
            Marca seleccion = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            textBoxDescripcion.Text = seleccion.ToString();
        }

        private void DobleClickDescripcion(object sender, EventArgs e)
        {
            textBoxDescripcion.ReadOnly = false;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxAgregar.Text.Length > 0 && !Regex.IsMatch(textBoxAgregar.Text, @"^\s"))
            {
                try
                {
                    marcaNegocio.agregar(textBoxAgregar.Text);
                    textBoxAgregar.Text = "";
                    dgvMarca.DataSource = marcaNegocio.listarMarcas();
                    dgvMarca.Refresh();
                    MessageBox.Show("Marca ingresada correctamente.");
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

        private void checkBoxEdicion_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDescripcion.Enabled = checkBoxEdicion.Checked;

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (textBoxDescripcion.Text.Length > 0 && !Regex.IsMatch(textBoxDescripcion.Text, @"^\s"))
            {
                try
                {

                    Marca tmpMarca = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                    tmpMarca.Descripcion = textBoxDescripcion.Text;
                    marcaNegocio.actualizar(tmpMarca);
                    MessageBox.Show("Marca actualizada correctamente.");
                    dgvMarca.DataSource = marcaNegocio.listarMarcas();
                    dgvMarca.Refresh();
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
