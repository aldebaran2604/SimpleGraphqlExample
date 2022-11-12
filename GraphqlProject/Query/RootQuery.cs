using GraphQL.Types;

namespace GraphqlProject.Query;

public class RootQuery : ObjectGraphType
{
    public RootQuery()
    {
        Field<MenuQuery>("menuQuery", resolve: context => new { });
        Field<SubMenuQuery>("submenuQuery", resolve: context => new { });
        Field<ReservationQuery>("reservationQuery", resolve: context => new { });
    }
}