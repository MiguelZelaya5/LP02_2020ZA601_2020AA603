using System.ComponentModel.DataAnnotations;
namespace LP02_2020ZA601_2020AA603.Models
{
    public class pedidos
    {
        [Key]
        public int pedidoId { get; set; }

        public  int? motoristaId { get; set; }
        public int? clienteId { get; set; }

        public int? platoId { get; set; }
        public int? cantidad { get; set; }
        public double? precio { get; set; }


    }
}
