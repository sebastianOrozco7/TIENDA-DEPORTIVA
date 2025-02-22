namespace TIENDA_DEPORTIVA
{
    partial class VentanaAdministrador
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
            this.comboBoxAdministrador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TexBoxPrendaRopa = new System.Windows.Forms.TextBox();
            this.TexBoxMarcaRopa = new System.Windows.Forms.TextBox();
            this.TexBoxTallaRopa = new System.Windows.Forms.TextBox();
            this.TexBoxColorRopa = new System.Windows.Forms.TextBox();
            this.TexBoxPrecioRopa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNombreImplementacion = new System.Windows.Forms.TextBox();
            this.textBoxMarcaImplementacion = new System.Windows.Forms.TextBox();
            this.textBoxMaterialImplementacion = new System.Windows.Forms.TextBox();
            this.textBoxPrecioImplementacion = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridViewInventarioRopa = new System.Windows.Forms.DataGridView();
            this.dataGridViewInventarioImplementacion = new System.Windows.Forms.DataGridView();
            this.buttonAgregar2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCodigoRopa = new System.Windows.Forms.TextBox();
            this.textBoxCodigoImplementacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxElimarRopa = new System.Windows.Forms.TextBox();
            this.textBoxElimarImplemento = new System.Windows.Forms.TextBox();
            this.buttonEliminarRopa = new System.Windows.Forms.Button();
            this.buttonEliminarImplemento = new System.Windows.Forms.Button();
            this.panelRopa = new System.Windows.Forms.Panel();
            this.panelImplementacion = new System.Windows.Forms.Panel();
            this.panelEliminar = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarioRopa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarioImplementacion)).BeginInit();
            this.panelRopa.SuspendLayout();
            this.panelImplementacion.SuspendLayout();
            this.panelEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAdministrador
            // 
            this.comboBoxAdministrador.FormattingEnabled = true;
            this.comboBoxAdministrador.Items.AddRange(new object[] {
            "Agregar",
            "Eliminar"});
            this.comboBoxAdministrador.Location = new System.Drawing.Point(237, 12);
            this.comboBoxAdministrador.Name = "comboBoxAdministrador";
            this.comboBoxAdministrador.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdministrador.TabIndex = 0;
            this.comboBoxAdministrador.Text = "Opciones";
            this.comboBoxAdministrador.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdministrador_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenda: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Talla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio:";
            // 
            // TexBoxPrendaRopa
            // 
            this.TexBoxPrendaRopa.Location = new System.Drawing.Point(62, 29);
            this.TexBoxPrendaRopa.Name = "TexBoxPrendaRopa";
            this.TexBoxPrendaRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxPrendaRopa.TabIndex = 8;
            // 
            // TexBoxMarcaRopa
            // 
            this.TexBoxMarcaRopa.Location = new System.Drawing.Point(62, 55);
            this.TexBoxMarcaRopa.Name = "TexBoxMarcaRopa";
            this.TexBoxMarcaRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxMarcaRopa.TabIndex = 9;
            // 
            // TexBoxTallaRopa
            // 
            this.TexBoxTallaRopa.Location = new System.Drawing.Point(62, 80);
            this.TexBoxTallaRopa.Name = "TexBoxTallaRopa";
            this.TexBoxTallaRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxTallaRopa.TabIndex = 10;
            // 
            // TexBoxColorRopa
            // 
            this.TexBoxColorRopa.Location = new System.Drawing.Point(62, 106);
            this.TexBoxColorRopa.Name = "TexBoxColorRopa";
            this.TexBoxColorRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxColorRopa.TabIndex = 11;
            // 
            // TexBoxPrecioRopa
            // 
            this.TexBoxPrecioRopa.Location = new System.Drawing.Point(62, 132);
            this.TexBoxPrecioRopa.Name = "TexBoxPrecioRopa";
            this.TexBoxPrecioRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxPrecioRopa.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Material: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Precio:";
            // 
            // textBoxNombreImplementacion
            // 
            this.textBoxNombreImplementacion.Location = new System.Drawing.Point(56, 30);
            this.textBoxNombreImplementacion.Name = "textBoxNombreImplementacion";
            this.textBoxNombreImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreImplementacion.TabIndex = 17;
            // 
            // textBoxMarcaImplementacion
            // 
            this.textBoxMarcaImplementacion.Location = new System.Drawing.Point(56, 52);
            this.textBoxMarcaImplementacion.Name = "textBoxMarcaImplementacion";
            this.textBoxMarcaImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarcaImplementacion.TabIndex = 18;
            // 
            // textBoxMaterialImplementacion
            // 
            this.textBoxMaterialImplementacion.Location = new System.Drawing.Point(56, 78);
            this.textBoxMaterialImplementacion.Name = "textBoxMaterialImplementacion";
            this.textBoxMaterialImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterialImplementacion.TabIndex = 19;
            // 
            // textBoxPrecioImplementacion
            // 
            this.textBoxPrecioImplementacion.Location = new System.Drawing.Point(56, 104);
            this.textBoxPrecioImplementacion.Name = "textBoxPrecioImplementacion";
            this.textBoxPrecioImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioImplementacion.TabIndex = 20;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(67, 192);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 21;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridViewInventarioRopa
            // 
            this.dataGridViewInventarioRopa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventarioRopa.Location = new System.Drawing.Point(33, 286);
            this.dataGridViewInventarioRopa.Name = "dataGridViewInventarioRopa";
            this.dataGridViewInventarioRopa.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewInventarioRopa.TabIndex = 22;
            // 
            // dataGridViewInventarioImplementacion
            // 
            this.dataGridViewInventarioImplementacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventarioImplementacion.Location = new System.Drawing.Point(357, 286);
            this.dataGridViewInventarioImplementacion.Name = "dataGridViewInventarioImplementacion";
            this.dataGridViewInventarioImplementacion.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewInventarioImplementacion.TabIndex = 23;
            // 
            // buttonAgregar2
            // 
            this.buttonAgregar2.Location = new System.Drawing.Point(56, 189);
            this.buttonAgregar2.Name = "buttonAgregar2";
            this.buttonAgregar2.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar2.TabIndex = 24;
            this.buttonAgregar2.Text = "AGREGAR";
            this.buttonAgregar2.UseVisualStyleBackColor = true;
            this.buttonAgregar2.Click += new System.EventHandler(this.buttonAgregar2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Codigo: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Codigo:";
            // 
            // textBoxCodigoRopa
            // 
            this.textBoxCodigoRopa.Location = new System.Drawing.Point(62, 158);
            this.textBoxCodigoRopa.Name = "textBoxCodigoRopa";
            this.textBoxCodigoRopa.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoRopa.TabIndex = 27;
            // 
            // textBoxCodigoImplementacion
            // 
            this.textBoxCodigoImplementacion.Location = new System.Drawing.Point(56, 130);
            this.textBoxCodigoImplementacion.Name = "textBoxCodigoImplementacion";
            this.textBoxCodigoImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoImplementacion.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "ROPA DEPORTIVA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "IMPLEMENTACION DEPORTIVA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Codigo de prenda a eliminar: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Codigo de implemento a eliminar:";
            // 
            // textBoxElimarRopa
            // 
            this.textBoxElimarRopa.Location = new System.Drawing.Point(153, 42);
            this.textBoxElimarRopa.Name = "textBoxElimarRopa";
            this.textBoxElimarRopa.Size = new System.Drawing.Size(65, 20);
            this.textBoxElimarRopa.TabIndex = 33;
            // 
            // textBoxElimarImplemento
            // 
            this.textBoxElimarImplemento.Location = new System.Drawing.Point(165, 68);
            this.textBoxElimarImplemento.Name = "textBoxElimarImplemento";
            this.textBoxElimarImplemento.Size = new System.Drawing.Size(63, 20);
            this.textBoxElimarImplemento.TabIndex = 34;
            // 
            // buttonEliminarRopa
            // 
            this.buttonEliminarRopa.Location = new System.Drawing.Point(234, 37);
            this.buttonEliminarRopa.Name = "buttonEliminarRopa";
            this.buttonEliminarRopa.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarRopa.TabIndex = 35;
            this.buttonEliminarRopa.Text = "ELIMINAR";
            this.buttonEliminarRopa.UseVisualStyleBackColor = true;
            this.buttonEliminarRopa.Click += new System.EventHandler(this.buttonEliminarRopa_Click);
            // 
            // buttonEliminarImplemento
            // 
            this.buttonEliminarImplemento.Location = new System.Drawing.Point(234, 66);
            this.buttonEliminarImplemento.Name = "buttonEliminarImplemento";
            this.buttonEliminarImplemento.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarImplemento.TabIndex = 36;
            this.buttonEliminarImplemento.Text = "ELIMINAR";
            this.buttonEliminarImplemento.UseVisualStyleBackColor = true;
            this.buttonEliminarImplemento.Click += new System.EventHandler(this.buttonEliminarImplemento_Click);
            // 
            // panelRopa
            // 
            this.panelRopa.Controls.Add(this.label2);
            this.panelRopa.Controls.Add(this.label3);
            this.panelRopa.Controls.Add(this.label13);
            this.panelRopa.Controls.Add(this.TexBoxPrendaRopa);
            this.panelRopa.Controls.Add(this.TexBoxMarcaRopa);
            this.panelRopa.Controls.Add(this.label4);
            this.panelRopa.Controls.Add(this.label5);
            this.panelRopa.Controls.Add(this.label6);
            this.panelRopa.Controls.Add(this.label11);
            this.panelRopa.Controls.Add(this.textBoxCodigoRopa);
            this.panelRopa.Controls.Add(this.TexBoxTallaRopa);
            this.panelRopa.Controls.Add(this.TexBoxColorRopa);
            this.panelRopa.Controls.Add(this.TexBoxPrecioRopa);
            this.panelRopa.Controls.Add(this.buttonAgregar);
            this.panelRopa.Location = new System.Drawing.Point(47, 62);
            this.panelRopa.Name = "panelRopa";
            this.panelRopa.Size = new System.Drawing.Size(200, 218);
            this.panelRopa.TabIndex = 37;
            // 
            // panelImplementacion
            // 
            this.panelImplementacion.Controls.Add(this.label14);
            this.panelImplementacion.Controls.Add(this.label7);
            this.panelImplementacion.Controls.Add(this.label8);
            this.panelImplementacion.Controls.Add(this.label9);
            this.panelImplementacion.Controls.Add(this.label10);
            this.panelImplementacion.Controls.Add(this.label12);
            this.panelImplementacion.Controls.Add(this.textBoxNombreImplementacion);
            this.panelImplementacion.Controls.Add(this.textBoxMarcaImplementacion);
            this.panelImplementacion.Controls.Add(this.buttonAgregar2);
            this.panelImplementacion.Controls.Add(this.textBoxCodigoImplementacion);
            this.panelImplementacion.Controls.Add(this.textBoxMaterialImplementacion);
            this.panelImplementacion.Controls.Add(this.textBoxPrecioImplementacion);
            this.panelImplementacion.Location = new System.Drawing.Point(363, 62);
            this.panelImplementacion.Name = "panelImplementacion";
            this.panelImplementacion.Size = new System.Drawing.Size(200, 215);
            this.panelImplementacion.TabIndex = 38;
            // 
            // panelEliminar
            // 
            this.panelEliminar.Controls.Add(this.label17);
            this.panelEliminar.Controls.Add(this.label15);
            this.panelEliminar.Controls.Add(this.label16);
            this.panelEliminar.Controls.Add(this.textBoxElimarRopa);
            this.panelEliminar.Controls.Add(this.buttonEliminarImplemento);
            this.panelEliminar.Controls.Add(this.textBoxElimarImplemento);
            this.panelEliminar.Controls.Add(this.buttonEliminarRopa);
            this.panelEliminar.Location = new System.Drawing.Point(599, 91);
            this.panelEliminar.Name = "panelEliminar";
            this.panelEliminar.Size = new System.Drawing.Size(329, 97);
            this.panelEliminar.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(91, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "ELIMINAR ELEMENTOS";
            // 
            // VentanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.panelEliminar);
            this.Controls.Add(this.panelImplementacion);
            this.Controls.Add(this.panelRopa);
            this.Controls.Add(this.dataGridViewInventarioImplementacion);
            this.Controls.Add(this.dataGridViewInventarioRopa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAdministrador);
            this.Name = "VentanaAdministrador";
            this.Text = "VentanaAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarioRopa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarioImplementacion)).EndInit();
            this.panelRopa.ResumeLayout(false);
            this.panelRopa.PerformLayout();
            this.panelImplementacion.ResumeLayout(false);
            this.panelImplementacion.PerformLayout();
            this.panelEliminar.ResumeLayout(false);
            this.panelEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAdministrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TexBoxPrendaRopa;
        private System.Windows.Forms.TextBox TexBoxMarcaRopa;
        private System.Windows.Forms.TextBox TexBoxTallaRopa;
        private System.Windows.Forms.TextBox TexBoxColorRopa;
        private System.Windows.Forms.TextBox TexBoxPrecioRopa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNombreImplementacion;
        private System.Windows.Forms.TextBox textBoxMarcaImplementacion;
        private System.Windows.Forms.TextBox textBoxMaterialImplementacion;
        private System.Windows.Forms.TextBox textBoxPrecioImplementacion;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridViewInventarioRopa;
        private System.Windows.Forms.DataGridView dataGridViewInventarioImplementacion;
        private System.Windows.Forms.Button buttonAgregar2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCodigoRopa;
        private System.Windows.Forms.TextBox textBoxCodigoImplementacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxElimarRopa;
        private System.Windows.Forms.TextBox textBoxElimarImplemento;
        private System.Windows.Forms.Button buttonEliminarRopa;
        private System.Windows.Forms.Button buttonEliminarImplemento;
        private System.Windows.Forms.Panel panelRopa;
        private System.Windows.Forms.Panel panelImplementacion;
        private System.Windows.Forms.Panel panelEliminar;
        private System.Windows.Forms.Label label17;
    }
}