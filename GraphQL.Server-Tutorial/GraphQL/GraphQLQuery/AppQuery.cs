using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Server_Tutorial.GraphQL.GraphQLTypes;
using GraphQL.Server_Tutorial.Repositories;
using GraphQL.Types;

namespace GraphQL.Server_Tutorial.GraphQL.GraphQLQuery
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IAuthorRepository authorRepository)
        {
            Field<ListGraphType<AuthorType>>(
                "Authors",
                resolve: context => authorRepository.GetAllAuthorAsync().Result
            );
        }

    }
}
