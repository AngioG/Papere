using System.ComponentModel.DataAnnotations;
using Papere.Decorators;

namespace Papere.Models
{
    public class Papera
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }   

        [MaxValue]
        public int Ali { get; set; }
    }
}
