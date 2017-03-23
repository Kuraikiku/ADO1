﻿using System;
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
        public Form1()
        {

            InitializeComponent();
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
        }

        private void buttonSql_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.Parameters.Add("AGR", OleDbType.Integer);
            listBoxAusgabe.Items.Clear();
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
            while(reader.Read())
            {
                listBoxAusgabe.Items.Add(reader["ArtikelOid"].ToString() + " °^° " + reader["Bezeichnung"].ToString());
            }
        }
    }
}
