using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    public class Owner
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte Age { get; set; }

        public string IdentityNumber { get; set; }

        public Owner() { }

        public Owner(string firstName,string lastName,byte age,string identityNumber)
        {
            this.FirstName = firstName;

            this.LastName = lastName;

            this.Age = age;

            this.IdentityNumber = identityNumber;
        }
    }
}
