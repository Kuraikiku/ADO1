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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Kurs> vieleKurse = null;
        List<Teilnehmer> vieleT = null;
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;

        public Form1()
        {
            InitializeComponent();
            vieleKurse = new List<Kurs>();
            vieleT = new List<Teilnehmer>();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(Properties.Settings.Default.KursDB);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tKurs";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kurs k = new Kurs();
                k.Id = Convert.ToInt16(reader[0]);
                k.Bezeichnung = reader[1].ToString();
                k.Datum = Convert.ToDateTime(reader[2]);
                vieleKurse.Add(k);

            }
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tTeilnehmer";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

           

            while (reader.Read())
            {
                Teilnehmer t = new Teilnehmer();
                t.Id = Convert.ToInt16(reader[0]);
                t.Nachname = reader[1].ToString();
                t.Vorname = reader[2].ToString();
                t.Email = reader[3].ToString();
                vieleT.Add(t);
                
            }

            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tTeilnehmer";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();

            comboBoxTeilnehmer.DataSource = vieleT;
            comboBoxTeilnehmer.DisplayMember = "Display2";
            comboBoxKurse.DataSource = vieleKurse;
            comboBoxKurse.DisplayMember = "Display1";

        }
    }
}
