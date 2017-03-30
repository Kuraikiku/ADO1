using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado
{
    public partial class CreateArticle : Form
    {
        OleDbConnection con = null;
        Artikel newArtikel = null;
        public CreateArticle(OleDbConnection con)
        {
            InitializeComponent();
            Con = con;
        
        }

        public OleDbConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        internal Artikel NewArtikel
        {
            get
            {
                return newArtikel;
            }

            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Artikel a = new Artikel();
            a.ArtikelGruppe = Convert.ToInt32(textBoxArtikelGruppe.Text);
            a.ArtikelNr = textBoxArtikelNr.Text;
            a.Bestand = Convert.ToInt16(textBoxBestand.Text);
            a.Verpackung = Convert.ToInt32(textBoxVerpackung.Text);
            a.Bezeichnung = textBoxBezeichnung.Text;
            inserDB(a);
            newArtikel = a;
            this.Close();
        }

        private void inserDB(Artikel a)
        {
            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "Insert into tArtikel (ArtikelNr,Bezeichnung,ArtikelGruppe, Verpackung) Values ("+a.ArtikelNr+","+a.Bezeichnung+","+a.ArtikelGruppe+","+a.Verpackung+")";
            cmd.Parameters.Add("ANR", OleDbType.WChar);
            cmd.Parameters.Add("BEZ", OleDbType.WChar);
            cmd.Parameters.Add("AG", OleDbType.Integer);
            cmd.Parameters.Add("VP", OleDbType.Integer);
            cmd.CommandText = "Insert into tArtikel (ArtikelNr,Bezeichnung,ArtikelGruppe, Verpackung) Values (ANR,BEZ,AG,VP)";

            //Values
            cmd.Parameters["ANR"].Value = a.ArtikelNr;
            cmd.Parameters["BEZ"].Value = a.Bezeichnung;
            cmd.Parameters["AG"].Value = a.ArtikelGruppe;
            cmd.Parameters["VP"].Value = a.Verpackung;

            //Ausführen
            try
            {
                int anzahl = cmd.ExecuteNonQuery();
                MessageBox.Show(anzahl.ToString() + " Sätze eingefügt.");
            }
            catch (Exception)
            {

                MessageBox.Show("Einfügen nicht erfolgreich");
            }

            //Autowert
            cmd.CommandText = "SELECT @@identity From tArtikel";
            Int32 auto =(Int32) cmd.ExecuteScalar();
            a.ArtikelOid = auto;
            textBoxArtikelOid.Text = auto.ToString();


        }

        private void textBoxArtikelGruppe_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(textBoxArtikelGruppe.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Muss Integerwert sein");
                e.Cancel = true;
            }
        }

        private void textBoxVerpackung_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(textBoxVerpackung.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Muss Integerwert sein");
                e.Cancel = true;
            }
        }

        private void textBoxBestand_Validating(object sender, CancelEventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt16(textBoxBestand.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Muss Integerwert sein");
                e.Cancel = true;
            }
        }
    }
}
