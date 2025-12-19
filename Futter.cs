using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDB
{
    public class Futter
    {
        public int FID { get; set; }

        public string Name { get; set; }

        public decimal Einheit { get; set; }

        public Futter(int fID, string name, decimal einheit)
        {
            FID = fID;
            Name = name;
            Einheit = einheit;
        }

        public override string ToString() => Name;
        
    }
}
