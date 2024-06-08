using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> ObtenerVenta(int idVenta)
        {
            try
            {
                return VentaData.ObtenerVenta(idVenta);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener el Venta", ex);
            }
        }

        public static List<Venta> ListarVentas()
        {
            try
            {
                return VentaData.ListarVentas();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al listar los Ventas", ex);
            }
        }

        public static void CrearVenta(Venta venta)
        {
            try
            {
                VentaData.CrearVenta(venta);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al crear el Venta", ex);
            }
        }

        public static void ModificarVenta(Venta venta)
        {
            try
            {
                VentaData.ModificarVenta(venta);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al modificar el Venta", ex);
            }
        }

        public static void EliminarVenta(Venta venta)
        {
            try
            {
                VentaData.EliminarVenta(venta);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar el Venta", ex);
            }

        }
    }
}
