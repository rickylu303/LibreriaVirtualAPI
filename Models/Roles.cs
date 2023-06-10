using System.ComponentModel.DataAnnotations;

namespace LibreriaVirtualWebApi.Models
{
    public class Roles
    {
        [Key]
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }
    }
}
