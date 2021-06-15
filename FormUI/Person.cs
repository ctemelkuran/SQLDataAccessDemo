using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        // make the column names and property names the SAME
        // pretend it is SQL
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get 
            {
                // "Tim Corey (test@test.com)"
                return $"{ FirstName } { LastName } ({ EmailAddress })"; 
            }

        }

    }
}
