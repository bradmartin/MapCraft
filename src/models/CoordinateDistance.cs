using System.ComponentModel.DataAnnotations;

namespace nStudio.Models
{
    public class CoordinateDistance
    {
        [Required]
        public decimal long_1 { get; set; }
        [Required]
        public decimal lat_1 { get; set; }
        [Required]
        public decimal long_2 { get; set; }
        [Required]
        public decimal lat_2 { get; set; }
    }
}