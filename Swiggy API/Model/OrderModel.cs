using System.ComponentModel.DataAnnotations;

namespace Swiggy_API.Model
{
    public class OrderModel
    {
        [Key]
       public Guid OrderId { get; set; }
       public string? Status { get; set; }
       public int ProductId { get; set; }
       public int UserId { get; set; }
        public int Quantity { get; set; }
    }
}
