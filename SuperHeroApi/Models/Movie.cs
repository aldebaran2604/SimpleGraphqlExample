using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SuperHeroApi.Models;

public class Movie
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "The movie title is required")]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }
    public string Instructor { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }

    [ForeignKey("SuperheroId")]
    public Guid SuperheroId { get; set; }

    public Superhero? Superhero { get; set; }
}