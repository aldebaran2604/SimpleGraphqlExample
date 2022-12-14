using GraphQL.Types;
using GraphqlProject.Interfaces;
using GraphqlProject.Type;

namespace GraphqlProject.Query;

public class MenuQuery : ObjectGraphType
{
    public MenuQuery(IMenu menuService)
    {
        Field<ListGraphType<MenuType>>("menu", resolve: context => { return menuService.GetMenus(); });
    }
}