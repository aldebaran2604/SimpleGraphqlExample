namespace GraphqlProject.Models;

public class SubMenu
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public double Price { get; set; }
    public int MenuId { get; set; }
}