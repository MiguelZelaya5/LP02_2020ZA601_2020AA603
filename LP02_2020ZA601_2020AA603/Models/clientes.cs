using System.ComponentModel.DataAnnotations;

namespace LP02_2020ZA601_2020AA603.Models
{
    public class clientes
    {
        [Key]
        public int clienteId { get; set; }
        public string? nombreCliente { get; set; }
        public string? direccion { get; set; }
    }
}
