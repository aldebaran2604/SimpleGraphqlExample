using GraphQL.Types;

namespace GraphqlProject.Type;

public class MenuInputType : InputObjectGraphType
{
    public MenuInputType()
    {
        Field<IntGraphType>("id");
        Field<StringGraphType>("name");
        Field<StringGraphType>("imageUrl");
    }
}