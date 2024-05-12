using System.ComponentModel.DataAnnotations;

namespace Cwiczenia04.btos;

public class WarehouseProductBto
{
    [Required] int IdProduct { get; set; }
    [Required] public int IdWarehouse { get; set; }
    [Required] public int Amount { get; set; }
    [Required] public DateTime CreatedAt { get; set; }
}