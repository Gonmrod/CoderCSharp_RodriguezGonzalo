using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Modelos
{
    public class ProductoVendido
    {

        #region Atributos
        //En este caso creo atributos a los efectos de accederlos solo por clases, y en caso de modificarlos, lo haré mediante alguna propiedad o método público
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        #endregion

        #region Contructor

        public ProductoVendido () { }
        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            _id = id;
            _idProducto = idProducto;
            _stock = stock;
            _idVenta = idVenta;
        }

        #endregion

        #region Propiedades
        public int Id { get { return _id; } set { _id = value; } }
        public int IdProducto { get { return _idProducto; } set { _idProducto = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public int IdVenta { get {  return _idVenta; } set { _idVenta = value; } }

        #endregion

    }
}
