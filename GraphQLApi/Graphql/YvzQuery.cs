using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLApi.Context;
using GraphQLApi.Graphql.Type;

namespace GraphQLApi.Graphql
{
    //Graphql tarafındaki endpointlerimizin belirlendiği classtır. IGraphType interface’inden türeyen bir tip olmalıdır.(Kısaca bir GraphType olmalı.)
    public class YvzQuery : ObjectGraphType<object>
    {
        public YvzQuery(YvzContext _yvzContext)
        {
            Name = "Yvz_Query";

            //Graphql endpointlerini belirliyoruz.
            Field<ListGraphType<ProductType>>("Products",
                resolve: ctx => _yvzContext.GetProducts());

            Field<ListGraphType<ProductType>>("ProductByBrandId",
                arguments: new QueryArguments
                {
                    new QueryArgument<IntGraphType>{
                        Name="Id",
                        Description="Brand Id"
                    }
                },
                resolve: ctx => _yvzContext.GetProductsByBrandId(ctx.GetArgument<int>("Id")));
                Field<ListGraphType<BrandType>>("Brands", resolve: ctx => _yvzContext.GetBrands());
        }
    }
}