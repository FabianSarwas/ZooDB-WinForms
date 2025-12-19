using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ZooDB
{
    public class Xml
    {
        private readonly string quellName;
        private readonly string zielName;

        public Xml(string quellName, string zielName)
        {
            this.quellName = quellName;
            this.zielName = zielName;
        }

        public void XmlLesen(List<Tiere> liTiImport, List<Tierart> liArt)
        {
            XmlTextReader reader = null;

            try
            {
                reader = new XmlTextReader(quellName);

                liTiImport.Clear();
                liArt.Clear();

                Tiere tier = null;
                Tierart art = null;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                     
                        if (reader.Name == "Tier")
                            tier = new Tiere();

                        if (reader.Name == "TierID" && tier != null)
                        {
                            reader.Read();
                            tier.TierID = Convert.ToInt32(reader.Value);
                        }

                        if (reader.Name == "Name" && tier != null)
                        {
                            reader.Read();
                            tier.Name = reader.Value;
                        }

                        if (reader.Name == "Gewicht" && tier != null)
                        {
                            reader.Read();
                            tier.Gewicht = float.Parse(
                                reader.Value.Replace(".", ",")
                            );
                        }

                        if (reader.Name == "Geburtsdatum" && tier != null)
                        {
                            reader.Read();
                            tier.Geburtsdatum = string.IsNullOrEmpty(reader.Value)
                                ? DateTime.MinValue
                                : DateTime.Parse(reader.Value);
                        }

                       
                        if (reader.Name == "Tierart")
                            art = new Tierart();

                        if (reader.Name == "TierartID" && art != null)
                        {
                            reader.Read();
                            art.TierartID = Convert.ToInt32(reader.Value);
                        }

                        if (reader.Name == "TABezeichnung" && art != null)
                        {
                            reader.Read();
                            art.TABezeichnung = reader.Value;
                        }
                    }

          
                    if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        if (reader.Name == "Tier" && tier != null)
                        {
                            liTiImport.Add(tier);
                            tier = null;
                        }

                        if (reader.Name == "Tierart" && art != null)
                        {
                            liArt.Add(art);
                            art = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("XML Lesen Fehler: " + ex.Message);
            }
            finally
            {
                reader?.Close();
            }
        }


        public void XmlSchreiben(List<Tiere> liTi, List<Tierart> liArt)
        {
            using (XmlTextWriter writer = new XmlTextWriter(zielName, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument(false);

                writer.WriteStartElement("Zoo");

          
                writer.WriteStartElement("Tiere");

                foreach (Tiere tier in liTi)
                {
                    writer.WriteStartElement("Tier");

                    writer.WriteElementString("TierID", tier.TierID.ToString());
                    writer.WriteElementString("Name", tier.Name);
                    writer.WriteElementString("Gewicht", tier.Gewicht.ToString());

                    writer.WriteElementString(
                        "Geburtsdatum",
                        tier.Geburtsdatum == DateTime.MinValue
                            ? ""
                            : tier.Geburtsdatum.ToString("yyyy-MM-dd")
                    );

                    writer.WriteEndElement(); 
                }

                writer.WriteEndElement(); 

              
                writer.WriteStartElement("Tierarten");

                foreach (Tierart art in liArt)
                {
                    writer.WriteStartElement("Tierart");

                    writer.WriteElementString(
                        "TierartID",
                        art.TierartID.ToString()
                    );

                    writer.WriteElementString(
                        "TABezeichnung",
                        art.TABezeichnung
                    );

                    writer.WriteEndElement(); 
                }

                writer.WriteEndElement(); 
                writer.WriteEndElement(); 
            }
        }
    }
}
