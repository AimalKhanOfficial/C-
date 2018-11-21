using MyClassLibrary.Query;
using System.Data;
using Dapper;

namespace MyClassLibrary.QueryHandlers
{
    public class GetPersonByIdQueryHandler
    {
        string sql = @"
            select * from Persons
            where PersonId = @PersonId
        ";

        public Person Handle(GetPersonByIdQuery person, IDbConnection db)
        {
            return db.QueryFirst<Person>(sql, person);
        }
    }
}
