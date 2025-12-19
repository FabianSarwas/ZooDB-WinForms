namespace ZooDB
{
    public class Gehege
    {
        public int GID { get; set; }
        public string GBezeichnung { get; set; }
        public int KontinentID { get; set; }


        public Gehege()
        {
        }

        public Gehege(int gID, string bez, int kontinentID)
        {
            GID = gID;
            GBezeichnung = bez;
            KontinentID = kontinentID;
        }

        public override string ToString() => GBezeichnung;
    }
}
