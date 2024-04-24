using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }



        private void buttonListado_Click(object sender, EventArgs e)
        {
            foreach (Form menu in Application.OpenForms)
            {
                if (menu.GetType() == typeof(MenuListar))
                {
                    menu.BringToFront();
                    return;
                }
            }
            MenuListar ventanaMenuListar = new MenuListar();
            ventanaMenuListar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form menu in Application.OpenForms)
            {
                if (menu.GetType()== typeof(MenuAgregar))
                {
                    menu.BringToFront();
                    return;
                }
            }
            MenuAgregar ventanaMenuAgregar = new MenuAgregar();
            ventanaMenuAgregar.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            foreach (Form menu in Application.OpenForms)
            {
                if (menu.GetType() == typeof(MenuEliminar))
                {
                    menu.BringToFront();
                    return;
                }
            }
            MenuEliminar ventanaMenuEliminar = new MenuEliminar();
            ventanaMenuEliminar.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            foreach (Form menu in Application.OpenForms)
            {
                if (menu.GetType() == typeof(MenuEditar))
                {
                    menu.BringToFront();
                    return;
                }
            }
            MenuEditar ventanaMenuEditar = new MenuEditar();
            ventanaMenuEditar.Show();
        }
    }
}
