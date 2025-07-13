using System.Xml;

namespace FirmaXML
    
{
    public partial class Form1 : Form
    {

        List<mitarbeiter> mitarbeiterListe = new List<mitarbeiter>();
        List<mitarbeiter> lm = new List<mitarbeiter>();

        string quellName = @"Firma.xml"; 
        string zielName = @"Firma.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            string vname = txtVName.Text;
            string nname = txtNName.Text;
            string telefonnr = txtTNummer.Text;

            mitarbeiter m = new mitarbeiter(vname, nname, telefonnr);
            mitarbeiterListe.Add(m);
            dgvHMitarbeiter.Rows.Clear();
            foreach(mitarbeiter mit in mitarbeiterListe)
            {
                dgvHMitarbeiter.Rows.Add(mit.Vname, mit.Nname, mit.Telefonnr);
            }

            txtVName.Clear();
            txtNName.Clear();
            txtTNummer.Clear();
        }

        private void btnXmlSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(zielName, System.Text.Encoding.UTF8);
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.WriteStartDocument(false);

                xmlTextWriter.WriteStartElement("Firma");

                foreach (mitarbeiter m in mitarbeiterListe)
                {
                    xmlTextWriter.WriteStartElement("mitarbeiter"); 
                    xmlTextWriter.WriteAttributeString("vorname", m.Vname);
                    xmlTextWriter.WriteAttributeString("nachname", m.Nname);
                    xmlTextWriter.WriteAttributeString("telefonnummer", m.Telefonnr);
                    xmlTextWriter.WriteEndElement();

                }
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.Flush();
                xmlTextWriter.Close();
                MessageBox.Show("XML-Datei wurde erfolgreich gespeichert: " + zielName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern der XML-Datei: " + ex.Message);
            }
            finally
            {
            }

        }
        private void btnDLesen_Click(object sender, EventArgs e)
        {
            XmlReader reader = null;
            try
            {    
                reader = new XmlTextReader(quellName);

                lm.Clear();   
                dgvMitarbeiter.Rows.Clear();  

                while (reader.Read())
                {
                    if (reader.Name != "") 
                    {
                       
                        if (reader.Name == "mitarbeiter")
                        {
                           
                            if (reader.AttributeCount == 3)
                            {
                                
                                reader.MoveToAttribute("vorname");
                                string vn = reader.Value;
                                
                                reader.MoveToAttribute("nachname");
                                string nn = reader.Value;

                                reader.MoveToAttribute("telefonnummer");
                                string tn = reader.Value;

                                mitarbeiter m = new mitarbeiter(vn, nn, tn);

                              
                                lm.Add(m);
                                dgvMitarbeiter.Rows.Add(m.Vname, m.Nname, m.Telefonnr); 
                            }
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Lesen der XML-Datei: " + ex.Message);
            }
            finally
            {
                reader.Close();
            }

        }
    }
}
