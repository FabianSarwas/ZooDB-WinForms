using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDB
{
    public class Betreut
    {
        public int BetreutID { get; set; }

        public int PID { get; set; }

        public int GID { get; set; }

        public string Hauptpfleger { get; set; }

        public Betreut()
        {
        }

        public Betreut(int betreutID, int pID, int gID, string hauptpfleger)
        {
            BetreutID = betreutID;
            PID = pID;
            GID = gID;
            Hauptpfleger = hauptpfleger;
        }
    }
}
