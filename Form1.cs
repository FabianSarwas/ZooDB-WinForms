using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ZooDB
{
    public partial class Form1 : Form
    {
        private Database db;
        private Xml xml;

        // Listen
        private List<Tiere> liTiImport = new List<Tiere>();
        private List<Kontinent> liKon = new List<Kontinent>();
        private List<Gehege> liGeh = new List<Gehege>();
        private List<Tiere> liTi = new List<Tiere>();
        private List<Tierart> liArt = new List<Tierart>();
        private List<Pfleger> liPf = new List<Pfleger>();

        // Dateipfade
        private string zielName = @"C:\Temp\TiereExport.xml";
        private string quellName = @"C:\Temp\TiereImport.xml";

        public Form1()
        {
            InitializeComponent();

            db = new Database();
            xml = new Xml(quellName, zielName);

            LoadKontinenteInComboBox();
            LoadGehegeInComboBox();
            LoadTierartInComboBox();

            dispKont();
            dispGeh();
            dispTierart();
            dispTiere();
            dispPfleger();
        }

        // Comboboxen werden in Tabs geladen

        private void LoadGehegeInComboBox()
        {
            cb_Gehege.Items.Clear();

            List<Gehege> liGeh = db.getGehege();

            foreach (Gehege g in liGeh)
            {
                cb_Gehege.Items.Add(g);
            }
        }
        private void LoadKontinenteInComboBox()
        {
            cb_GehegeKontinent.Items.Clear();

            List<Kontinent> liKon = db.getKontinent();

            foreach (Kontinent k in liKon)
            {
                cb_GehegeKontinent.Items.Add(k);
            }
        }
        private void LoadTierartInComboBox()
        {
            cb_TierArt.Items.Clear();

            List<Tierart> liTi = db.getTierart();

            foreach (Tierart t in liTi)
            {
                cb_TierArt.Items.Add(t);
            }
        }
        //Display Methoden

        private void dispKont()
        {
            liKon = db.getKontinent();
            lb_Kontinent.Items.Clear();

            foreach (Kontinent kon in liKon)
            {
                lb_Kontinent.Items.Add(kon);
            }
        }

        private void dispGeh()
        {
            liGeh = db.getGehege();
            lb_Gehege.Items.Clear();

            foreach (Gehege geh in liGeh)
            {
                lb_Gehege.Items.Add(geh);
            }
        }

        private void dispTierart()

        {
            liArt = db.getTierart();
            lb_Tierart.Items.Clear();

            foreach (Tierart tia in liArt)
            {
                lb_Tierart.Items.Add(tia);
            }
        }

        private void dispTiere()

        {
            liTi = db.getTiere();
            lb_Tiere.Items.Clear();

            foreach (Tiere ti in liTi)
            {
                lb_Tiere.Items.Add(ti);
            }
        }

        private void dispPfleger()

        {
            liPf = db.getPfleger();
            lb_Pfleger.Items.Clear();

            foreach (Pfleger Pf in liPf)
            {
                lb_Pfleger.Items.Add(Pf);
            }
        }
        private void DispImport()
        {
            lb_TierImp.Items.Clear();

            int nr = 1;
            foreach (Tiere t in liTiImport)
            {
                string geb;

                if (t.Geburtsdatum == DateTime.MinValue)
                    geb = "";
                else
                    geb = t.Geburtsdatum.ToString("yyyy-MM-dd");

                string text = string.Format(
                    "{0}. {1} | Gewicht: {2} | Geb.: {3}",
                    nr,
                    t.Name,
                    t.Gewicht,
                    geb
                );

                lb_TierImp.Items.Add(text);
                nr++;
            }
        }

        //Speichern Buttons

        private void btn_SpeichernKon_Click_1(object sender, EventArgs e)
        {
            int nr = 1;
            int.TryParse(tb_KonNr.Text, out nr);

            Kontinent KonKbezeichnung = new Kontinent(nr, tb_KonBez.Text);
            db.saveKontinent(KonKbezeichnung);
            dispKont();
        }

        private void btn_Speichern_Gehege_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(tb_Gehege.Text, out nr);

            Kontinent kon = cb_GehegeKontinent.SelectedItem as Kontinent;
            int GID = (kon != null) ? kon.KID : 0;

            Gehege ge = new Gehege(
                nr,
                tb_Gehege.Text,
                GID
            );

            db.saveGehege(ge);
            dispGeh();
        }

        private void btn_SpeichernTierart_Click(object sender, EventArgs e)
        {
            {
                {
                    int nr = 0;
                    int.TryParse(tb_Art.Text, out nr);

                    Tierart art = new Tierart(nr, tb_Art.Text);
                    db.saveTierart(art);
                    dispTierart();
                }
            }
        }

        private void btn_SpeichernTiere_Click(object sender, EventArgs e)
        {

            int nr = 0;
            int.TryParse(tb_TierID.Text, out nr);

            float gewicht = 0f;
            float.TryParse(tb_TierGewicht.Text, out gewicht);

            DateTime gebDatum = DateTime.MinValue;
            DateTime.TryParse(tb_TierGeb.Text, out gebDatum);

            int tierartID = ((Tierart)cb_TierArt.SelectedItem).TierartID;
            int gehegeID = ((Gehege)cb_Gehege.SelectedItem).GID;

            Tiere tier = new Tiere(
                nr,
                tb_TierName.Text,
                gewicht,
                gebDatum,
                tierartID,
                gehegeID
            );

            db.saveTiere(tier);
            dispTiere();
        }

        private void btn_SpeichernPfleger_Click(object sender, EventArgs e)
        {
            int nr = 0;
            int.TryParse(tb_Pfleger.Text, out nr);

            Pfleger pf = new Pfleger(nr, tb_Pfleger.Text);

            db.savePfleger(pf);    
            dispPfleger();          // <- ListBox neu anzeigen
        }

        private void btn_AktualisierenKontinent_Click(object sender, EventArgs e)
        {

        }

        //Löschen Buttons

        private void btn_LöschenKon_Click(object sender, EventArgs e)
        {
            if (lb_Kontinent.SelectedIndex != -1)
            {
                int nr = liKon[lb_Kontinent.SelectedIndex].KID;
                db.delKontinent(nr);
                dispKont();
            }
        }

        private void btn_LöschenTiere_Click(object sender, EventArgs e)
        {
            db.delTiere(liTi[lb_Tiere.SelectedIndex].TierartID);
            dispTiere();
        }

        private void btn_LöschenTierart_Click(object sender, EventArgs e)
        {
            db.delTierart(liArt[lb_Tierart.SelectedIndex].TierartID);
            dispTierart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (lb_Gehege.SelectedIndex != -1)
                {
                    int nr = liGeh[lb_Gehege.SelectedIndex].GID;
                    db.delGehege(nr);
                    dispGeh();
                }
            }
        }

        private void btn_LöschenPfleger_Click(object sender, EventArgs e)
        {
            db.delPfleger(liPf[lb_Pfleger.SelectedIndex].PID);
            dispPfleger();
        }
        //BTN Export Import
        private void btn_XmlSchreiben_Click(object sender, EventArgs e)
        {
            try
            {
                xml.XmlSchreiben(liTi, liArt);
                MessageBox.Show("XML erfolgreich geschrieben");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Export: " + ex.Message);
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            xml.XmlLesen(liTiImport, liArt);
            DispImport();
        }

        
    }
}



