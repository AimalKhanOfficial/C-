using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TryingDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection db = new SqlConnection("Data Source=.;Initial Catalog=practice;Integrated Security=True");
            var listOfEmp = db.Query<Employee>("select * from employee").ToList();
            Console.Read();
        }
    }
}
