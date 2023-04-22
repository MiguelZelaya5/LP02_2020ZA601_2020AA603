using System.ComponentModel.DataAnnotations;

namespace LP02_2020ZA601_2020AA603.Models
{
    public class motoristas
    {
        [Key]
        public int motoritaId {get; set;}
        public string nombreMotorista { get; set;}
    }
}
