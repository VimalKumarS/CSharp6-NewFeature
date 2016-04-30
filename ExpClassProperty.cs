using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp6
{
    class ExpClassProperty
    {
    }
    public class Person2
    {
        public int Age { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Person2(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    

    public string  FullName => String.Format("{0} {1}", FirstName, LastName);
    public bool Old => Age > 35;
    }
}
