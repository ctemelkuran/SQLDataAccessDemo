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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                // var output = connection.Query<Person>($"SELECT * FROM People WHERE LastName = '{ lastName }'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
            // Query içine stored procedure yazmak daha güvenli
        }

        internal void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                Person newPerson = new Person { FirstName = firstName, LastName = lastName,
                    EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                // bu yaptığımız şunun kısa versiyonu:
                //newPerson.FirstName = firstName;
                //newPerson.LastName = lastName;
                List<Person> people = new List<Person>();
                people.Add(newPerson);

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);

            }
        }
    }
}
