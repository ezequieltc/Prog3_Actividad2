namespace Programacion_3
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::Programacion_3.Properties.Resources.buscarIcono;
            resources.ApplyResources(this.buttonBuscar, "buttonBuscar");
            this.buttonBuscar.FlatAppearance.BorderSize = 3;
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = global::Programacion_3.Properties.Resources.editarIcono;
            resources.ApplyResources(this.buttonEditar, "buttonEditar");
            this.buttonEditar.FlatAppearance.BorderSize = 3;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            //this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::Programacion_3.Properties.Resources.eliminarIcono;
            resources.ApplyResources(this.buttonEliminar, "buttonEliminar");
            this.buttonEliminar.FlatAppearance.BorderSize = 3;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            //this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonListado
            // 
            this.buttonListado.BackgroundImage = global::Programacion_3.Properties.Resources.listarIcono;
            resources.ApplyResources(this.buttonListado, "buttonListado");
            this.buttonListado.FlatAppearance.BorderSize = 3;
            this.buttonListado.Name = "buttonListado";
            this.buttonListado.UseVisualStyleBackColor = true;
            this.buttonListado.Click += new System.EventHandler(this.buttonListado_Click);
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button buttonListado;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

