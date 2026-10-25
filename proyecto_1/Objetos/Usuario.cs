using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_1.Objetos
{
    internal class Usuario
    {
        public int id { get; set; }
        public string NomUsr { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public int idRol { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int Estado { get; set; }

    }
}
