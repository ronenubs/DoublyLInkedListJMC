using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLInkedListJMC
{
    public class Person
    {
        private string firstname;
        private string middlename;
        private string lastname;

        private int age;

        private string address;

        public Person(string firstname, string middlename, 
            string lastname, int age, string address)
        {
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.age = age;
            this.address = address;
        }

        public string PersonInfo()
        {
            return firstname + " " + middlename + " " + lastname + ", "
                + age + "\n" + address;
        }
    }
}
