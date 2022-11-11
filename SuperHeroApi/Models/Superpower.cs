using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SuperHeroApi.Models;

public class Superpower
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "The superpower is required")]
    public string SuperPower { get; set; } = null!;

    public string? Description { get; set; }

    [ForeignKey("SuperheroId")]
    public Guid SuperheroId { get; set; }

    public Superhero? Superhero { get; set; }
}