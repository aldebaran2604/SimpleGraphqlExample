using GraphqlProject.Models;

namespace GraphqlProject.Interfaces;

public interface IMenu
{
    List<Menu> GetMenus();

    Menu AddMenu(Menu menu);
}