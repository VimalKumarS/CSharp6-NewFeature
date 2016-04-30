using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp6
{
    public class Person4
    {
        public int Age { get; }
        public string FirstName { get; }
        public string LastName { get; }

        /*public Person4(string firstName, string lastName, int age)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException("firstName");
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException("lastName");
            if (age <= 0) throw new ArgumentException("age");
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }*/

        // c#6
        //Refactoring to new names will be a lot easier this way and you won't depend on strings for variable names. The exception message 
        public Person4(string firstName, string lastName, int age)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException(nameof(FirstName));
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(LastName));
            if (age <= 0) throw new ArgumentException(nameof(age));
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

    }


}
