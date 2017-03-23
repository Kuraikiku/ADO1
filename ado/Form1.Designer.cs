namespace ado
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
            this.buttonConn = new System.Windows.Forms.Button();
            this.buttonSql = new System.Windows.Forms.Button();
            this.buttonAuslesen = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonConn
            // 
            this.buttonConn.Location = new System.Drawing.Point(25, 22);
            this.buttonConn.Name = "buttonConn";
            this.buttonConn.Size = new System.Drawing.Size(208, 29);
            this.buttonConn.TabIndex = 0;
            this.buttonConn.Text = "Connection öffnen";
            this.buttonConn.UseVisualStyleBackColor = true;
            this.buttonConn.Click += new System.EventHandler(this.buttonConn_Click);
            // 
            // buttonSql
            // 
            this.buttonSql.Enabled = false;
            this.buttonSql.Location = new System.Drawing.Point(25, 57);
            this.buttonSql.Name = "buttonSql";
            this.buttonSql.Size = new System.Drawing.Size(208, 29);
            this.buttonSql.TabIndex = 1;
            this.buttonSql.Text = "SQL - Command";
            this.buttonSql.UseVisualStyleBackColor = true;
            this.buttonSql.Click += new System.EventHandler(this.buttonSql_Click);
            // 
            // buttonAuslesen
            // 
            this.buttonAuslesen.Enabled = false;
            this.buttonAuslesen.Location = new System.Drawing.Point(25, 92);
            this.buttonAuslesen.Name = "buttonAuslesen";
            this.buttonAuslesen.Size = new System.Drawing.Size(208, 29);
            this.buttonAuslesen.TabIndex = 2;
            this.buttonAuslesen.Text = "auslesen";
            this.buttonAuslesen.UseVisualStyleBackColor = true;
            this.buttonAuslesen.Click += new System.EventHandler(this.buttonAuslesen_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(25, 139);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(208, 186);
            this.listBoxAusgabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 346);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonAuslesen);
            this.Controls.Add(this.buttonSql);
            this.Controls.Add(this.buttonConn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConn;
        private System.Windows.Forms.Button buttonSql;
        private System.Windows.Forms.Button buttonAuslesen;
        private System.Windows.Forms.ListBox listBoxAusgabe;
    }
}

