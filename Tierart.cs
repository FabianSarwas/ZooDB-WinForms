namespace ZooDB
{
    public class Tierart
    {
        public int TierartID { get; set; }
        public string TABezeichnung { get; set; }

        // NEU
        public Tierart()
        {
        }

        public Tierart(int tierartID, string bez)
        {
            TierartID = tierartID;
            TABezeichnung = bez;
        }

        public override string ToString() => TABezeichnung;
    }
}
