using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Modelos
{
    public class Venta
    {
        #region Atributos
        private int _id;
        private string _comentarios;
        private int _idUsuario;
        #endregion

        #region Constructor

        public Venta() { }
        public Venta(int id, string comentario, int idUsuario)
        {
            _id = id;
            _comentarios = comentario;
            _idUsuario = idUsuario;
        }
        #endregion

        #region Propiedades
        public int Id { get; set; }
        public string Comentarios { get { return _comentarios; } set { _comentarios = value; } }
        public int IdUsuario { get; set; }
        #endregion

    }
}