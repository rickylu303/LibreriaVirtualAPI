using System.ComponentModel.DataAnnotations;

namespace LibreriaVirtualWebApi.Models
{
    public class Users
    {
        [Key]
        public int id_usuario { get; set; }
        public string nombre_completo { get; set; }
        public string correo_electronico { get; set; }
        public string contraseña { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
