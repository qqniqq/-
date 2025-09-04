using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TcrbPharmacy.Web.Models;

public class Order
{
    public int Id { get; set; }

    [Required]
    public int MedicineId { get; set; }
    public Medicine? Medicine { get; set; }

    [Required]
    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public OrderStatus Status { get; set; } = OrderStatus.Pending;
}
