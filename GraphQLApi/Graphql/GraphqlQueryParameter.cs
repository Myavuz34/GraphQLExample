using Newtonsoft.Json.Linq;

namespace GraphQLApi.Graphql
{
    ///Bu classı client tarafından gelen istekleri almak için kullanacağız.
    public class GraphqlQueryParameter
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
