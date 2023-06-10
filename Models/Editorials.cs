using System.ComponentModel.DataAnnotations;

namespace LibreriaVirtualWebApi.Models
{
    public class Editorials
    {
        [Key]
        public int id_editorial { get; set; }
        public string nombre_editorial { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}
