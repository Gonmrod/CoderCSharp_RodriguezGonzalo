namespace SistemaGestion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MetroFramework.Controls.MetroComboBox comboBoxOperaciones;
        private MetroFramework.Controls.MetroGrid dataGridViewResultados;
        private System.Windows.Forms.TextBox textBoxParametros;
        private MetroFramework.Controls.MetroButton buttonEjecutar;
        private MetroFramework.Controls.MetroLabel labelParametros;

        // Panels for dynamic inputs
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.TextBox textBoxMail;

        private System.Windows.Forms.Panel panelProducto;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.TextBox textBoxPrecioVenta;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxIdUsuario;

        private System.Windows.Forms.Panel panelProductoVendido;
        private System.Windows.Forms.TextBox textBoxIdProducto;
        private System.Windows.Forms.TextBox textBoxStockVendido;
        private System.Windows.Forms.TextBox textBoxIdVenta;

        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.TextBox textBoxComentarios;
        private System.Windows.Forms.TextBox textBoxIdUsuarioVenta;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            comboBoxOperaciones = new MetroFramework.Controls.MetroComboBox();
            dataGridViewResultados = new MetroFramework.Controls.MetroGrid();
            textBoxParametros = new TextBox();
            buttonEjecutar = new MetroFramework.Controls.MetroButton();
            labelParametros = new MetroFramework.Controls.MetroLabel();
            panelUsuario = new Panel();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombreUsuario = new TextBox();
            textBoxContrasenia = new TextBox();
            textBoxMail = new TextBox();
            panelProducto = new Panel();
            textBoxDescripcion = new TextBox();
            textBoxCosto = new TextBox();
            textBoxPrecioVenta = new TextBox();
            textBoxStock = new TextBox();
            textBoxIdUsuario = new TextBox();
            panelProductoVendido = new Panel();
            textBoxIdProducto = new TextBox();
            textBoxStockVendido = new TextBox();
            textBoxIdVenta = new TextBox();
            panelVenta = new Panel();
            textBoxComentarios = new TextBox();
            textBoxIdUsuarioVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).BeginInit();
            panelUsuario.SuspendLayout();
            panelProducto.SuspendLayout();
            panelProductoVendido.SuspendLayout();
            panelVenta.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxOperaciones
            // 
            comboBoxOperaciones.FormattingEnabled = true;
            comboBoxOperaciones.ItemHeight = 23;
            comboBoxOperaciones.Items.AddRange(new object[] { "Obtener Usuario", "Listar Usuarios", "Crear Usuario", "Modificar Usuario", "Eliminar Usuario", "Obtener Producto", "Listar Productos", "Crear Producto", "Modificar Producto", "Eliminar Producto", "Obtener Producto Vendido", "Listar Productos Vendidos", "Crear Producto Vendido", "Modificar Producto Vendido", "Eliminar Producto Vendido", "Obtener Venta", "Listar Ventas", "Crear Venta", "Modificar Venta", "Eliminar Venta" });
            comboBoxOperaciones.Location = new Point(23, 63);
            comboBoxOperaciones.Name = "comboBoxOperaciones";
            comboBoxOperaciones.Size = new Size(200, 29);
            comboBoxOperaciones.TabIndex = 0;
            comboBoxOperaciones.UseSelectable = true;
            comboBoxOperaciones.SelectedIndexChanged += comboBoxOperaciones_SelectedIndexChanged;
            // 
            // dataGridViewResultados
            // 
            dataGridViewResultados.AllowUserToResizeRows = false;
            dataGridViewResultados.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewResultados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewResultados.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewResultados.EnableHeadersVisualStyles = false;
            dataGridViewResultados.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewResultados.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewResultados.Location = new Point(23, 250);
            dataGridViewResultados.Name = "dataGridViewResultados";
            dataGridViewResultados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewResultados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResultados.Size = new Size(754, 177);
            dataGridViewResultados.TabIndex = 1;
            // 
            // textBoxParametros
            // 
            textBoxParametros.Location = new Point(23, 118);
            textBoxParametros.Name = "textBoxParametros";
            textBoxParametros.Size = new Size(200, 23);
            textBoxParametros.TabIndex = 2;
            // 
            // buttonEjecutar
            // 
            buttonEjecutar.Location = new Point(250, 106);
            buttonEjecutar.Name = "buttonEjecutar";
            buttonEjecutar.Size = new Size(75, 23);
            buttonEjecutar.TabIndex = 3;
            buttonEjecutar.Text = "Ejecutar";
            buttonEjecutar.UseSelectable = true;
            buttonEjecutar.Click += buttonEjecutar_Click;
            // 
            // labelParametros
            // 
            labelParametros.AutoSize = true;
            labelParametros.Location = new Point(23, 95);
            labelParametros.Name = "labelParametros";
            labelParametros.Size = new Size(76, 19);
            labelParametros.TabIndex = 4;
            labelParametros.Text = "Parámetros";
            // 
            // panelUsuario
            // 
            panelUsuario.Controls.Add(textBoxNombre);
            panelUsuario.Controls.Add(textBoxApellido);
            panelUsuario.Controls.Add(textBoxNombreUsuario);
            panelUsuario.Controls.Add(textBoxContrasenia);
            panelUsuario.Controls.Add(textBoxMail);
            panelUsuario.Location = new Point(350, 63);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(400, 200);
            panelUsuario.TabIndex = 5;
            panelUsuario.Visible = false;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(10, 10);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(150, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(10, 40);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.PlaceholderText = "Apellido";
            textBoxApellido.Size = new Size(150, 23);
            textBoxApellido.TabIndex = 1;
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Location = new Point(10, 70);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.PlaceholderText = "Nombre de Usuario";
            textBoxNombreUsuario.Size = new Size(150, 23);
            textBoxNombreUsuario.TabIndex = 2;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Location = new Point(10, 100);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.PlaceholderText = "Contraseña";
            textBoxContrasenia.Size = new Size(150, 23);
            textBoxContrasenia.TabIndex = 3;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(10, 130);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.PlaceholderText = "Mail";
            textBoxMail.Size = new Size(150, 23);
            textBoxMail.TabIndex = 4;
            // 
            // panelProducto
            // 
            panelProducto.Controls.Add(textBoxDescripcion);
            panelProducto.Controls.Add(textBoxCosto);
            panelProducto.Controls.Add(textBoxPrecioVenta);
            panelProducto.Controls.Add(textBoxStock);
            panelProducto.Controls.Add(textBoxIdUsuario);
            panelProducto.Location = new Point(350, 63);
            panelProducto.Name = "panelProducto";
            panelProducto.Size = new Size(400, 200);
            panelProducto.TabIndex = 6;
            panelProducto.Visible = false;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(10, 10);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.PlaceholderText = "Descripción";
            textBoxDescripcion.Size = new Size(150, 23);
            textBoxDescripcion.TabIndex = 0;
            // 
            // textBoxCosto
            // 
            textBoxCosto.Location = new Point(10, 40);
            textBoxCosto.Name = "textBoxCosto";
            textBoxCosto.PlaceholderText = "Costo";
            textBoxCosto.Size = new Size(150, 23);
            textBoxCosto.TabIndex = 1;
            // 
            // textBoxPrecioVenta
            // 
            textBoxPrecioVenta.Location = new Point(10, 70);
            textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            textBoxPrecioVenta.PlaceholderText = "Precio Venta";
            textBoxPrecioVenta.Size = new Size(150, 23);
            textBoxPrecioVenta.TabIndex = 2;
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(10, 100);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.PlaceholderText = "Stock";
            textBoxStock.Size = new Size(150, 23);
            textBoxStock.TabIndex = 3;
            // 
            // textBoxIdUsuario
            // 
            textBoxIdUsuario.Location = new Point(10, 130);
            textBoxIdUsuario.Name = "textBoxIdUsuario";
            textBoxIdUsuario.PlaceholderText = "ID Usuario";
            textBoxIdUsuario.Size = new Size(150, 23);
            textBoxIdUsuario.TabIndex = 4;
            // 
            // panelProductoVendido
            // 
            panelProductoVendido.Controls.Add(textBoxIdProducto);
            panelProductoVendido.Controls.Add(textBoxStockVendido);
            panelProductoVendido.Controls.Add(textBoxIdVenta);
            panelProductoVendido.Location = new Point(350, 63);
            panelProductoVendido.Name = "panelProductoVendido";
            panelProductoVendido.Size = new Size(400, 200);
            panelProductoVendido.TabIndex = 7;
            panelProductoVendido.Visible = false;
            // 
            // textBoxIdProducto
            // 
            textBoxIdProducto.Location = new Point(10, 10);
            textBoxIdProducto.Name = "textBoxIdProducto";
            textBoxIdProducto.PlaceholderText = "ID Producto";
            textBoxIdProducto.Size = new Size(150, 23);
            textBoxIdProducto.TabIndex = 0;
            // 
            // textBoxStockVendido
            // 
            textBoxStockVendido.Location = new Point(10, 40);
            textBoxStockVendido.Name = "textBoxStockVendido";
            textBoxStockVendido.PlaceholderText = "Stock Vendido";
            textBoxStockVendido.Size = new Size(150, 23);
            textBoxStockVendido.TabIndex = 1;
            // 
            // textBoxIdVenta
            // 
            textBoxIdVenta.Location = new Point(10, 70);
            textBoxIdVenta.Name = "textBoxIdVenta";
            textBoxIdVenta.PlaceholderText = "ID Venta";
            textBoxIdVenta.Size = new Size(150, 23);
            textBoxIdVenta.TabIndex = 2;
            // 
            // panelVenta
            // 
            panelVenta.Controls.Add(textBoxComentarios);
            panelVenta.Controls.Add(textBoxIdUsuarioVenta);
            panelVenta.Location = new Point(350, 63);
            panelVenta.Name = "panelVenta";
            panelVenta.Size = new Size(400, 200);
            panelVenta.TabIndex = 8;
            panelVenta.Visible = false;
            // 
            // textBoxComentarios
            // 
            textBoxComentarios.Location = new Point(10, 10);
            textBoxComentarios.Name = "textBoxComentarios";
            textBoxComentarios.PlaceholderText = "Comentarios";
            textBoxComentarios.Size = new Size(150, 23);
            textBoxComentarios.TabIndex = 0;
            // 
            // textBoxIdUsuarioVenta
            // 
            textBoxIdUsuarioVenta.Location = new Point(10, 40);
            textBoxIdUsuarioVenta.Name = "textBoxIdUsuarioVenta";
            textBoxIdUsuarioVenta.PlaceholderText = "ID Usuario";
            textBoxIdUsuarioVenta.Size = new Size(150, 23);
            textBoxIdUsuarioVenta.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(labelParametros);
            Controls.Add(buttonEjecutar);
            Controls.Add(textBoxParametros);
            Controls.Add(dataGridViewResultados);
            Controls.Add(comboBoxOperaciones);
            Controls.Add(panelUsuario);
            Controls.Add(panelProducto);
            Controls.Add(panelProductoVendido);
            Controls.Add(panelVenta);
            Name = "Form1";
            Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            panelProducto.ResumeLayout(false);
            panelProducto.PerformLayout();
            panelProductoVendido.ResumeLayout(false);
            panelProductoVendido.PerformLayout();
            panelVenta.ResumeLayout(false);
            panelVenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
