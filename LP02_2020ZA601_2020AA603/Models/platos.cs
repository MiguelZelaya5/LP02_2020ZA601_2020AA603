using System.ComponentModel.DataAnnotations;
namespace LP02_2020ZA601_2020AA603.Models
{
    public class platos
    {
        [Key]
        [Display(Name = "plato ID")]
        public int platoId { get; set; }
        [Display(Name = "Nombre del plato")]
        public string? nombrePlato { get; set; }
        [Display(Name = "Precio")]
        public double precio { get; set; }
    }
}
