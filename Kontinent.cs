namespace ZooDB
{
    public class Kontinent
    {
        public int KID { get; set; }
        public string Kbezeichnung { get; set; }

        public Kontinent()
        {
        }

        public Kontinent(int kID, string kbez)
        {
            KID = kID;
            Kbezeichnung = kbez;
        }

        public override string ToString() => Kbezeichnung;
    }
}
