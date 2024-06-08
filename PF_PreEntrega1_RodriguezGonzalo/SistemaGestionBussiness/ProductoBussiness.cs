using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> ObtenerProducto(int idProducto)
        {
            try
            {
                return ProductoData.ObtenerProducto(idProducto);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener el Producto", ex);
            }
        }

        public static List<Producto> ListarProductos()
        {
            try
            {
                return ProductoData.ListarProductos();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar los Productos", ex);
            }
        }

        public static void CrearProducto(Producto producto)
        {
            try
            {
                ProductoData.CrearProducto(producto);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al crear el Producto", ex);
            }
        }

        public static void ModificarProducto(Producto producto)
        {
            try
            {
                ProductoData.ModificarProducto(producto);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al modificar el Producto", ex);
            }
        }

        public static void EliminarProducto(Producto producto)
        {
            try
            {
                ProductoData.EliminarProducto(producto);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar el Producto", ex);
            }

        }
    }
}
