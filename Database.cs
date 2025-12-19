using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZooDB
{
    public class Database
    {
        private MySqlConnection conn;

        public Database()
        {
            string connstr =
                "SERVER=localhost;UID='root';PASSWORD='';DATABASE=ZooDB;";
            conn = new MySqlConnection(connstr);
        }

        //GET Methoden

        public List<Kontinent> getKontinent()
        {
            List<Kontinent> liKon = new List<Kontinent>();
            MySqlDataReader reader = null;

            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Kontinent;";

                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liKon.Add(
                        new Kontinent(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getKontinent: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                conn.Close();
            }

            return liKon;
        }

        public List<Gehege> getGehege()
        {
            List<Gehege> liGeh = new List<Gehege>();
            MySqlDataReader reader = null;

            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Gehege;";
                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liGeh.Add(
                        new Gehege(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1),
                            reader.GetInt32(2)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getGehege: " + ex.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                conn.Close();
            }

            return liGeh;
        }

        public List<Tierart> getTierart()
        {
            List<Tierart> liArt = new List<Tierart>();
            MySqlDataReader reader = null;

            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Tierart;";

                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liArt.Add(
                        new Tierart(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getKontinent: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                conn.Close();
            }

            return liArt;
        }

        public List<Tiere> getTiere()
        {
            List<Tiere> liTi = new List<Tiere>();
            MySqlDataReader reader = null;

            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Tiere;";
                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liTi.Add(new Tiere(
                        reader.GetInt32("TierID"),
                        reader.GetString("Name"),
                        reader.GetFloat("Gewicht"),
                        reader.IsDBNull(reader.GetOrdinal("Geburtsdatum"))
                            ? DateTime.MinValue
                            : reader.GetDateTime("Geburtsdatum"),
                        reader.GetInt32("TierartID"),
                        reader.GetInt32("GehegeID")
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getTiere: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                conn.Close();
            }

            return liTi;
        }

        public List<Pfleger> getPfleger()
        {
            List<Pfleger> liPf = new List<Pfleger>();
            MySqlDataReader reader = null;

            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "SELECT * FROM Pfleger;";

                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liPf.Add(
                        new Pfleger(
                            reader.GetInt32(0),
                            reader.IsDBNull(1) ? "" : reader.GetString(1)
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("getPfleger: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                conn.Close();
            }

            return liPf;
        }

        //SAVE Methoden
        public void saveKontinent(Kontinent kon)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (kon.KID == 0)
                {
                    cmd.CommandText = string.Format(
                        "INSERT INTO Kontinent (Kbezeichnung) VALUES ('{0}');",
                        kon.Kbezeichnung
                    );
                }
                else
                {
                    cmd.CommandText = string.Format(
                        "UPDATE Kontinent SET Kbezeichnung = '{0}' WHERE KID = {1};",
                        kon.Kbezeichnung,
                        kon.KID
                    );
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveKontinent " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        
        public void saveGehege(Gehege g)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (g.GID == 0)
                {
                    cmd.CommandText = string.Format(
                        "INSERT INTO Gehege (GBezeichnung, KontinentID) VALUES ('{0}', {1});",
                        g.GBezeichnung, g.KontinentID);
                }
                else
                {
                    cmd.CommandText = string.Format(
                        "UPDATE Gehege SET GBezeichnung = '{0}', KontinentID = {1} WHERE GID = {2};",
                        g.GBezeichnung, g.KontinentID, g.GID);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveGehege " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void saveTiere(Tiere t)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                string geb =
                    t.Geburtsdatum == DateTime.MinValue
                    ? "NULL"
                    : "'" + t.Geburtsdatum.ToString("yyyy-MM-dd") + "'";

                if (t.TierID == 0)
                {
                    cmd.CommandText = string.Format(
                        "INSERT INTO Tiere (Name, Gewicht, Geburtsdatum, TierartID, GehegeID) " +
                        "VALUES ('{0}', {1}, {2}, {3}, {4});",
                        t.Name,
                        t.Gewicht,
                        geb,
                        t.TierartID,
                        t.GehegeID
                    );
                }
                else
                {
                    cmd.CommandText = string.Format(
                        "UPDATE Tiere SET Name = '{0}', Gewicht = {1}, Geburtsdatum = {2}, " +
                        "TierartID = {3}, GehegeID = {4} WHERE TierID = {5};",
                        t.Name,
                        t.Gewicht,
                        geb,
                        t.TierartID,
                        t.GehegeID,
                        t.TierID
                    );
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveTiere " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public void saveTierart(Tierart ta)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (ta.TierartID == 0)
                {
                    cmd.CommandText = string.Format(
                        "INSERT INTO Tierart (TABezeichnung) VALUES ('{0}');",
                        ta.TABezeichnung);
                }
                else
                {
                    cmd.CommandText = string.Format(
                        "UPDATE Tierart SET TABezeichnung = '{0}' WHERE TierartID = {1};",
                        ta.TABezeichnung, ta.TierartID);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("saveTierart " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void savePfleger(Pfleger pf)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (pf.PID == 0)
                {
                    cmd.CommandText = string.Format(
                        "INSERT INTO Pfleger (Name) VALUES ('{0}');",
                        pf.Name
                    );
                }
                else
                {
                    cmd.CommandText = string.Format(
                        "UPDATE Pfleger SET Name = '{0}' WHERE pID = {1};",
                        pf.Name,
                        pf.PID
                    );
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("savePfleger " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        //DELETE Methoden
        public void delTierart(int id)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format("DELETE FROM Tierart WHERE TierartID = {0};", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delTierart " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        
        public void delTiere(int id)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format("DELETE FROM Tiere WHERE TierartID = {0};", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delTiere " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void delGehege(int id)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format("DELETE FROM Gehege WHERE GID = {0};", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delGehege " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void delKontinent(int whichNo)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format(
                    "DELETE FROM Kontinent WHERE KID = {0};",
                    whichNo
                );

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delKontinent " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void delPfleger(int id)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = string.Format("DELETE FROM Pfleger WHERE pID = {0};", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("delPfleger " + ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

    }

}



    
