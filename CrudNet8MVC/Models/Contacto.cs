using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo oficio es obligatorio")]
        public string Oficio { get; set; }

        [Required(ErrorMessage = "El campo teléfono es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo email es obligatorio")]
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }



    }
}

