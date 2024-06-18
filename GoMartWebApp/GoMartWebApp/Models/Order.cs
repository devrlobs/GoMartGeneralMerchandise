using System.ComponentModel.DataAnnotations;

namespace GoMartWebApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public ShippingInfo ShippingInfo { get; set; } = null!;
        public List<Product> Products { get; set; } = null!;
    }
}
