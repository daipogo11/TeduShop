using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(250)]
        [Required]
        public string CustomerName { get; set; }

        [MaxLength(250)]
        public string CustomerAddress { get; set; }

        [MaxLength(250)]
        public string CustomerEmail { get; set; }

        [MaxLength(50)]
        public string CustomerMoible { get; set; }

        [MaxLength(250)]
        public string CustomerMessage { get; set; }

        [MaxLength(250)]
        public string PaymentMethod { get; set; }

        [MaxLength(50)]
        public string PaymentStatus { get; set; }
    }
}