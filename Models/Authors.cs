using System.ComponentModel.DataAnnotations;

namespace LibreriaVirtualWebApi.Models
{
    public class Authors
    {
        [Key]
        public int id_autor { get; set; }
        public string nombre_autor { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_defuncion { get; set; }
    }
}
