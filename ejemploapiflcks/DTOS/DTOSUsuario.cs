using System;

namespace DTOS
{
    public class DTOSUsuario
    {
        public DTOSUsuario(int id, String contra, string correo)
        {
            IDusuario = id;
            Contrasenia = contra;
            CorreoElectronico = correo;
        }
        public int IDusuario { get; set; }
        public string Contrasenia { get; set; }

        public string CorreoElectronico { get; set; }
    }
}
