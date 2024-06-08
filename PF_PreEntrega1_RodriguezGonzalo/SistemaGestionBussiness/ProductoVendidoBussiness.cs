using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int idProductoVendido)
        {
            try
            {
                return ProductoVendidoData.ObtenerProductoVendido(idProductoVendido);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener el Producto Vendido", ex);
            }
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            try
            {
                return ProductoVendidoData.ListarProductosVendidos();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar los Productos Vendidos", ex);
            }
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                ProductoVendidoData.CrearProductoVendido(productoVendido);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al crear el Producto Vendido", ex);
            }
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                ProductoVendidoData.ModificarProductoVendido(productoVendido);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al modificar el Producto Vendido", ex);
            }
        }

        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            try
            {
                ProductoVendidoData.EliminarProductoVendido(productoVendido);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar el Producto Vendido", ex);
            }

        }
    }
}
