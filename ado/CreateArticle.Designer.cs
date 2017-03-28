namespace ado
{
    partial class CreateArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxArtikelOid = new System.Windows.Forms.TextBox();
            this.textBoxArtikelNr = new System.Windows.Forms.TextBox();
            this.textBoxArtikelGruppe = new System.Windows.Forms.TextBox();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxBestand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVerpackung = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArtikelOid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ArikelNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ArikelGruppe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bezeichnung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bestand";
            // 
            // textBoxArtikelOid
            // 
            this.textBoxArtikelOid.Location = new System.Drawing.Point(100, 13);
            this.textBoxArtikelOid.Name = "textBoxArtikelOid";
            this.textBoxArtikelOid.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelOid.TabIndex = 5;
            // 
            // textBoxArtikelNr
            // 
            this.textBoxArtikelNr.Location = new System.Drawing.Point(100, 39);
            this.textBoxArtikelNr.Name = "textBoxArtikelNr";
            this.textBoxArtikelNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelNr.TabIndex = 6;
            // 
            // textBoxArtikelGruppe
            // 
            this.textBoxArtikelGruppe.Location = new System.Drawing.Point(100, 65);
            this.textBoxArtikelGruppe.Name = "textBoxArtikelGruppe";
            this.textBoxArtikelGruppe.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelGruppe.TabIndex = 7;
            this.textBoxArtikelGruppe.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxArtikelGruppe_Validating);
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(100, 91);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(100, 20);
            this.textBoxBezeichnung.TabIndex = 8;
            // 
            // textBoxBestand
            // 
            this.textBoxBestand.Location = new System.Drawing.Point(100, 117);
            this.textBoxBestand.Name = "textBoxBestand";
            this.textBoxBestand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBestand.TabIndex = 9;
            this.textBoxBestand.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBestand_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Verpackung";
            // 
            // textBoxVerpackung
            // 
            this.textBoxVerpackung.Location = new System.Drawing.Point(100, 143);
            this.textBoxVerpackung.Name = "textBoxVerpackung";
            this.textBoxVerpackung.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerpackung.TabIndex = 11;
            this.textBoxVerpackung.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVerpackung_Validating);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(16, 204);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(116, 204);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 13;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            // 
            // CreateArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 242);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxVerpackung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBestand);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.textBoxArtikelGruppe);
            this.Controls.Add(this.textBoxArtikelNr);
            this.Controls.Add(this.textBoxArtikelOid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateArticle";
            this.Text = "Artikel aufnehmen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxArtikelOid;
        private System.Windows.Forms.TextBox textBoxArtikelNr;
        private System.Windows.Forms.TextBox textBoxArtikelGruppe;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxBestand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVerpackung;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}