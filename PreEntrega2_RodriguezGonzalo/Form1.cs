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

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                string operacion = comboBoxOperaciones.SelectedItem.ToString();
                int id;

                if (!int.TryParse(textBoxParametros.Text, out id) && operacion != "Listar Usuarios" && operacion != "Listar Productos" && operacion != "Listar Productos Vendidos" && operacion != "Listar Ventas")
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
                            Id = id,
                            Nombre = "Nuevo Usuario",
                            Apellido = "Apellido",
                            NombreUsuario = "NuevoUsuario",
                            Contrasenia = "Contraseña",
                            Mail = "mail@example.com"
                        };
                        UsuarioData.CrearUsuario(nuevoUsuario);
                        MessageBox.Show("Usuario creado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Usuario":
                        Usuario usuarioModificado = new Usuario
                        {
                            Id = id,
                            Nombre = "Usuario Modificado",
                            Apellido = "Apellido Modificado",
                            NombreUsuario = "UsuarioModificado",
                            Contrasenia = "NuevaContraseña",
                            Mail = "nuevo@example.com"
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
                            Id = id,
                            Descripcion = "Nuevo Producto",
                            Costo = 100,
                            PrecioVenta = 150,
                            Stock = 50,
                            IdUsuario = 1
                        };
                        ProductoData.CrearProducto(nuevoProducto);
                        MessageBox.Show("Producto creado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Producto":
                        Producto productoModificado = new Producto
                        {
                            Id = id,
                            Descripcion = "Producto Modificado",
                            Costo = 120,
                            PrecioVenta = 170,
                            Stock = 40,
                            IdUsuario = 1
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
                            Id = id,
                            Stock = 10,
                            IdProducto = 1,
                            IdVenta = 1
                        };
                        ProductoVendidoData.CrearProductoVendido(nuevoProductoVendido);
                        MessageBox.Show("Producto vendido creado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Producto Vendido":
                        ProductoVendido productoVendidoModificado = new ProductoVendido
                        {
                            Id = id,
                            Stock = 15,
                            IdProducto = 1,
                            IdVenta = 1
                        };
                        ProductoVendidoData.ModificarProductoVendido(productoVendidoModificado);
                        MessageBox.Show("Producto vendido modificado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Eliminar Producto Vendido":
                        ProductoVendido productoVendidoEliminar = new ProductoVendido { Id = id };
                        ProductoVendidoData.EliminarProducto(productoVendidoEliminar);
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
                            Id = id,
                            Comentarios = "Nueva Venta",
                            IdUsuario = 1
                        };
                        VentaData.CrearVenta(nuevaVenta);
                        MessageBox.Show("Venta creada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Modificar Venta":
                        Venta ventaModificada = new Venta
                        {
                            Id = id,
                            Comentarios = "Venta Modificada",
                            IdUsuario = 1
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
