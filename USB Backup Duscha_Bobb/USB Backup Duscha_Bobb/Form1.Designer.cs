namespace USB_Backup_Duscha_Bobb
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelquelle = new System.Windows.Forms.Label();
            this.labelZiel = new System.Windows.Forms.Label();
            this.textBoxQuelle = new System.Windows.Forms.TextBox();
            this.textBoxziel = new System.Windows.Forms.TextBox();
            this.Buttonquelle = new System.Windows.Forms.Button();
            this.buttonZiel = new System.Windows.Forms.Button();
            this.labeloptionen = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.labelinfo = new System.Windows.Forms.Label();
            this.labelverstrichenezeit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fDiaquelle = new System.Windows.Forms.FolderBrowserDialog();
            this.fDiaziel = new System.Windows.Forms.FolderBrowserDialog();
            this.labelverstrichen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidenoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprachenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deustchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NorwegischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachtmodusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelanzahldateien = new System.Windows.Forms.Label();
            this.labelAnzahl = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.checkBoxHochladen = new System.Windows.Forms.CheckBox();
            this.buttonupload = new System.Windows.Forms.Button();
            this.comboBoxHoster = new System.Windows.Forms.ComboBox();
            this.checkBoxArchivieren = new System.Windows.Forms.CheckBox();
            this.buttonArchivieren = new System.Windows.Forms.Button();
            this.checkBoxarchivierenohneup = new System.Windows.Forms.CheckBox();
            this.checkBoxaktuell = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelquelle
            // 
            this.labelquelle.AutoSize = true;
            this.labelquelle.Location = new System.Drawing.Point(5, 40);
            this.labelquelle.Name = "labelquelle";
            this.labelquelle.Size = new System.Drawing.Size(87, 13);
            this.labelquelle.TabIndex = 0;
            this.labelquelle.Text = "Quellverzeichnis:";
            // 
            // labelZiel
            // 
            this.labelZiel.AutoSize = true;
            this.labelZiel.Location = new System.Drawing.Point(12, 66);
            this.labelZiel.Name = "labelZiel";
            this.labelZiel.Size = new System.Drawing.Size(80, 13);
            this.labelZiel.TabIndex = 1;
            this.labelZiel.Text = "Zielverzeichnis:";
            // 
            // textBoxQuelle
            // 
            this.textBoxQuelle.Location = new System.Drawing.Point(106, 37);
            this.textBoxQuelle.Name = "textBoxQuelle";
            this.textBoxQuelle.Size = new System.Drawing.Size(244, 20);
            this.textBoxQuelle.TabIndex = 2;
            // 
            // textBoxziel
            // 
            this.textBoxziel.Location = new System.Drawing.Point(106, 63);
            this.textBoxziel.Name = "textBoxziel";
            this.textBoxziel.Size = new System.Drawing.Size(244, 20);
            this.textBoxziel.TabIndex = 3;
            // 
            // Buttonquelle
            // 
            this.Buttonquelle.Location = new System.Drawing.Point(366, 35);
            this.Buttonquelle.Name = "Buttonquelle";
            this.Buttonquelle.Size = new System.Drawing.Size(31, 23);
            this.Buttonquelle.TabIndex = 4;
            this.Buttonquelle.Text = "...";
            this.Buttonquelle.UseVisualStyleBackColor = true;
            this.Buttonquelle.Click += new System.EventHandler(this.Buttonquelle_Click);
            // 
            // buttonZiel
            // 
            this.buttonZiel.Location = new System.Drawing.Point(366, 61);
            this.buttonZiel.Name = "buttonZiel";
            this.buttonZiel.Size = new System.Drawing.Size(31, 23);
            this.buttonZiel.TabIndex = 5;
            this.buttonZiel.Text = "...";
            this.buttonZiel.UseVisualStyleBackColor = true;
            this.buttonZiel.Click += new System.EventHandler(this.buttonZiel_Click);
            // 
            // labeloptionen
            // 
            this.labeloptionen.AutoSize = true;
            this.labeloptionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloptionen.Location = new System.Drawing.Point(13, 115);
            this.labeloptionen.Name = "labeloptionen";
            this.labeloptionen.Size = new System.Drawing.Size(62, 13);
            this.labeloptionen.TabIndex = 13;
            this.labeloptionen.Text = "Optionen:";
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(135, 212);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(106, 23);
            this.buttonstart.TabIndex = 14;
            this.buttonstart.Text = "Backup beginnen";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinfo.Location = new System.Drawing.Point(12, 274);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(88, 13);
            this.labelinfo.TabIndex = 15;
            this.labelinfo.Text = "Informationen:";
            // 
            // labelverstrichenezeit
            // 
            this.labelverstrichenezeit.AutoSize = true;
            this.labelverstrichenezeit.Location = new System.Drawing.Point(12, 316);
            this.labelverstrichenezeit.Name = "labelverstrichenezeit";
            this.labelverstrichenezeit.Size = new System.Drawing.Size(104, 13);
            this.labelverstrichenezeit.TabIndex = 18;
            this.labelverstrichenezeit.Text = "Dauer des Backups:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 19;
            // 
            // labelverstrichen
            // 
            this.labelverstrichen.AutoSize = true;
            this.labelverstrichen.Location = new System.Drawing.Point(167, 316);
            this.labelverstrichen.Name = "labelverstrichen";
            this.labelverstrichen.Size = new System.Drawing.Size(110, 13);
            this.labelverstrichen.TabIndex = 21;
            this.labelverstrichen.Text = "Noch nicht begonnen";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.einstellungToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macherToolStripMenuItem,
            this.sidenoteToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // macherToolStripMenuItem
            // 
            this.macherToolStripMenuItem.Name = "macherToolStripMenuItem";
            this.macherToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.macherToolStripMenuItem.Text = "Created by";
            this.macherToolStripMenuItem.Click += new System.EventHandler(this.macherToolStripMenuItem_Click);
            // 
            // sidenoteToolStripMenuItem
            // 
            this.sidenoteToolStripMenuItem.Name = "sidenoteToolStripMenuItem";
            this.sidenoteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sidenoteToolStripMenuItem.Text = "Sidenote";
            this.sidenoteToolStripMenuItem.Click += new System.EventHandler(this.sidenoteToolStripMenuItem_Click);
            // 
            // einstellungToolStripMenuItem
            // 
            this.einstellungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprachenToolStripMenuItem,
            this.nachtmodusToolStripMenuItem});
            this.einstellungToolStripMenuItem.Name = "einstellungToolStripMenuItem";
            this.einstellungToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungToolStripMenuItem.Text = "Einstellungen";
            // 
            // sprachenToolStripMenuItem
            // 
            this.sprachenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deustchToolStripMenuItem,
            this.englischToolStripMenuItem,
            this.NorwegischToolStripMenuItem});
            this.sprachenToolStripMenuItem.Name = "sprachenToolStripMenuItem";
            this.sprachenToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sprachenToolStripMenuItem.Text = "Sprachen";
            // 
            // deustchToolStripMenuItem
            // 
            this.deustchToolStripMenuItem.Name = "deustchToolStripMenuItem";
            this.deustchToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deustchToolStripMenuItem.Text = "Deustch";
            this.deustchToolStripMenuItem.Click += new System.EventHandler(this.deustchToolStripMenuItem_Click);
            // 
            // englischToolStripMenuItem
            // 
            this.englischToolStripMenuItem.Name = "englischToolStripMenuItem";
            this.englischToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.englischToolStripMenuItem.Text = "Englisch";
            this.englischToolStripMenuItem.Click += new System.EventHandler(this.englischToolStripMenuItem_Click);
            // 
            // NorwegischToolStripMenuItem
            // 
            this.NorwegischToolStripMenuItem.Name = "NorwegischToolStripMenuItem";
            this.NorwegischToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.NorwegischToolStripMenuItem.Text = "Norwegisch";
            this.NorwegischToolStripMenuItem.Click += new System.EventHandler(this.schwedischToolStripMenuItem_Click);
            // 
            // nachtmodusToolStripMenuItem
            // 
            this.nachtmodusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anToolStripMenuItem,
            this.ausToolStripMenuItem});
            this.nachtmodusToolStripMenuItem.Name = "nachtmodusToolStripMenuItem";
            this.nachtmodusToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.nachtmodusToolStripMenuItem.Text = "Nachtmodus";
            // 
            // anToolStripMenuItem
            // 
            this.anToolStripMenuItem.Name = "anToolStripMenuItem";
            this.anToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.anToolStripMenuItem.Text = "An";
            this.anToolStripMenuItem.Click += new System.EventHandler(this.anToolStripMenuItem_Click);
            // 
            // ausToolStripMenuItem
            // 
            this.ausToolStripMenuItem.Name = "ausToolStripMenuItem";
            this.ausToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.ausToolStripMenuItem.Text = "Aus";
            this.ausToolStripMenuItem.Click += new System.EventHandler(this.ausToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontaktToolStripMenuItem,
            this.hilfeToolStripMenuItem1});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.kontaktToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem1
            // 
            this.hilfeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem});
            this.hilfeToolStripMenuItem1.Name = "hilfeToolStripMenuItem1";
            this.hilfeToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.hilfeToolStripMenuItem1.Text = "Hilfe";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // labelanzahldateien
            // 
            this.labelanzahldateien.AutoSize = true;
            this.labelanzahldateien.Location = new System.Drawing.Point(13, 294);
            this.labelanzahldateien.Name = "labelanzahldateien";
            this.labelanzahldateien.Size = new System.Drawing.Size(126, 13);
            this.labelanzahldateien.TabIndex = 24;
            this.labelanzahldateien.Text = "Anzahl kopierter Dateien:";
            // 
            // labelAnzahl
            // 
            this.labelAnzahl.AutoSize = true;
            this.labelAnzahl.Location = new System.Drawing.Point(167, 294);
            this.labelAnzahl.Name = "labelAnzahl";
            this.labelAnzahl.Size = new System.Drawing.Size(63, 13);
            this.labelAnzahl.TabIndex = 25;
            this.labelAnzahl.Text = "Noch Keine";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(403, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(484, 473);
            this.webBrowser.TabIndex = 26;
            this.webBrowser.Visible = false;
            // 
            // checkBoxHochladen
            // 
            this.checkBoxHochladen.AutoSize = true;
            this.checkBoxHochladen.Location = new System.Drawing.Point(232, 131);
            this.checkBoxHochladen.Name = "checkBoxHochladen";
            this.checkBoxHochladen.Size = new System.Drawing.Size(118, 17);
            this.checkBoxHochladen.TabIndex = 27;
            this.checkBoxHochladen.Text = "Backup Hochladen";
            this.checkBoxHochladen.UseVisualStyleBackColor = true;
            // 
            // buttonupload
            // 
            this.buttonupload.Location = new System.Drawing.Point(275, 274);
            this.buttonupload.Name = "buttonupload";
            this.buttonupload.Size = new System.Drawing.Size(122, 23);
            this.buttonupload.TabIndex = 29;
            this.buttonupload.Text = "Upload beginnen";
            this.buttonupload.UseVisualStyleBackColor = true;
            this.buttonupload.Visible = false;
            this.buttonupload.Click += new System.EventHandler(this.buttonupload_Click);
            // 
            // comboBoxHoster
            // 
            this.comboBoxHoster.FormattingEnabled = true;
            this.comboBoxHoster.Location = new System.Drawing.Point(276, 246);
            this.comboBoxHoster.Name = "comboBoxHoster";
            this.comboBoxHoster.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHoster.TabIndex = 30;
            this.comboBoxHoster.Visible = false;
            // 
            // checkBoxArchivieren
            // 
            this.checkBoxArchivieren.AutoSize = true;
            this.checkBoxArchivieren.Location = new System.Drawing.Point(19, 364);
            this.checkBoxArchivieren.Name = "checkBoxArchivieren";
            this.checkBoxArchivieren.Size = new System.Drawing.Size(171, 17);
            this.checkBoxArchivieren.TabIndex = 31;
            this.checkBoxArchivieren.Text = "Backup Archivieren für Upload";
            this.checkBoxArchivieren.UseVisualStyleBackColor = true;
            this.checkBoxArchivieren.Visible = false;
            // 
            // buttonArchivieren
            // 
            this.buttonArchivieren.Location = new System.Drawing.Point(19, 387);
            this.buttonArchivieren.Name = "buttonArchivieren";
            this.buttonArchivieren.Size = new System.Drawing.Size(151, 23);
            this.buttonArchivieren.TabIndex = 33;
            this.buttonArchivieren.Text = "Archivieren";
            this.buttonArchivieren.UseVisualStyleBackColor = true;
            this.buttonArchivieren.Visible = false;
            this.buttonArchivieren.Click += new System.EventHandler(this.buttonArchivieren_Click);
            // 
            // checkBoxarchivierenohneup
            // 
            this.checkBoxarchivierenohneup.AutoSize = true;
            this.checkBoxarchivierenohneup.Location = new System.Drawing.Point(73, 131);
            this.checkBoxarchivierenohneup.Name = "checkBoxarchivierenohneup";
            this.checkBoxarchivierenohneup.Size = new System.Drawing.Size(119, 17);
            this.checkBoxarchivierenohneup.TabIndex = 34;
            this.checkBoxarchivierenohneup.Text = "Backup Archivieren";
            this.checkBoxarchivierenohneup.UseVisualStyleBackColor = true;
            // 
            // checkBoxaktuell
            // 
            this.checkBoxaktuell.AutoSize = true;
            this.checkBoxaktuell.Location = new System.Drawing.Point(73, 164);
            this.checkBoxaktuell.Name = "checkBoxaktuell";
            this.checkBoxaktuell.Size = new System.Drawing.Size(125, 17);
            this.checkBoxaktuell.TabIndex = 35;
            this.checkBoxaktuell.Text = "Dateien aktualisieren";
            this.checkBoxaktuell.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 497);
            this.Controls.Add(this.checkBoxaktuell);
            this.Controls.Add(this.checkBoxarchivierenohneup);
            this.Controls.Add(this.buttonArchivieren);
            this.Controls.Add(this.checkBoxArchivieren);
            this.Controls.Add(this.comboBoxHoster);
            this.Controls.Add(this.buttonupload);
            this.Controls.Add(this.checkBoxHochladen);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.labelAnzahl);
            this.Controls.Add(this.labelanzahldateien);
            this.Controls.Add(this.labelverstrichen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelverstrichenezeit);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.labeloptionen);
            this.Controls.Add(this.buttonZiel);
            this.Controls.Add(this.Buttonquelle);
            this.Controls.Add(this.textBoxziel);
            this.Controls.Add(this.textBoxQuelle);
            this.Controls.Add(this.labelZiel);
            this.Controls.Add(this.labelquelle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "USB Backup by Marvin und Artur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelquelle;
        private System.Windows.Forms.Label labelZiel;
        private System.Windows.Forms.TextBox textBoxQuelle;
        private System.Windows.Forms.TextBox textBoxziel;
        private System.Windows.Forms.Button Buttonquelle;
        private System.Windows.Forms.Button buttonZiel;
        private System.Windows.Forms.Label labeloptionen;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label labelverstrichenezeit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog fDiaquelle;
        private System.Windows.Forms.FolderBrowserDialog fDiaziel;
        private System.Windows.Forms.Label labelverstrichen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macherToolStripMenuItem;
        private System.Windows.Forms.Label labelanzahldateien;
        private System.Windows.Forms.Label labelAnzahl;
        private System.Windows.Forms.ToolStripMenuItem sidenoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprachenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deustchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NorwegischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachtmodusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.CheckBox checkBoxHochladen;
        private System.Windows.Forms.Button buttonupload;
        private System.Windows.Forms.ComboBox comboBoxHoster;
        private System.Windows.Forms.CheckBox checkBoxArchivieren;
        private System.Windows.Forms.Button buttonArchivieren;
        private System.Windows.Forms.CheckBox checkBoxarchivierenohneup;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxaktuell;
    }
}

