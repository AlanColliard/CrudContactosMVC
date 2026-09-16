using System.ComponentModel.DataAnnotations;

namespace CrudContactosMVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(100, ErrorMessage ="El nombre no puede tener más de 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El Correo no tiene un formato válido")]
        [StringLength(150)]
        public string Correo { get; set; }

        [Phone(ErrorMessage = "El formato del teléfono no es válido")]
        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(250)]
        public string? Direccion { get; set; }
    }
}
