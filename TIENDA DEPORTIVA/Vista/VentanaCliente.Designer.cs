namespace TIENDA_DEPORTIVA
{
    partial class VentanaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoProductoRopa = new System.Windows.Forms.TextBox();
            this.textBoxUnidadesCompradasRopa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalCompraRopa = new System.Windows.Forms.Label();
            this.dataGridViewRopaCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewImplementacionCliente = new System.Windows.Forms.DataGridView();
            this.buttonenviarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRopaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImplementacionCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidades:";
            // 
            // textBoxCodigoProductoRopa
            // 
            this.textBoxCodigoProductoRopa.Location = new System.Drawing.Point(216, 64);
            this.textBoxCodigoProductoRopa.Name = "textBoxCodigoProductoRopa";
            this.textBoxCodigoProductoRopa.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoProductoRopa.TabIndex = 2;
//            this.textBoxCodigoProductoRopa.TextChanged += new System.EventHandler(this.textBoxCodigoProducto_TextChanged);
            // 
            // textBoxUnidadesCompradasRopa
            // 
            this.textBoxUnidadesCompradasRopa.Location = new System.Drawing.Point(216, 100);
            this.textBoxUnidadesCompradasRopa.Name = "textBoxUnidadesCompradasRopa";
            this.textBoxUnidadesCompradasRopa.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnidadesCompradasRopa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor total:";
            // 
            // TotalCompraRopa
            // 
            this.TotalCompraRopa.AutoSize = true;
            this.TotalCompraRopa.Location = new System.Drawing.Point(185, 179);
            this.TotalCompraRopa.Name = "TotalCompraRopa";
            this.TotalCompraRopa.Size = new System.Drawing.Size(25, 13);
            this.TotalCompraRopa.TabIndex = 5;
            this.TotalCompraRopa.Text = "$$$";
            // 
            // dataGridViewRopaCliente
            // 
            this.dataGridViewRopaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRopaCliente.Location = new System.Drawing.Point(410, 36);
            this.dataGridViewRopaCliente.Name = "dataGridViewRopaCliente";
            this.dataGridViewRopaCliente.Size = new System.Drawing.Size(320, 177);
            this.dataGridViewRopaCliente.TabIndex = 6;
            // 
            // dataGridViewImplementacionCliente
            // 
            this.dataGridViewImplementacionCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImplementacionCliente.Location = new System.Drawing.Point(410, 253);
            this.dataGridViewImplementacionCliente.Name = "dataGridViewImplementacionCliente";
            this.dataGridViewImplementacionCliente.Size = new System.Drawing.Size(320, 173);
            this.dataGridViewImplementacionCliente.TabIndex = 7;
            // 
            // buttonenviarCliente
            // 
            this.buttonenviarCliente.Location = new System.Drawing.Point(109, 136);
            this.buttonenviarCliente.Name = "buttonenviarCliente";
            this.buttonenviarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonenviarCliente.TabIndex = 8;
            this.buttonenviarCliente.Text = "Enviar";
            this.buttonenviarCliente.UseVisualStyleBackColor = true;
            this.buttonenviarCliente.Click += new System.EventHandler(this.buttonenviarCliente_Click);
            // 
            // VentanaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonenviarCliente);
            this.Controls.Add(this.dataGridViewImplementacionCliente);
            this.Controls.Add(this.dataGridViewRopaCliente);
            this.Controls.Add(this.TotalCompraRopa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUnidadesCompradasRopa);
            this.Controls.Add(this.textBoxCodigoProductoRopa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaCliente";
            this.Text = "VentanaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRopaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImplementacionCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoProductoRopa;
        private System.Windows.Forms.TextBox textBoxUnidadesCompradasRopa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalCompraRopa;
        private System.Windows.Forms.DataGridView dataGridViewRopaCliente;
        private System.Windows.Forms.DataGridView dataGridViewImplementacionCliente;
        private System.Windows.Forms.Button buttonenviarCliente;
    }
}