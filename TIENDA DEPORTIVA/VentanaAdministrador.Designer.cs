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
            this.comboBoxOpcionesAgregar = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarioRopa)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAdministrador
            // 
            this.comboBoxAdministrador.FormattingEnabled = true;
            this.comboBoxAdministrador.Items.AddRange(new object[] {
            "Agregar",
            "Eliminar"});
            this.comboBoxAdministrador.Location = new System.Drawing.Point(53, 37);
            this.comboBoxAdministrador.Name = "comboBoxAdministrador";
            this.comboBoxAdministrador.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdministrador.TabIndex = 0;
            this.comboBoxAdministrador.Text = "Opciones";
            this.comboBoxAdministrador.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdministrador_SelectedIndexChanged);
            // 
            // comboBoxOpcionesAgregar
            // 
            this.comboBoxOpcionesAgregar.FormattingEnabled = true;
            this.comboBoxOpcionesAgregar.Items.AddRange(new object[] {
            "Ropa Deportiva",
            "Implementacion Deportiva"});
            this.comboBoxOpcionesAgregar.Location = new System.Drawing.Point(53, 81);
            this.comboBoxOpcionesAgregar.Name = "comboBoxOpcionesAgregar";
            this.comboBoxOpcionesAgregar.Size = new System.Drawing.Size(137, 21);
            this.comboBoxOpcionesAgregar.TabIndex = 1;
            this.comboBoxOpcionesAgregar.Text = "Opciones de Agregar";
            this.comboBoxOpcionesAgregar.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpcionesAgregar_SelectedIndexChanged);
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
            this.label2.Location = new System.Drawing.Point(53, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenda: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Talla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio:";
            // 
            // TexBoxPrendaRopa
            // 
            this.TexBoxPrendaRopa.Location = new System.Drawing.Point(119, 186);
            this.TexBoxPrendaRopa.Name = "TexBoxPrendaRopa";
            this.TexBoxPrendaRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxPrendaRopa.TabIndex = 8;
            // 
            // TexBoxMarcaRopa
            // 
            this.TexBoxMarcaRopa.Location = new System.Drawing.Point(119, 213);
            this.TexBoxMarcaRopa.Name = "TexBoxMarcaRopa";
            this.TexBoxMarcaRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxMarcaRopa.TabIndex = 9;
            // 
            // TexBoxTallaRopa
            // 
            this.TexBoxTallaRopa.Location = new System.Drawing.Point(119, 241);
            this.TexBoxTallaRopa.Name = "TexBoxTallaRopa";
            this.TexBoxTallaRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxTallaRopa.TabIndex = 10;
            // 
            // TexBoxColorRopa
            // 
            this.TexBoxColorRopa.Location = new System.Drawing.Point(119, 269);
            this.TexBoxColorRopa.Name = "TexBoxColorRopa";
            this.TexBoxColorRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxColorRopa.TabIndex = 11;
            // 
            // TexBoxPrecioRopa
            // 
            this.TexBoxPrecioRopa.Location = new System.Drawing.Point(119, 296);
            this.TexBoxPrecioRopa.Name = "TexBoxPrecioRopa";
            this.TexBoxPrecioRopa.Size = new System.Drawing.Size(100, 20);
            this.TexBoxPrecioRopa.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Material: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Precio:";
            // 
            // textBoxNombreImplementacion
            // 
            this.textBoxNombreImplementacion.Location = new System.Drawing.Point(338, 183);
            this.textBoxNombreImplementacion.Name = "textBoxNombreImplementacion";
            this.textBoxNombreImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreImplementacion.TabIndex = 17;
            // 
            // textBoxMarcaImplementacion
            // 
            this.textBoxMarcaImplementacion.Location = new System.Drawing.Point(338, 213);
            this.textBoxMarcaImplementacion.Name = "textBoxMarcaImplementacion";
            this.textBoxMarcaImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarcaImplementacion.TabIndex = 18;
            // 
            // textBoxMaterialImplementacion
            // 
            this.textBoxMaterialImplementacion.Location = new System.Drawing.Point(338, 241);
            this.textBoxMaterialImplementacion.Name = "textBoxMaterialImplementacion";
            this.textBoxMaterialImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterialImplementacion.TabIndex = 19;
            // 
            // textBoxPrecioImplementacion
            // 
            this.textBoxPrecioImplementacion.Location = new System.Drawing.Point(338, 269);
            this.textBoxPrecioImplementacion.Name = "textBoxPrecioImplementacion";
            this.textBoxPrecioImplementacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecioImplementacion.TabIndex = 20;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(135, 352);
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
            this.dataGridViewInventarioRopa.Location = new System.Drawing.Point(400, 12);
            this.dataGridViewInventarioRopa.Name = "dataGridViewInventarioRopa";
            this.dataGridViewInventarioRopa.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewInventarioRopa.TabIndex = 22;
            // 
            // VentanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.dataGridViewInventarioRopa);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxPrecioImplementacion);
            this.Controls.Add(this.textBoxMaterialImplementacion);
            this.Controls.Add(this.textBoxMarcaImplementacion);
            this.Controls.Add(this.textBoxNombreImplementacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TexBoxPrecioRopa);
            this.Controls.Add(this.TexBoxColorRopa);
            this.Controls.Add(this.TexBoxTallaRopa);
            this.Controls.Add(this.TexBoxMarcaRopa);
            this.Controls.Add(this.TexBoxPrendaRopa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOpcionesAgregar);
            this.Controls.Add(this.comboBoxAdministrador);
            this.Name = "VentanaAdministrador";
            this.Text = "VentanaAdministrador";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventarioRopa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAdministrador;
        private System.Windows.Forms.ComboBox comboBoxOpcionesAgregar;
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
    }
}