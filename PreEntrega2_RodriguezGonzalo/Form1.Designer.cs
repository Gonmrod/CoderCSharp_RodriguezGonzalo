namespace PreEntrega2_RodriguezGonzalo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MetroFramework.Controls.MetroComboBox comboBoxOperaciones;
        private MetroFramework.Controls.MetroGrid dataGridViewResultados;
        private System.Windows.Forms.TextBox textBoxParametros;
        private MetroFramework.Controls.MetroButton buttonEjecutar;
        private MetroFramework.Controls.MetroLabel labelParametros;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxOperaciones = new MetroFramework.Controls.MetroComboBox();
            this.dataGridViewResultados = new MetroFramework.Controls.MetroGrid();
            this.textBoxParametros = new System.Windows.Forms.TextBox();
            this.buttonEjecutar = new MetroFramework.Controls.MetroButton();
            this.labelParametros = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOperaciones
            // 
            this.comboBoxOperaciones.FormattingEnabled = true;
            this.comboBoxOperaciones.Items.AddRange(new object[] {
            "Obtener Usuario",
            "Listar Usuarios",
            "Crear Usuario",
            "Modificar Usuario",
            "Eliminar Usuario",
            "Obtener Producto",
            "Listar Productos",
            "Crear Producto",
            "Modificar Producto",
            "Eliminar Producto",
            "Obtener Producto Vendido",
            "Listar Productos Vendidos",
            "Crear Producto Vendido",
            "Modificar Producto Vendido",
            "Eliminar Producto Vendido",
            "Obtener Venta",
            "Listar Ventas",
            "Crear Venta",
            "Modificar Venta",
            "Eliminar Venta"});
            this.comboBoxOperaciones.Location = new System.Drawing.Point(23, 63);
            this.comboBoxOperaciones.Name = "comboBoxOperaciones";
            this.comboBoxOperaciones.Size = new System.Drawing.Size(200, 29);
            this.comboBoxOperaciones.TabIndex = 0;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(23, 150);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(754, 277);
            this.dataGridViewResultados.TabIndex = 1;
            // 
            // textBoxParametros
            // 
            this.textBoxParametros.Location = new System.Drawing.Point(23, 108);
            this.textBoxParametros.Name = "textBoxParametros";
            this.textBoxParametros.Size = new System.Drawing.Size(200, 23);
            this.textBoxParametros.TabIndex = 2;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(250, 106);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 3;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseSelectable = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // labelParametros
            // 
            this.labelParametros.AutoSize = true;
            this.labelParametros.Location = new System.Drawing.Point(23, 86);
            this.labelParametros.Name = "labelParametros";
            this.labelParametros.Size = new System.Drawing.Size(70, 19);
            this.labelParametros.TabIndex = 4;
            this.labelParametros.Text = "Parámetros";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelParametros);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.textBoxParametros);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.comboBoxOperaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
