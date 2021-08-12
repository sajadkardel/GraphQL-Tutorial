using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Server_Tutorial.Entities;
using GraphQL.Types;

namespace GraphQL.Server_Tutorial.GraphQL.GraphQLTypes
{
    public sealed class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(author => author.Id, type: typeof(IGraphType)).Description("Id property from the Book object");
            Field(author => author.Name, type: typeof(IGraphType)).Description("Name property from the Book object");
            Field(author => author.Description, type: typeof(IGraphType)).Description("Description property from the Book object");
            Field(author => author.Price, type: typeof(IGraphType)).Description("Price property from the Book object");
            Field(author => author.ReleaseDate, type: typeof(IGraphType)).Description("ReleaseDate property from the Book object");
        }
    }
}
