using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Server_Tutorial.Entities;
using GraphQL.Types;

namespace GraphQL.Server_Tutorial.GraphQL.GraphQLTypes
{
    public sealed class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(author => author.Id, type: typeof(IGraphType)).Description("Id property from the Author object");
            Field(author => author.Name, type: typeof(IGraphType)).Description("Name property from the Author object");
            Field(author => author.IsAlive, type: typeof(IGraphType)).Description("IsAlive property from the Author object");
        }
    }
}
