using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            // NotImplementedException allow us to compile the app while working on it
            // It doesnt have to return anything for now
            // throw new NotImplementedException();

            // using allows us to use connection
            // end of using statement connection gets destroyed, so we wont leave connections open
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")) )
            {
                var output = connection.Query<Person>($"SELECT * FROM People WHERE LastName = '{ lastName }'").ToList();
                return output;
            }
            // open connec
        }
    }
}
