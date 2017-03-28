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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Artikel a = new Artikel();
            a.ArtikelGruppe = Convert.ToInt32(textBoxArtikelGruppe.Text);
            a.ArtikelNr = textBoxArtikelNr.Text;
            a.Bestand = Convert.ToInt16(textBoxBestand.Text);
            a.Verpackung = Convert.ToInt32(textBoxBestand.Text);
            a.Bezeichnung = textBoxBezeichnung.Text;
            inserDB(a);
        }

        private void inserDB(Artikel a)
        {
            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "Insert into tArtikel (ArtikelNr,Bezeichnung,ArtikelGruppe, Verpackung) Values ("+a.ArtikelNr+","+a.Bezeichnung+","+a.ArtikelGruppe+","+a.Verpackung+")";
            cmd.CommandText = "Insert into tArtikel (ArtikelNr,Bezeichnung,ArtikelGruppe, Verpackung) Values (ANR,BEZ,AG,VP)";
            cmd.Parameters.Add("ANR", OleDbType.WChar);
            cmd.Parameters.Add("BEZ", OleDbType.WChar);

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
