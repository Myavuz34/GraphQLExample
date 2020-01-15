using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace GraphQLApi.Graphql
{
    //Graphql tarafı için gerekli olan şemamız.
    public class YvzSchema:Schema
    {
        public YvzSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<YvzQuery>();
        }
    }
}
