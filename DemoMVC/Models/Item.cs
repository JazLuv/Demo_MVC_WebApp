using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Item
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Este camoi es requerido ")]
        [StringLength(8, ErrorMessage = "El nombre debe tener entre 3 y 60 caracteres")]
        public string name { get; set; }
        public string type { get; set; }
        [Range(-100, 100, ErrorMessage = "El precio debe estar entre 1 y 100")]
        public int STR { get; set; }
        [Range(-100, 100, ErrorMessage = "El precio debe estar entre 1 y 100")]
        public int AGI { get; set; }
        [Range(-100, 100, ErrorMessage = "El precio debe estar entre 1 y 100")]
        public int INTE { get; set; }
        [Range(-100, 100, ErrorMessage = "El precio debe estar entre 1 y 100")]
        public int MND { get; set; }
        [Range(-100, 100, ErrorMessage = "El precio debe estar entre 1 y 100")]
        public int VIT { get; set; }


    }
}
