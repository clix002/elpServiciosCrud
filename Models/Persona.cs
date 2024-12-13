using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El sexo es obligatorio")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        public int Edad { get; set; }
    }
}
