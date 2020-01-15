using GraphQL.Types;
using GraphQLApi.Models;

namespace GraphQLApi.Graphql.Type
{
    public class BrandType : ObjectGraphType<Brand>
    {
        public BrandType()
        {
            Name = "Brand";
            Field(p => p.Id);
            Field(p => p.Name);
        }
    }
}
