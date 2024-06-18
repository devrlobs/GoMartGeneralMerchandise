using System.ComponentModel.DataAnnotations;

namespace GoMartWebApp.Models
{
    public class ShippingInfo
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
    }
}
