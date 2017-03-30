namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShow = new System.Windows.Forms.Button();
            this.groupBoxKurs = new System.Windows.Forms.GroupBox();
            this.comboBoxKurse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKID = new System.Windows.Forms.TextBox();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.groupBoxTeilnehmer = new System.Windows.Forms.GroupBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxTID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTeilnehmer = new System.Windows.Forms.ComboBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonKurs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxKurs.SuspendLayout();
            this.groupBoxTeilnehmer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(21, 20);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(566, 23);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Zeige Daten";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // groupBoxKurs
            // 
            this.groupBoxKurs.Controls.Add(this.textBoxDatum);
            this.groupBoxKurs.Controls.Add(this.textBoxBezeichnung);
            this.groupBoxKurs.Controls.Add(this.textBoxKID);
            this.groupBoxKurs.Controls.Add(this.label3);
            this.groupBoxKurs.Controls.Add(this.label2);
            this.groupBoxKurs.Controls.Add(this.label1);
            this.groupBoxKurs.Controls.Add(this.comboBoxKurse);
            this.groupBoxKurs.Location = new System.Drawing.Point(21, 49);
            this.groupBoxKurs.Name = "groupBoxKurs";
            this.groupBoxKurs.Size = new System.Drawing.Size(267, 160);
            this.groupBoxKurs.TabIndex = 1;
            this.groupBoxKurs.TabStop = false;
            this.groupBoxKurs.Text = "Kurse";
            // 
            // comboBoxKurse
            // 
            this.comboBoxKurse.FormattingEnabled = true;
            this.comboBoxKurse.Location = new System.Drawing.Point(18, 19);
            this.comboBoxKurse.Name = "comboBoxKurse";
            this.comboBoxKurse.Size = new System.Drawing.Size(230, 21);
            this.comboBoxKurse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bezeichnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum";
            // 
            // textBoxKID
            // 
            this.textBoxKID.Location = new System.Drawing.Point(89, 51);
            this.textBoxKID.Name = "textBoxKID";
            this.textBoxKID.Size = new System.Drawing.Size(159, 20);
            this.textBoxKID.TabIndex = 4;
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(90, 77);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(159, 20);
            this.textBoxBezeichnung.TabIndex = 5;
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(90, 103);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(159, 20);
            this.textBoxDatum.TabIndex = 6;
            // 
            // groupBoxTeilnehmer
            // 
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxEMail);
            this.groupBoxTeilnehmer.Controls.Add(this.label7);
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxVorname);
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxNachname);
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxTID);
            this.groupBoxTeilnehmer.Controls.Add(this.label4);
            this.groupBoxTeilnehmer.Controls.Add(this.label5);
            this.groupBoxTeilnehmer.Controls.Add(this.label6);
            this.groupBoxTeilnehmer.Controls.Add(this.comboBoxTeilnehmer);
            this.groupBoxTeilnehmer.Location = new System.Drawing.Point(320, 49);
            this.groupBoxTeilnehmer.Name = "groupBoxTeilnehmer";
            this.groupBoxTeilnehmer.Size = new System.Drawing.Size(267, 160);
            this.groupBoxTeilnehmer.TabIndex = 7;
            this.groupBoxTeilnehmer.TabStop = false;
            this.groupBoxTeilnehmer.Text = "Teilnehmer";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(90, 103);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(159, 20);
            this.textBoxVorname.TabIndex = 6;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(90, 77);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(159, 20);
            this.textBoxNachname.TabIndex = 5;
            // 
            // textBoxTID
            // 
            this.textBoxTID.Location = new System.Drawing.Point(89, 51);
            this.textBoxTID.Name = "textBoxTID";
            this.textBoxTID.Size = new System.Drawing.Size(159, 20);
            this.textBoxTID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vorname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID";
            // 
            // comboBoxTeilnehmer
            // 
            this.comboBoxTeilnehmer.FormattingEnabled = true;
            this.comboBoxTeilnehmer.Location = new System.Drawing.Point(18, 19);
            this.comboBoxTeilnehmer.Name = "comboBoxTeilnehmer";
            this.comboBoxTeilnehmer.Size = new System.Drawing.Size(230, 21);
            this.comboBoxTeilnehmer.TabIndex = 0;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(90, 129);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(159, 20);
            this.textBoxEMail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "E-Mail";
            // 
            // buttonKurs
            // 
            this.buttonKurs.Location = new System.Drawing.Point(21, 215);
            this.buttonKurs.Name = "buttonKurs";
            this.buttonKurs.Size = new System.Drawing.Size(267, 23);
            this.buttonKurs.TabIndex = 8;
            this.buttonKurs.Text = "Kurs.csv";
            this.buttonKurs.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Teilnehmer.csv";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKurs);
            this.Controls.Add(this.groupBoxTeilnehmer);
            this.Controls.Add(this.groupBoxKurs);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxKurs.ResumeLayout(false);
            this.groupBoxKurs.PerformLayout();
            this.groupBoxTeilnehmer.ResumeLayout(false);
            this.groupBoxTeilnehmer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.GroupBox groupBoxKurs;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.TextBox textBoxKID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKurse;
        private System.Windows.Forms.GroupBox groupBoxTeilnehmer;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxTID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTeilnehmer;
        private System.Windows.Forms.Button buttonKurs;
        private System.Windows.Forms.Button button1;
    }
}

