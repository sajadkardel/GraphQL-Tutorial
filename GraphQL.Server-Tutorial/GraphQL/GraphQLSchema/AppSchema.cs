using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Server_Tutorial.GraphQL.GraphQLQuery;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Server_Tutorial.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
        }
    }
}
