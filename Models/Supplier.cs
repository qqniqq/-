using System.ComponentModel.DataAnnotations;

namespace TcrbPharmacy.Web.Models;

public class Supplier
{
    public int Id { get; set; }

    [Required, StringLength(200)]
    public string Name { get; set; } = "";

    [StringLength(50)]
    public string? Phone { get; set; }

    [StringLength(300)]
    public string? Address { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
