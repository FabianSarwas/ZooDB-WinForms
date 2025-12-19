using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDB
{
    public class Pfleger
    {
        public int PID { get; set; }

        public string Name { get; set; }

        public Pfleger()
        {
        }

        public Pfleger(int pID, string name)
        {
            PID = pID;
            Name = name;
        }
        public override string ToString() => Name;

    }
}
