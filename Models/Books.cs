using System.ComponentModel.DataAnnotations;

namespace LibreriaVirtualWebApi.Models
{
    public class Books
    {
        [Key]
        public int id_libro { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int id_autor { get; set; }
        public int id_editorial { get; set; }
        public int anio_publicacion { get; set; }
        public string imgUrl { get; set; }
    }
}
