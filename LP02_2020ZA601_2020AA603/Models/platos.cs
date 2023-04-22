using System.ComponentModel.DataAnnotations;
namespace LP02_2020ZA601_2020AA603.Models
{
    public class platos
    {
        [Key]
        public int platoId { get; set; }
        public string? nombrePlato { get; set; }
        public double precio { get; set; }
    }
}
