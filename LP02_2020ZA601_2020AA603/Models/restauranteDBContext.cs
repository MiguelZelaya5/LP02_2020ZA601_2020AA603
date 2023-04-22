using Microsoft.EntityFrameworkCore;
namespace LP02_2020ZA601_2020AA603.Models
{
    public class restauranteDBContext:DbContext
    {
        public restauranteDBContext(DbContextOptions options) : base(options) 
        {

        }
    }
}
