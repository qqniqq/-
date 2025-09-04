using System.ComponentModel.DataAnnotations;

namespace TcrbPharmacy.Web.Models;

public class Medicine
{
    public int Id { get; set; }

    [Required, StringLength(200)]
    public string Name { get; set; } = "";

    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }

    [Range(0, 1_000_000)]
    public decimal Price { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
