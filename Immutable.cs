using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp6
{
    public class Person1
    {
       // private readonly string _name;
       // private readonly int _age;

        public int _age { get; private set; }
        public string _name { get; private set; }
 
        public Person1(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public string Greet()
        {
            _name = "Jill";
            return string.Format("Hello from {0}", Name);
        }
    }

    //C#6
    //The Age and Name fields can be set in the constructor but not anywhere else. The Greet() method will fail with the following compiler error:
    public class Person14
    {
        public int Age { get; }
        public string Name { get; }

        public Person14(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
