using System;

namespace ZooDB
{
    public class Tiere
    {
        public int TierID { get; set; }
        public string Name { get; set; }
        public float Gewicht { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public int TierartID { get; set; }
        public int GehegeID { get; set; }

        // NEU
        public Tiere()
        {
        }

        public Tiere(int tierID, string name, float gewicht,
                     DateTime geburtsdatum, int tierartID, int gehegeID)
        {
            TierID = tierID;
            Name = name;
            Gewicht = gewicht;
            Geburtsdatum = geburtsdatum;
            TierartID = tierartID;
            GehegeID = gehegeID;
        }

        public override string ToString() => Name;
    }
}
