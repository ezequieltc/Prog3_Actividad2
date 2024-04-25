namespace Programacion_3
{
    partial class MenuListar
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.numericUpDownPrecio = new System.Windows.Forms.NumericUpDown();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltrarNombre = new System.Windows.Forms.TextBox();
            this.txtFiltrarMarca = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 102);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(765, 336);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickEnCelda);
            // 
            // labelDetalles
            // 
            this.labelDetalles.AutoSize = true;
            this.labelDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalles.Location = new System.Drawing.Point(12, 444);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(96, 25);
            this.labelDetalles.TabIndex = 1;
            this.labelDetalles.Text = "Detalles:";
            // 
            // numericUpDownPrecio
            // 
            this.numericUpDownPrecio.DecimalPlaces = 2;
            this.numericUpDownPrecio.Location = new System.Drawing.Point(239, 591);
            this.numericUpDownPrecio.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numericUpDownPrecio.Name = "numericUpDownPrecio";
            this.numericUpDownPrecio.ReadOnly = true;
            this.numericUpDownPrecio.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrecio.TabIndex = 24;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(236, 574);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(40, 13);
            this.labelPrecio.TabIndex = 23;
            this.labelPrecio.Text = "Precio:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Enabled = false;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(239, 539);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(183, 21);
            this.comboBoxCategoria.TabIndex = 22;
            this.comboBoxCategoria.SelectedValueChanged += new System.EventHandler(this.CambioTexto);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Categoria:";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.Enabled = false;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Iphone",
            "Xiaomi",
            "Santi"});
            this.comboBoxMarca.Location = new System.Drawing.Point(239, 493);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(183, 21);
            this.comboBoxMarca.TabIndex = 20;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(236, 476);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 19;
            this.labelMarca.Text = "Marca:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(17, 595);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ReadOnly = true;
            this.textBoxDescripcion.Size = new System.Drawing.Size(183, 20);
            this.textBoxDescripcion.TabIndex = 18;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(14, 579);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelDescripcion.TabIndex = 17;
            this.labelDescripcion.Text = "Descripción:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(17, 545);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(183, 20);
            this.textBoxNombre.TabIndex = 16;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(14, 529);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 15;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(17, 493);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(183, 20);
            this.textBoxCodigo.TabIndex = 14;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(14, 477);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 13;
            this.labelCodigo.Text = "Código:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.Location = new System.Drawing.Point(17, 641);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 25;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Location = new System.Drawing.Point(98, 641);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 26;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(211, 645);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(91, 17);
            this.checkBoxEstado.TabIndex = 27;
            this.checkBoxEstado.Text = "Modo Edicion";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.ModoEdicion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nombre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Marca:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Categoria:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(21, 61);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 38;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFiltrarNombre
            // 
            this.txtFiltrarNombre.Location = new System.Drawing.Point(108, 19);
            this.txtFiltrarNombre.Name = "txtFiltrarNombre";
            this.txtFiltrarNombre.ReadOnly = true;
            this.txtFiltrarNombre.Size = new System.Drawing.Size(183, 20);
            this.txtFiltrarNombre.TabIndex = 39;
            this.txtFiltrarNombre.TextChanged += new System.EventHandler(this.txtFiltrarNombre_TextChanged);
            // 
            // txtFiltrarMarca
            // 
            this.txtFiltrarMarca.Location = new System.Drawing.Point(309, 19);
            this.txtFiltrarMarca.Name = "txtFiltrarMarca";
            this.txtFiltrarMarca.ReadOnly = true;
            this.txtFiltrarMarca.Size = new System.Drawing.Size(183, 20);
            this.txtFiltrarMarca.TabIndex = 40;
            this.txtFiltrarMarca.TextChanged += new System.EventHandler(this.txtFiltrarMarca_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(572, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 41;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // MenuListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 681);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtFiltrarMarca);
            this.Controls.Add(this.txtFiltrarNombre);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.numericUpDownPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelDetalles);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "MenuListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Articulos";
            this.Load += new System.EventHandler(this.MenuListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltrarNombre;
        private System.Windows.Forms.TextBox txtFiltrarMarca;
        private System.Windows.Forms.TextBox textBox3;
    }
}