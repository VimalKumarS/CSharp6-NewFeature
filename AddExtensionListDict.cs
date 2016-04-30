using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp6
{
    public class Rockband
    {
        public string Name { get; }
        public int NumberOfMembers { get; }

        public Rockband(string name, int numberOfMembers)
        {
            Name = name;
            NumberOfMembers = numberOfMembers;
        }

        public void AddBand()
        {
            List<Rockband> rockbands2 = new List<Rockband>()
            {
                { "Queen", 4 },
                { "Genesis", 5 },
                { "Metallica", 4 }
                        };
        }
    }

    //OtherWay
    public static class Extensions
    {
        public static void Add(this List<Rockband> rockbands, string name, int numberOfMembers)
        {
            rockbands.Add(new Rockband(name, numberOfMembers));
        }
    }




}
