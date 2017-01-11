#region using System.'s
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Neu eingefügte System. 's
using System.IO; //Input Output
using System.Diagnostics; //Zeit messen
using System.IO.Compression; //Zum Archivieren
using System.Globalization; //Systemsprache erkennen
#endregion

namespace USB_Backup_Duscha_Bobb
{

    public partial class Form1 : Form
    {
        #region Globale Deklaration und Initialisierung
        //Deklaration und Initialisierung (Global)
        string sCulture = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
        private ToolStripMenuItem tsmiInfo;
        private ToolStripMenuItem tsmiInfo2;
        private ToolStripMenuItem tsmiInfo3;
        Int32 iZaehler;
        #endregion

        #region FormInitialisierung
        public Form1()
        {
            InitializeComponent();

            #region Begrüßung und auf die Sprache einstellen

            //Wenn Systemsprache "de" stellt er alles auf Deutsch
            if (sCulture == "de")
            {
                #region Checked unchecked wechsel
                tsmiInfo = this.englischToolStripMenuItem;
                tsmiInfo2 = this.deustchToolStripMenuItem;
                tsmiInfo3 = this.NorwegischToolStripMenuItem;

                tsmiInfo.CheckState = CheckState.Unchecked;
                tsmiInfo2.CheckState = CheckState.Checked;
                tsmiInfo3.CheckState = CheckState.Unchecked;
                #endregion

                MessageBox.Show("Willkommen " + Environment.UserName, "Begrüßung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelquelle.Text = "Quellverzeichnis:";
                labelZiel.Text = "Zielverzeichnis:";
                labeloptionen.Text = "Optionen:";
                checkBoxarchivierenohneup.Text = "Backup archivieren";
                checkBoxHochladen.Text = "Backup hochladen";
                buttonstart.Text = "Backup beginnen";
                labelinfo.Text = "Informationen:";
                buttonupload.Text = "Upload beginnen";
                labelanzahldateien.Text = "Anzahl kopierter Dateien:";
                labelverstrichenezeit.Text = "Dauer des Backups:";
                checkBoxArchivieren.Text = "Backup Archivieren für Upload";
                buttonArchivieren.Text = "Archivieren";
                labelAnzahl.Text = "Noch keine";
                labelverstrichen.Text = "Noch nicht begonnen";

                //Toolbar
                einstellungToolStripMenuItem.Text = "Einstellungen";
                sprachenToolStripMenuItem.Text = "Sprache";
                nachtmodusToolStripMenuItem.Text = "Nachtmodus";
                deustchToolStripMenuItem.Text = "Deutsch";
                englischToolStripMenuItem.Text = "Englisch";
                NorwegischToolStripMenuItem.Text = "Norwegisch";
                hilfeToolStripMenuItem.Text = "Hilfe";
                kontaktToolStripMenuItem.Text = "Kontakt";
                hilfeToolStripMenuItem1.Text = "Hilfe";
                fAQToolStripMenuItem.Text = "FAQ";
                sidenoteToolStripMenuItem.Text = "Sidenote";
                anToolStripMenuItem.Text = "An";
                ausToolStripMenuItem.Text = "Aus";
            }

            //Easteregg Norwegisch übersetzung
            else if (sCulture == "no" || sCulture == "nor")
            {
                #region Checked unchecked wechsel
                tsmiInfo = this.englischToolStripMenuItem;
                tsmiInfo2 = this.deustchToolStripMenuItem;
                tsmiInfo3 = this.NorwegischToolStripMenuItem;

                tsmiInfo.CheckState = CheckState.Unchecked;
                tsmiInfo2.CheckState = CheckState.Unchecked;
                tsmiInfo3.CheckState = CheckState.Checked;
                #endregion

                MessageBox.Show("Velkommen " + Environment.UserName, "Velkommen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelquelle.Text = "kildekatalogen:";
                labelZiel.Text = "målkatalogen:";
                labeloptionen.Text = "opsjoner:";
                checkBoxarchivierenohneup.Text = "arkiv sikkerhetskopier";
                checkBoxHochladen.Text = "Last opp sikkerhetskopier";
                buttonstart.Text = "Opprett sikkerhetskopier";
                labelinfo.Text = "informasjon:";
                buttonupload.Text = "begynne sikkerhetskopier";
                labelanzahldateien.Text = "Antall kopierte filer:";
                labelverstrichenezeit.Text = "Varighet av sikkerhetskopier:";
                checkBoxArchivieren.Text = "Backup arkiv for opplasting";
                buttonArchivieren.Text = "arkiv";
                labelAnzahl.Text = "mer ikke";
                labelverstrichen.Text = "ikke startet";


                //Toolbar
                einstellungToolStripMenuItem.Text = "innstillinger";
                sprachenToolStripMenuItem.Text = "språk";
                nachtmodusToolStripMenuItem.Text = "nattmodus";
                deustchToolStripMenuItem.Text = "tysk";
                englischToolStripMenuItem.Text = "engelsk";
                NorwegischToolStripMenuItem.Text = "norsk";
                hilfeToolStripMenuItem.Text = "Hjelp";
                kontaktToolStripMenuItem.Text = "kontakt";
                hilfeToolStripMenuItem1.Text = "Hjelp";
                fAQToolStripMenuItem.Text = "FAQ";
                sidenoteToolStripMenuItem.Text = "Side note";
                anToolStripMenuItem.Text = "en";
                ausToolStripMenuItem.Text = "fra ";
            }

            //Englisch übersetzung
            //Stellt auf englisch wenn System en oder anderes ist
            else
            {
                #region Checked unchecked wechsel
                tsmiInfo = this.englischToolStripMenuItem;
                tsmiInfo2 = this.deustchToolStripMenuItem;
                tsmiInfo3 = this.NorwegischToolStripMenuItem;

                tsmiInfo.CheckState = CheckState.Checked;
                tsmiInfo2.CheckState = CheckState.Unchecked;
                tsmiInfo3.CheckState = CheckState.Unchecked;
                #endregion

                MessageBox.Show("Welcome " + Environment.UserName, "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelquelle.Text = "Source Directory:";
                labelZiel.Text = "Target Directory:";
                labeloptionen.Text = "Options:";
                checkBoxarchivierenohneup.Text = "Archive backup";
                checkBoxHochladen.Text = "Upload backup";
                buttonstart.Text = "Start backup";
                labelinfo.Text = "Informations:";
                buttonupload.Text = "Upload";
                labelanzahldateien.Text = "Number of copied files:";
                labelverstrichenezeit.Text = "Duration of backup:";
                checkBoxArchivieren.Text = "Archive backup for upload";
                buttonArchivieren.Text = "Archive";
                labelAnzahl.Text = "None yet";
                labelverstrichen.Text = "Didn't started yet";

                //Toolbar
                einstellungToolStripMenuItem.Text = "Settings";
                sprachenToolStripMenuItem.Text = "Language";
                nachtmodusToolStripMenuItem.Text = "Nightmode";
                deustchToolStripMenuItem.Text = "German";
                englischToolStripMenuItem.Text = "English";
                NorwegischToolStripMenuItem.Text = "Norwegian";
                hilfeToolStripMenuItem.Text = "Help";
                kontaktToolStripMenuItem.Text = "Contact";
                hilfeToolStripMenuItem1.Text = "Help";
                fAQToolStripMenuItem.Text = "FAQ";
                sidenoteToolStripMenuItem.Text = "Sidenote";
                anToolStripMenuItem.Text = "On";
                ausToolStripMenuItem.Text = "Off";
            }
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttonquelle
        private void Buttonquelle_Click(object sender, EventArgs e)
        {
            //Quellpfad auswählen
            fDiaquelle.ShowDialog();
            //Quellpfad in Textbox einfügen
            textBoxQuelle.Text = fDiaquelle.SelectedPath;
            iZaehler++;
        }
        #endregion

        #region Buttonziel
        private void buttonZiel_Click(object sender, EventArgs e)
        {
            //Zielpfad auswählen
            fDiaziel.ShowDialog();

            //Backup Ordner erstellen
            fDiaziel.SelectedPath = fDiaziel.SelectedPath + (@"\Backup ") + System.DateTime.Now.ToShortDateString();

            //Zielpfad in die Textbox mit Backup+Datum schreiben
            textBoxziel.Text = fDiaziel.SelectedPath;
            iZaehler++;
        }
        #endregion

        #region ButtonStart
        private void buttonstart_Click(object sender, EventArgs e)
        {
            //Try anfang, für die Co Hauptschleife
            try
            {
                #region Deklaration und Initialisierung
                //Deklaration & Initialisierung
                string sZielpfad = textBoxziel.Text;
                string sQuellpfad = textBoxQuelle.Text;
                DirectoryInfo dInfo = new DirectoryInfo(sQuellpfad);
                bool bRekursiv = false;
                bool bUeberschreiben = true;
                Stopwatch SZeit = new Stopwatch();
                Int32 iZahl = 0;
                #endregion

                #region Überprüfung auf Fehler der Eingabe
                //Überprüfung ob alles korrekt eingegeben wurde
                if (string.IsNullOrEmpty(textBoxziel.Text) || string.IsNullOrWhiteSpace(textBoxziel.Text) && iZaehler != 2)
                {
                    if (deustchToolStripMenuItem.Checked)
                    {
                        MessageBox.Show("Pfad darf nicht Leer sein!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else if (NorwegischToolStripMenuItem.Checked)
                    {
                        MessageBox.Show("Banen kan ikke være tomt", "Feil!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        MessageBox.Show("The path may not be empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                #endregion

                #region Schleife für keine Fehler startet
                else
                {
                    //iZaehler auf 2 setzen um das Backup zu starten
                    iZaehler = 2;

                    #region Zeit starten
                    //Zeit des Backups starten
                    SZeit.Start();
                    #endregion

                    #region Backup Methode Initialisieren
                    //Checken ob bedingung erfüllt und bRekursiv auf true setzen
                    if (checkBoxarchivierenohneup.Checked == false)
                    {
                        bRekursiv = true;
                        RekursivOrdnerKopieren(sQuellpfad, sZielpfad, bUeberschreiben, bRekursiv);
                    }
                    #endregion

                    #region Checkbox Hochladen
                    if (checkBoxHochladen.Checked)
                    {
                        //Alle sachen für Hochladen und Archivieren sichtbar machen
                        comboBoxHoster.Visible = true;
                        buttonupload.Visible = true;
                        buttonArchivieren.Visible = true;

                        //Checkbox für archivieren ohne Upload
                        if (checkBoxarchivierenohneup.Checked)
                        {
                            checkBoxArchivieren.Visible = false;
                            buttonArchivieren.Visible = false;
                        }

                        else
                        {
                            checkBoxArchivieren.Visible = true;
                            buttonArchivieren.Visible = true;
                        }

                        //Drop down liste Items hinzufügen
                        comboBoxHoster.Items.Add("Mit Anmeldung:");
                        comboBoxHoster.Items.Add("Dropbox");
                        comboBoxHoster.Items.Add("Mediafire");
                        comboBoxHoster.Items.Add("Minibox");
                        comboBoxHoster.Items.Add("Ohne Anmeldung:");
                        comboBoxHoster.Items.Add("FileDropper");
                    }
                    #endregion

                    #region Archivieren ohne Hochladen
                    if (checkBoxarchivierenohneup.Checked)
                    {
                        //Dateien aus fDateien=dInfo=sQuellpfad kriegen
                        FileInfo[] fDateien = dInfo.GetFiles();

                        //Variable die alles dursucht und in sich speichert
                        var vAlledateien = Directory.GetFiles(sQuellpfad, ".", SearchOption.AllDirectories);

                        //Dateien Zählen
                        foreach (string sDatei in vAlledateien)
                        {
                            iZahl++;
                        }
                        //Ausgeben der Anzahl
                        labelAnzahl.Text = Convert.ToString(iZahl);

                        //Archivieren ohne Upload
                        ZipFile.CreateFromDirectory(sQuellpfad, sZielpfad + ".zip", CompressionLevel.Optimal, true);
                    }
                    #endregion

                    #region Zeit stoppen und Ausgeben
                    //Zeit stopen und ausgeben
                    SZeit.Stop();
                    TimeSpan tZeit = SZeit.Elapsed;
                    labelverstrichen.Text = Convert.ToString(tZeit.Minutes + "m : " + tZeit.Seconds + "s");
                    #endregion

                    #region Abfrage zum Beenden
                    //Abfrage zur beenden des Programms
                    if (checkBoxHochladen.Checked != true)
                    {
                        if (NorwegischToolStripMenuItem.Checked && MessageBox.Show("Backup er ferdig.slutte nå ? ", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }

                        else if (deustchToolStripMenuItem.Checked && MessageBox.Show("Das Programm ist fertig. Beenden ?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }

                        else if (englischToolStripMenuItem.Checked && MessageBox.Show("Backup is done. Quit now ?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }

                    }
                }


            }
            #endregion
            #endregion

            #region Fehlermeldung
            //Wenn Fehler dann Fehlermeldung
            catch (Exception ex)
            {
                if (deustchToolStripMenuItem.Checked)
                {
                    MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else if (NorwegischToolStripMenuItem.Checked)
                {
                    MessageBox.Show(ex.Message, "Feil!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            #endregion
        }
        #endregion

        #region Unterordner Kopieren == AN sonst alles
        //Hauptschleife die das Backup macht
        private void RekursivOrdnerKopieren(string sQuelle, string sZiel, bool bUeberschreiben, bool bRekursiv)
        {
            //Nur wenn der Int auf 2 ist kann ein Backup gemacht werden
            if (iZaehler == 2)
            {
                //Deklaration
                int iPosSep = 0;
                string sOrdner;
                string[] saOrdner;
                DirectoryInfo dInfo = new DirectoryInfo(sQuelle);
                Int32 iZahl = 0;

                //Hinzufügen des Separators zu den eingegebenen Pfäden falls er nicht Existiert
                if (!sQuelle.EndsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    sQuelle += Path.DirectorySeparatorChar;
                }

                if (!sZiel.EndsWith(Path.DirectorySeparatorChar.ToString()))
                {
                    sZiel += Path.DirectorySeparatorChar;
                }

                //Wechsel zum eintauchen in die Ordner Struktur
                if (bRekursiv == true)
                {
                    //Liste der Ordner vom aktuellen Überordner
                    saOrdner = Directory.GetDirectories(sQuelle);

                    for (int i = 0; i <= saOrdner.GetUpperBound(0); i++)
                    {
                        //Letzte Position des Separatiors im aktuellen pfad
                        iPosSep = saOrdner[i].LastIndexOf(@"\");

                        //Pfad des Quellverzeichnisses kriegen
                        sOrdner = saOrdner[i].Substring((iPosSep + 1), saOrdner[i].Length - (iPosSep + 1));

                        //Ordner im Ziel Verzeichnis erstellen
                        Directory.CreateDirectory(sZiel + sOrdner);

                        //Kopieren der "Kinder" unterordnern
                        RekursivOrdnerKopieren(saOrdner[i], (sZiel + sOrdner), bRekursiv, bUeberschreiben);
                    }
                }

                //Dateien aus fDateien=dInfo=sQuellpfad kriegen
                FileInfo[] fDateien = dInfo.GetFiles();

                //Variable die alles dursucht und in sich speichert
                var vAlledateien = Directory.GetFiles(sQuelle, ".", SearchOption.AllDirectories);

                //Dateien Zählen
                foreach (string sDatei in vAlledateien)
                {
                    iZahl++;
                }
                //Ausgeben der Anzahl
                labelAnzahl.Text = Convert.ToString(iZahl);

                //Alle Dateien Kopieren vom quell ordner
                foreach (FileInfo fFile in fDateien)
                {
                    string temp = Path.Combine(sZiel, fFile.Name);
                    fFile.CopyTo(temp, false);
                }
                return;
            }


        }
        #endregion

        #region Macher ToolstripItem
        //Message Box wenn angeklickt zu den Erstellern des programms
        private void macherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by: Marvin Duscha\nCoded by: Artur Bobb\nTranslated by: Marvin Duscha und Artur Bobb", "Masterminds", MessageBoxButtons.OK);
        }
        #endregion

        #region Sidenote Toolstripitem
        //Sidenote in allen Sprachen die im moment vorhanden sind
        private void sidenoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deustchToolStripMenuItem.Checked)
            {
                MessageBox.Show("Dieses Projekt ist nur gelungen durch eine enge Zusammenarbeit mit Codefieber.de / msdn.microsoft.com / dotnet-snippets.de uvm.",
                "Dankeschön", MessageBoxButtons.OK);
            }

            else if (NorwegischToolStripMenuItem.Checked)
            {
                MessageBox.Show("Dette prosjektet er bare vellykket gjennom et nært samarbeid med Codefieber.de / msdn.microsoft.com / dotnet - snippets.de mye mer. ",
                "Takk", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("This project has only succeeded through a close cooperation with Codefieber.de / msdn.microsoft.com / dotnet-snippets.de uvm. ",
                "Thank you", MessageBoxButtons.OK);
            }
        }


        #endregion

        #region Übersetzungen

        //Englisch übersetzungen
        private void englischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Der Checked wechsel der Items
            #region Checked unchecked wechsel
            tsmiInfo = this.englischToolStripMenuItem;
            tsmiInfo2 = this.deustchToolStripMenuItem;
            tsmiInfo3 = this.NorwegischToolStripMenuItem;

            tsmiInfo.CheckState = CheckState.Checked;
            tsmiInfo2.CheckState = CheckState.Unchecked;
            tsmiInfo3.CheckState = CheckState.Unchecked;
            #endregion

            //Übersetzung der Labels, Buttons usw.
            labelquelle.Text = "Source Directory:";
            labelZiel.Text = "Target Directory:";
            labeloptionen.Text = "Options:";
            checkBoxarchivierenohneup.Text = "Archive backup";
            checkBoxHochladen.Text = "Upload backup";
            buttonstart.Text = "Start backup";
            labelinfo.Text = "Informations:";
            buttonupload.Text = "Upload";
            labelanzahldateien.Text = "Number of copied files:";
            labelverstrichenezeit.Text = "Duration of backup:";
            checkBoxArchivieren.Text = "Archive backup for upload";
            buttonArchivieren.Text = "Archive";
            labelAnzahl.Text = "None yet";
            labelverstrichen.Text = "Didn't started yet";

            //Toolbar
            einstellungToolStripMenuItem.Text = "Settings";
            sprachenToolStripMenuItem.Text = "Language";
            nachtmodusToolStripMenuItem.Text = "Nightmode";
            deustchToolStripMenuItem.Text = "German";
            englischToolStripMenuItem.Text = "English";
            NorwegischToolStripMenuItem.Text = "Norwegian";
            hilfeToolStripMenuItem.Text = "Help";
            kontaktToolStripMenuItem.Text = "Contact";
            hilfeToolStripMenuItem1.Text = "Help";
            fAQToolStripMenuItem.Text = "FAQ";
            sidenoteToolStripMenuItem.Text = "Sidenote";
            anToolStripMenuItem.Text = "On";
            ausToolStripMenuItem.Text = "Off";
        }

        //Deutsch Übersetzungen
        private void deustchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Der Checked wechsel der Items
            #region Checked unchecked wechsel
            tsmiInfo = this.englischToolStripMenuItem;
            tsmiInfo2 = this.deustchToolStripMenuItem;
            tsmiInfo3 = this.NorwegischToolStripMenuItem;

            tsmiInfo.CheckState = CheckState.Unchecked;
            tsmiInfo2.CheckState = CheckState.Checked;
            tsmiInfo3.CheckState = CheckState.Unchecked;
            #endregion

            //Übersetzung der Labels, Buttons usw.
            labelquelle.Text = "Quellverzeichnis:";
            labelZiel.Text = "Zielverzeichnis:";
            labeloptionen.Text = "Optionen:";
            checkBoxarchivierenohneup.Text = "Backup archivieren";
            checkBoxHochladen.Text = "Backup hochladen";
            buttonstart.Text = "Backup beginnen";
            labelinfo.Text = "Informationen:";
            buttonupload.Text = "Upload beginnen";
            labelanzahldateien.Text = "Anzahl kopierter Dateien:";
            labelverstrichenezeit.Text = "Dauer des Backups:";
            checkBoxArchivieren.Text = "Backup Archivieren für Upload";
            buttonArchivieren.Text = "Archivieren";
            labelAnzahl.Text = "Noch keine";
            labelverstrichen.Text = "Noch nicht begonnen";

            //Toolbar
            einstellungToolStripMenuItem.Text = "Einstellungen";
            sprachenToolStripMenuItem.Text = "Sprache";
            nachtmodusToolStripMenuItem.Text = "Nachtmodus";
            deustchToolStripMenuItem.Text = "Deutsch";
            englischToolStripMenuItem.Text = "Englisch";
            NorwegischToolStripMenuItem.Text = "Norwegisch";
            hilfeToolStripMenuItem.Text = "Hilfe";
            kontaktToolStripMenuItem.Text = "Kontakt";
            hilfeToolStripMenuItem1.Text = "Hilfe";
            fAQToolStripMenuItem.Text = "FAQ";
            sidenoteToolStripMenuItem.Text = "Sidenote";
            anToolStripMenuItem.Text = "An";
            ausToolStripMenuItem.Text = "Aus";

        }

        //Norwegisch Übersetzungen
        private void schwedischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Der Checked wechsel der Items
            #region Checked unchecked wechsel
            tsmiInfo = this.englischToolStripMenuItem;
            tsmiInfo2 = this.deustchToolStripMenuItem;
            tsmiInfo3 = this.NorwegischToolStripMenuItem;

            tsmiInfo.CheckState = CheckState.Unchecked;
            tsmiInfo2.CheckState = CheckState.Unchecked;
            tsmiInfo3.CheckState = CheckState.Checked;
            #endregion

            //Übersetzung der Labels, Buttons usw.
            labelquelle.Text = "kildekatalogen:";
            labelZiel.Text = "målkatalogen:";
            labeloptionen.Text = "opsjoner:";
            checkBoxarchivierenohneup.Text = "arkiv sikkerhetskopier";
            checkBoxHochladen.Text = "Last opp sikkerhetskopier";
            buttonstart.Text = "Opprett sikkerhetskopier";
            labelinfo.Text = "informasjon:";
            buttonupload.Text = "begynne sikkerhetskopier";
            labelanzahldateien.Text = "Antall kopierte filer:";
            labelverstrichenezeit.Text = "Varighet av sikkerhetskopier:";
            checkBoxArchivieren.Text = "Backup arkiv for opplasting";
            buttonArchivieren.Text = "arkiv";
            labelAnzahl.Text = "mer ikke";
            labelverstrichen.Text = "ikke startet";

            //Toolbar
            einstellungToolStripMenuItem.Text = "innstillinger";
            sprachenToolStripMenuItem.Text = "språk";
            nachtmodusToolStripMenuItem.Text = "nattmodus";
            deustchToolStripMenuItem.Text = "tysk";
            englischToolStripMenuItem.Text = "engelsk";
            NorwegischToolStripMenuItem.Text = "norsk";
            hilfeToolStripMenuItem.Text = "Hjelp";
            kontaktToolStripMenuItem.Text = "kontakt";
            hilfeToolStripMenuItem1.Text = "Hjelp";
            fAQToolStripMenuItem.Text = "FAQ";
            sidenoteToolStripMenuItem.Text = "Side note";
            anToolStripMenuItem.Text = "en";
            ausToolStripMenuItem.Text = "fra ";
        }
        #endregion

        #region Browser
        private void buttonupload_Click(object sender, EventArgs e)
        {
            //Dropbox ausgewählt
            if (comboBoxHoster.Text == "Dropbox")
            {
                webBrowser.Visible = true;
                webBrowser.Navigate("www.dropbox.com");
            }

            //Mediafire ausgewählt
            if (comboBoxHoster.Text == "Mediafire")
            {
                webBrowser.Visible = true;
                webBrowser.Navigate("www.mediafire.com");
            }

            //Filedropper ausgewählt
            if (comboBoxHoster.Text == "FileDropper")
            {
                webBrowser.Visible = true;
                webBrowser.Navigate("www.filedropper.com");
            }

            //minibox ausgewählt
            if (comboBoxHoster.Text == "Minibox")
            {
                webBrowser.Visible = true;
                webBrowser.Navigate("www.minibox.com");
            }

            //Fehlermeldung
            if (comboBoxHoster.Text == "" || comboBoxHoster.Text == "Mit Anmeldung:" || comboBoxHoster.Text == "Ohne Anmeldung")
            {
                MessageBox.Show("Bitte wähle eine Option aus die ,nicht leer ist, oder mit Anmeldung, oder ohne Anmeldung, ist aus");
            }
        }
        #endregion

        #region Button Archivieren
        private void buttonArchivieren_Click(object sender, EventArgs e)
        {
            //Deklarieren und Initialisieren
            string sZielpfad = textBoxziel.Text;
            string sQuellpfad = textBoxQuelle.Text;

            if (checkBoxArchivieren.Checked)
            {
                //Archivieren mit benutzung von Verweisen
                buttonArchivieren.Text = "Archivieren";
                ZipFile.CreateFromDirectory(sQuellpfad, sZielpfad + ".zip", CompressionLevel.Optimal, true);

                //Button deaktivieren
                buttonArchivieren.Enabled = false;
            }
        }
        #endregion

        #region Nachtmodus
        //Farbumkehrung für aktivieren
        private void anToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#424242");
            label4.ForeColor = Color.White;
            labelAnzahl.ForeColor = Color.White;
            labelanzahldateien.ForeColor = Color.White;
            labelinfo.ForeColor = Color.White;
            labeloptionen.ForeColor = Color.White;
            labelquelle.ForeColor = Color.White;
            labelverstrichen.ForeColor = Color.White;
            labelverstrichenezeit.ForeColor = Color.White;
            labelZiel.ForeColor = Color.White;
            checkBoxArchivieren.ForeColor = Color.White;
            checkBoxarchivierenohneup.ForeColor = Color.White;
            checkBoxHochladen.ForeColor = Color.White;
        }

        //Zurück zum standart
        private void ausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
            label4.ForeColor = Color.Black;
            labelAnzahl.ForeColor = Color.Black;
            labelanzahldateien.ForeColor = Color.Black;
            labelinfo.ForeColor = Color.Black;
            labeloptionen.ForeColor = Color.Black;
            labelquelle.ForeColor = Color.Black;
            labelverstrichen.ForeColor = Color.Black;
            labelverstrichenezeit.ForeColor = Color.Black;
            labelZiel.ForeColor = Color.Black;
            checkBoxArchivieren.ForeColor = Color.Black;
            checkBoxarchivierenohneup.ForeColor = Color.Black;
            checkBoxHochladen.ForeColor = Color.Black;
        }
        #endregion

        #region Kontakt
        //Kontakt formular in jeder sprache
        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deustchToolStripMenuItem.Checked)
            {
                MessageBox.Show("Bei Fragen oder Hilfe einfach folgende Klasse besuchen : GBS Grafschaft Bentheim BXT 2-1");
            }

            else if (NorwegischToolStripMenuItem.Checked)
            {
                MessageBox.Show("På bare følgende klasse spørsmål eller trenger hjelp besøk: GBS Bent BXT 2-1");
            }

            else
            {
                MessageBox.Show("For questions or help simply visit the following class: GBS Grafschaft Bentheim BXT 2-1");
            }
        }
        #endregion

        #region Faq
        //FAQ in jeder Sprache
        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deustchToolStripMenuItem.Checked)
            {
                MessageBox.Show("1.Wie Kriege ich Kontakt zu den Programmierern?\n Über den Hilfe-Reiter und dann Kontakt.\n\n2.Wie funktioniert das Programm/" +
                "wie sieht der Code aus? \nhttps://github.com/Chookees/Project-USB-Backup\n\n3.Artur kannst du mir eben helfen?\n-Jannik, Luca, Dennis, Lukas", "FAQ");
            }

            else if (NorwegischToolStripMenuItem.Checked)
            {
                MessageBox.Show("1. Hvordan får jeg kontakt med programmerere? \n Om fanen Hjelp og deretter kontakte. \n \n2.Wie gjør programmet / " +
                "Hva om de etiske \npå ber om det kan lastes opp og vises \n \n3.Artur du kan hjelpe meg bare \n Jannik, Luca, Dennis, Luke?.?", "Hjelp");
            }

            else
            {
                MessageBox.Show("1. How do i get contact to the Programmers?\nFrom the Help tab and then contact.\n\n2.Can i see the Code?\nhttps://github.com/Chookees/Project-USB-Backup\n\nArtur can you help me?\n -Jannik, Luca, Dennis, Lukas", "FAQ");
            }

        }
        #endregion
    }
}