using System.ComponentModel.DataAnnotations;

namespace GoMartWebApp.Models
{
    public class OrderRequest
    {
        [Key]
        public int Id { get; set; }
        public ShippingInfo ShippingInfo { get; set; } = new ShippingInfo();
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
