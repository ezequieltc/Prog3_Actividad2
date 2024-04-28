namespace Programacion_3
{
    partial class MenuMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxEdicion = new System.Windows.Forms.CheckBox();
            this.textBoxAgregar = new System.Windows.Forms.TextBox();
            this.buttonDescartar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxEdicion
            // 
            this.checkBoxEdicion.AutoSize = true;
            this.checkBoxEdicion.Location = new System.Drawing.Point(24, 314);
            this.checkBoxEdicion.Name = "checkBoxEdicion";
            this.checkBoxEdicion.Size = new System.Drawing.Size(91, 17);
            this.checkBoxEdicion.TabIndex = 27;
            this.checkBoxEdicion.Text = "Modo Edicion";
            this.checkBoxEdicion.UseVisualStyleBackColor = true;
            // 
            // textBoxAgregar
            // 
            this.textBoxAgregar.Location = new System.Drawing.Point(112, 66);
            this.textBoxAgregar.Name = "textBoxAgregar";
            this.textBoxAgregar.Size = new System.Drawing.Size(269, 20);
            this.textBoxAgregar.TabIndex = 26;
            this.toolTip.SetToolTip(this.textBoxAgregar, "Indique el nombre de la categoria a agregar");
            // 
            // buttonDescartar
            // 
            this.buttonDescartar.Location = new System.Drawing.Point(274, 418);
            this.buttonDescartar.Name = "buttonDescartar";
            this.buttonDescartar.Size = new System.Drawing.Size(88, 27);
            this.buttonDescartar.TabIndex = 25;
            this.buttonDescartar.Text = "Descartar";
            this.buttonDescartar.UseVisualStyleBackColor = true;
            this.buttonDescartar.Click += new System.EventHandler(this.buttonDescartar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(40, 418);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(88, 27);
            this.buttonGuardar.TabIndex = 24;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Descripcion:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(24, 367);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(358, 20);
            this.textBoxDescripcion.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Detalle:";
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarca.Location = new System.Drawing.Point(24, 108);
            this.dgvMarca.MultiSelect = false;
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(358, 150);
            this.dgvMarca.TabIndex = 20;
            this.dgvMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickEnCelda);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(18, 62);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(88, 27);
            this.buttonAgregar.TabIndex = 19;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Marca:";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.Color.Bisque;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 100;
            // 
            // MenuMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 480);
            this.Controls.Add(this.checkBoxEdicion);
            this.Controls.Add(this.textBoxAgregar);
            this.Controls.Add(this.buttonDescartar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label1);
            this.Name = "MenuMarca";
            this.Text = "AgregarMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEdicion;
        private System.Windows.Forms.TextBox textBoxAgregar;
        private System.Windows.Forms.Button buttonDescartar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}