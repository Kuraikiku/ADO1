using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ado
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        List<Artikel> listArtikel = null;
        public Form1()
        {
            InitializeComponent();
            listArtikel = new List<Artikel>();
        }

        private void buttonConn_Click(object sender, EventArgs e)
        {
            /*OleDbConnectionStringBuilder bldr = new OleDbConnectionStringBuilder();
            bldr.Provider = "Microsoft.ACE.OLEDB.12.0";
            bldr.DataSource = "Bestellung.accdb";*/
            con = new OleDbConnection(Properties.Settings.Default.DBC);
            try
            {
                con.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            buttonSql.Enabled = true;
            buttonConn.Enabled = false;
            buttonNew.Enabled = true;
        }

        private void buttonSql_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.Parameters.Add("AGR", OleDbType.Integer);
            cmd.CommandText = "Select * from tArtikel where ArtikelGruppe = AGR";
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.Parameters["AGR"].Value = textBoxGruppe.Text; 
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Omgush",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            buttonAuslesen.Enabled = true;
            
        }

        private void buttonAuslesen_Click(object sender, EventArgs e)
        {
            listBoxAusgabe.DataSource = null;
            listBoxAusgabe.Items.Clear();
            while (reader.Read()) 
            {
                
                listArtikel.Add(mkArtikelObject(reader));
                //listBoxAusgabe.Items.Add(mkArtikelObject(reader));
                //listBoxAusgabe.DisplayMember = "Display";
                //listBoxAusgabe.Items.Add(reader["ArtikelOid"].ToString() + " °^° " + reader["Bezeichnung"].ToString());
            }
            reader.Close();
            listBoxAusgabe.DataSource = listArtikel;
            listBoxAusgabe.DisplayMember = "Display";
        }

        private Artikel mkArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            int i = 0;

            a.ArtikelOid = Convert.ToInt32(reader[i++]);
            a.ArtikelNr = Convert.ToString(convertToNull(reader[i++]));
            a.ArtikelGruppe = Convert.ToInt32(convertToNull(reader[i++]));
            a.Bezeichnung = Convert.ToString(convertToNull(reader[i++]));
            a.Bestand = Convert.ToInt16(convertToNull(reader[i++]));
            a.Meldebestand = Convert.ToInt16(convertToNull(reader[i++]));
            a.Verpackung = Convert.ToInt32(convertToNull(reader[i++]));
            a.VkPreis = Convert.ToDecimal(convertToNull(reader[i++]));
            a.LetzeEntnahme = Convert.ToDateTime(convertToNull(reader[i++]));
            
            return a;
        }

        private object convertToNull(object v)
        {
            if (v.Equals(DBNull.Value))
            {
                return null;
            }
            return v;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            CreateArticle ca = new CreateArticle(con);
            ca.ShowDialog(); // Modal / ca.Show() nicht modal
            if (ca.NewArtikel != null)
            {
                listArtikel.Add(ca.NewArtikel);
            }
        }


    }
}
