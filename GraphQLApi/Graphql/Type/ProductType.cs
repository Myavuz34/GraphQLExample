using GraphQL.Types;
using GraphQLApi.Models;

namespace GraphQLApi.Graphql.Type
{
    public class ProductType:ObjectGraphType<Product>
    {
        public ProductType()
        {
            Name = "Product";
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Price);
            Field<BrandType>("Brand", resolve: _ => _.Source.Brand);
        }
    }
}
