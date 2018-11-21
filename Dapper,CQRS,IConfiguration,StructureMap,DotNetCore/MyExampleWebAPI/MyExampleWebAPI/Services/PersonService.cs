using Microsoft.Extensions.Configuration;
using MyClassLibrary;
using MyClassLibrary.Query;
using MyClassLibrary.QueryHandlers;
using MyExampleWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyExampleWebAPI.Services
{
    public class PersonService : IPersonService
    {
        IDbConnection db = null;
        GetPersonByIdQueryHandler _getPersonByIdQueryHandler = null;

        public PersonService(IConfiguration config, GetPersonByIdQueryHandler getPersonByIdQueryHandler)
        {
            db = new SqlConnection(config["ConnectionString"]);
            _getPersonByIdQueryHandler = getPersonByIdQueryHandler;
        }

        Person IPersonService.GetPersonByID(int personId)
        {
            return _getPersonByIdQueryHandler.Handle(new GetPersonByIdQuery(personId), db);
        }
    }
}
