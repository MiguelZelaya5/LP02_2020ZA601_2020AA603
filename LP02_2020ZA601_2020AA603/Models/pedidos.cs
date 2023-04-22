using System.ComponentModel.DataAnnotations;
namespace LP02_2020ZA601_2020AA603.Models
{
    public class pedidos
    {
        [Key]
        [Display(Name = "ID")]
        public int pedidoId { get; set; }
        [Display(Name = "Motorista ID")]
        public  int? motoristaId { get; set; }
        [Display(Name = "Cliente ID")]
        public int? clienteId { get; set; }
        [Display(Name = "Plato ID")]
        public int? platoId { get; set; }
        [Display(Name = "Cantidad")]
        public int? cantidad { get; set; }
        [Display(Name = "Precio")]
        public decimal? precio { get; set; }


    }
}
