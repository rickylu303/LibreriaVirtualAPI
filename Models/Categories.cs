using System.ComponentModel.DataAnnotations;

namespace LibreriaVirtualWebApi.Models
{
    public class Categories
    {
        [Key]
        public int id_categoria { get; set; }
        public string nombre_categoria { get; set; }
    }
}
