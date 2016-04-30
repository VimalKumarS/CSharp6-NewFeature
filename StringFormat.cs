using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp6
{
    public class Rockband1
    {
        public string Name { get; }
        public int NumberOfMembers { get; }
        public decimal ConcertFee { get; }

        public Rockband1(string name, int numberOfMembers, decimal concertFee)
        {
            Name = name;
            NumberOfMembers = numberOfMembers;
            ConcertFee = concertFee;
        }

        public string GetFancyName()
        {
            return Name.ToUpper();
        }

        //c#6 format string

        public void StringFormatOlder()
        {
            Rockband1 metallica = new Rockband1("Metallica", 4, 50);
            string formatExampleOne = string.Format("The band is called {0}, they have the fancy name of {1}, they have {2} members and require {3:c} for a concert."
                , metallica.Name, metallica.GetFancyName(), metallica.NumberOfMembers, metallica.ConcertFee);
            Debug.WriteLine(formatExampleOne);
        }
        public void StringFormatNewer()
        {
            Rockband1 metallica = new Rockband1("Metallica", 4, 50);
            string formatExampleTwo = $"The band is called {metallica.Name}, they have the fancy name of {metallica.GetFancyName()}, they have {metallica.NumberOfMembers} members and require {metallica.ConcertFee:c} for a concert.";
        }
    }
}
