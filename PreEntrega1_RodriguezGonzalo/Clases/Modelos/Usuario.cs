using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Modelos
{

    public class Usuario
    {

    #region Propiedades
        //Se crean las propiedades con modificador protected, dado que interpreto que tendremos varios tipos de usuarios, y así podremos realizar la correspondiente herencia.

        protected int Id {  get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string NombreUsuario { get; set; }
        protected string Contrasenia { get; set; }
        protected string Mail { get; set; }

        #endregion

    #region Constructor
    //Constructor

    public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string Mail )
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.NombreUsuario = nombreUsuario;
        this.Contrasenia = contrasenia;
        this.Mail = Mail;
    }
    #endregion

    }
}
