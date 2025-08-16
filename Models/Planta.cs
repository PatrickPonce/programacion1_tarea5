using System.ComponentModel.DataAnnotations;

namespace PROGRAMACION1_TAREA5.Models
{
    public class Planta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Origen { get; set; }

        public string Especie { get; set; }

        public decimal AlturaMaxima { get; set; }

        public string Notas { get; set; }

        public string Imagen { get; set; }
    }
}
