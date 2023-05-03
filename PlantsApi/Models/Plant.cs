namespace PlantsApi.Models;

public class Plant
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Variant { get; set; } = null!;
    public string? BinomialNomenclature { get; set; } 
    public string? AltName1 { get; set; } 
    public string? AltName2 { get; set; }
    public string? AltName3 { get; set; }
    public string? Description { get; set; }
    public ICollection<Zone> Zones { get; set; } = null!;
}
