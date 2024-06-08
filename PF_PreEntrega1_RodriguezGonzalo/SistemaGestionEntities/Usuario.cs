using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Usuario
    {

    #region Propiedades
        //Se crean las propiedades con modificador protected, dado que interpreto que tendremos varios tipos de usuarios, y así podremos realizar la correspondiente herencia.

        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Mail { get; set; }

        #endregion

    #region Constructor
    //Constructor

    public Usuario() { }
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
