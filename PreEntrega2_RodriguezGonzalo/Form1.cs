using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clases.Modelos;
using PreEntrega2_RodriguezGonzalo.Clases.DDBB;

namespace PreEntrega2_RodriguezGonzalo
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void comboBoxOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operacion = comboBoxOperaciones.SelectedItem.ToString();
            HideAllPanels();
            textBoxParametros.ReadOnly = false;

            switch (operacion)
            {
                case "Crear Usuario":
                case "Modificar Usuario":
                    panelUsuario.Visible = true;
                    break;

                case "Crear Producto":
                case "Modificar Producto":
                    panelProducto.Visible = true;
                    break;

                case "Crear Producto Vendido":
                case "Modificar Producto Vendido":
                    panelProductoVendido.Visible = true;
                    break;

                case "Crear Venta":
                case "Modificar Venta":
                    panelVenta.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void HideAllPanels()
        {
            panelUsuario.Visible = false;
            panelProducto.Visible = false;
            panelProductoVendido.Visible = false;
            panelVenta.Visible = false;
        }

        private void dataGridViewResultados_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewResultados.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewResultados.SelectedRows[0];
                textBoxParametros.Text = selectedRow.Cells["Id"].Value.ToString();
                textBoxParametros.ReadOnly = true;

                switch (comboBoxOperaciones.SelectedItem.ToString())
                {
                    case "Modificar Usuario":
                        textBoxNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                        textBoxApellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
                        textBoxNombreUsuario.Text = selectedRow.Cells["NombreUsuario"].Value.ToString();
                        textBoxContrasenia.Text = selectedRow.Cells["Contraseña"].Value.ToString();
                        textBoxMail.Text = selectedRow.Cells["Mail"].Value.ToString();
                        break;

                    case "Modificar Producto":
                        textBoxDescripcion.Text = selectedRow.Cells["Descripciones"].Value.ToString();
                        textBoxCosto.Text = selectedRow.Cells["Costo"].Value.ToString();
                        textBoxPrecioVenta.Text = selectedRow.Cells["PrecioVenta"].Value.ToString();
                        textBoxStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                        textBoxIdUsuario.Text = selectedRow.Cells["IdUsuario"].Value.ToString();
                        break;

                    case "Modificar Producto Vendido":
                        textBoxIdProducto.Text = selectedRow.Cells["IdProducto"].Value.ToString();
                        textBoxStockVendido.Text = selectedRow.Cells["Stock"].Value.ToString();
                        textBoxIdVenta.Text = selectedRow.Cells["IdVenta"].Value.ToString();
                        break;

                    case "Modificar Venta":
                        textBoxComentarios.Text = selectedRow.Cells["Comentarios"].Value.ToString();
                        textBoxIdUsuarioVenta.Text = selectedRow.Cells["IdUsuario"].Value.ToString();
                        break;
                }
            }
        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                string operacion = comboBoxOperaciones.SelectedItem.ToString();
                int id = 0;

                if (!int.TryParse(textBoxParametros.Text, out id) && (operacion.Contains("Obtener") || operacion.Contains("Eliminar") || operacion.Contains("Modificar")))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (operacion)
                {
                    case "Obtener Usuario":
                        List<Usuario> usuarios = UsuarioData.ObtenerUsuario(id);
                        dataGridViewResultados.DataSource = usuarios;
                        break;

                    case "Listar Usuarios":
                        List<Usuario> listaUsuarios = UsuarioData.ListarUsuarios();
                        dataGridViewResultados.DataSource = listaUsuarios;
                        break;

                    case "Crear Usuario":
                        Usuario nuevoUsuario = new Usuario
                        {
                            Nombre = textBoxNombre.Text,
                            Apellido = textBoxApellido.Text,
                            NombreUsuario = textBoxNombreUsuario.Text,
                            Contrasenia = textBoxContrasenia.Text,
                            Mail = textBoxMail.Text
                        };
                        UsuarioData.CrearUsuario(nuevoUsuario);
                        MessageBox.Show("Usuario creado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Usuario":
                        Usuario usuarioModificado = new Usuario
                        {
                            Id = id,
                            Nombre = textBoxNombre.Text,
                            Apellido = textBoxApellido.Text,
                            NombreUsuario = textBoxNombreUsuario.Text,
                            Contrasenia = textBoxContrasenia.Text,
                            Mail = textBoxMail.Text
                        };
                        UsuarioData.ModificarUsuario(usuarioModificado);
                        MessageBox.Show("Usuario modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Eliminar Usuario":
                        Usuario usuarioEliminar = new Usuario { Id = id };
                        UsuarioData.EliminarUsuario(usuarioEliminar);
                        MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Obtener Producto":
                        List<Producto> productos = ProductoData.ObtenerProducto(id);
                        dataGridViewResultados.DataSource = productos;
                        break;

                    case "Listar Productos":
                        List<Producto> listaProductos = ProductoData.ListarProductos();
                        dataGridViewResultados.DataSource = listaProductos;
                        break;

                    case "Crear Producto":
                        Producto nuevoProducto = new Producto
                        {
                            Descripcion = textBoxDescripcion.Text,
                            Costo = Convert.ToDouble(textBoxCosto.Text),
                            PrecioVenta = Convert.ToDouble(textBoxPrecioVenta.Text),
                            Stock = Convert.ToInt32(textBoxStock.Text),
                            IdUsuario = Convert.ToInt32(textBoxIdUsuario.Text)
                        };
                        ProductoData.CrearProducto(nuevoProducto);
                        MessageBox.Show("Producto creado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Producto":
                        Producto productoModificado = new Producto
                        {
                            Id = id,
                            Descripcion = textBoxDescripcion.Text,
                            Costo = Convert.ToDouble(textBoxCosto.Text),
                            PrecioVenta = Convert.ToDouble(textBoxPrecioVenta.Text),
                            Stock = Convert.ToInt32(textBoxStock.Text),
                            IdUsuario = Convert.ToInt32(textBoxIdUsuario.Text)
                        };
                        ProductoData.ModificarProducto(productoModificado);
                        MessageBox.Show("Producto modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Eliminar Producto":
                        Producto productoEliminar = new Producto { Id = id };
                        ProductoData.EliminarProducto(productoEliminar);
                        MessageBox.Show("Producto eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Obtener Producto Vendido":
                        List<ProductoVendido> productosVendidos = ProductoVendidoData.ObtenerProductoVendido(id);
                        dataGridViewResultados.DataSource = productosVendidos;
                        break;

                    case "Listar Productos Vendidos":
                        List<ProductoVendido> listaProductosVendidos = ProductoVendidoData.ListarProductosVendidos();
                        dataGridViewResultados.DataSource = listaProductosVendidos;
                        break;

                    case "Crear Producto Vendido":
                        ProductoVendido nuevoProductoVendido = new ProductoVendido
                        {
                            IdProducto = Convert.ToInt32(textBoxIdProducto.Text),
                            Stock = Convert.ToInt32(textBoxStockVendido.Text),
                            IdVenta = Convert.ToInt32(textBoxIdVenta.Text)
                        };
                        ProductoVendidoData.CrearProductoVendido(nuevoProductoVendido);
                        MessageBox.Show("Producto vendido creado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Producto Vendido":
                        ProductoVendido productoVendidoModificado = new ProductoVendido
                        {
                            Id = id,
                            IdProducto = Convert.ToInt32(textBoxIdProducto.Text),
                            Stock = Convert.ToInt32(textBoxStockVendido.Text),
                            IdVenta = Convert.ToInt32(textBoxIdVenta.Text)
                        };
                        ProductoVendidoData.ModificarProductoVendido(productoVendidoModificado);
                        MessageBox.Show("Producto vendido modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Eliminar Producto Vendido":
                        ProductoVendido productoVendidoEliminar = new ProductoVendido { Id = id };
                        ProductoVendidoData.EliminarProductoVendido(productoVendidoEliminar);
                        MessageBox.Show("Producto vendido eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Obtener Venta":
                        List<Venta> ventas = VentaData.ObtenerVenta(id);
                        dataGridViewResultados.DataSource = ventas;
                        break;

                    case "Listar Ventas":
                        List<Venta> listaVentas = VentaData.ListarVentas();
                        dataGridViewResultados.DataSource = listaVentas;
                        break;

                    case "Crear Venta":
                        Venta nuevaVenta = new Venta
                        {
                            Comentarios = textBoxComentarios.Text,
                            IdUsuario = Convert.ToInt32(textBoxIdUsuarioVenta.Text)
                        };
                        VentaData.CrearVenta(nuevaVenta);
                        MessageBox.Show("Venta creada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Venta":
                        Venta ventaModificada = new Venta
                        {
                            Id = id,
                            Comentarios = textBoxComentarios.Text,
                            IdUsuario = Convert.ToInt32(textBoxIdUsuarioVenta.Text)
                        };
                        VentaData.ModificarVenta(ventaModificada);
                        MessageBox.Show("Venta modificada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Eliminar Venta":
                        Venta ventaEliminar = new Venta { Id = id };
                        VentaData.EliminarVenta(ventaEliminar);
                        MessageBox.Show("Venta eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("Operación no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
