using System.ComponentModel.DataAnnotations;

namespace MediatRCQRSDemo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "CustomerNumber is required")]
        [Range(1, int.MaxValue, ErrorMessage = "CustomerNumber must be greater than zero")]
        public int CustomerNumber { get; set; }

        [StringLength(20)]
        [Required]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(15)]
        [Required]
        public string Mobile { get; set; }
    }
}
