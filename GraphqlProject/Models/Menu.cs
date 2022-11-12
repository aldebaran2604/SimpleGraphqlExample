namespace GraphqlProject.Models;

public class Menu
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public ICollection<SubMenu>? SubMenus { get; set; }
}