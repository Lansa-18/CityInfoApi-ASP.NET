using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo;

public class City
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? Description { get; set; }

    public ICollection<PointOfInterest> PointsOfInterest { get; set; } =
        new List<PointOfInterest>(); // it's a good idea to initialize this in order to avoid the null reference error when there are no point of interest.

    public City(string name)
    {
        Name = name;
    }
}
