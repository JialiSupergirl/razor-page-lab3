using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace razor_page_lab3.Models;

public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal? Price { get; set; }

    public int? StockCount { get; set; }
}