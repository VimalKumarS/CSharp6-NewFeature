using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp6
{
    class CheckNull
    {

        private static void Resolve(string input)
        {
            if (input == null) throw new ArgumentNullException("Input");
        }

        // null-coalescing operator:
        private static string Resolve1(string input)
        {
            string res = input ?? "Empty input string";
            return res;
        }

        //C# 6 Check null in property
        private static void ResolveNull(string input)
        {
            GetPersonResponse getPersonResponse = new GetPersonResponse(new Person12(null));
            if (getPersonResponse?.Person?.Workplace?.Address?.Street != null)
            {
                
                Console.WriteLine(getPersonResponse.Person.Workplace.Address.Street);
            }
        }

    }


    public class Address
    {
        public string Street { get; }
        public int Number { get; }

        public Address(string street, int number)
        {
            Street = street;
            Number = number;
        }
    }

    public class Workplace
    {
        public Address Address { get; }

        public Workplace(Address address)
        {
            Address = address;
        }
    }

    public class Person12
    {
        public Workplace Workplace { get; }

        public Person12(Workplace workplace)
        {
            Workplace = workplace;
        }
    }

    public class GetPersonResponse
    {
        public Person12 Person { get; }

        public GetPersonResponse(Person12 person)
        {
            Person = person;
        }
    }
}
