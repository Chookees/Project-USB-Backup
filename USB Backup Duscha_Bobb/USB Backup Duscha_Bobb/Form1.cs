using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace USB_Backup_Duscha_Bobb
{
    public partial class Form1 : Form
    {
        #region FormInitialisierung
        public Form1()
        {
            InitializeComponent();
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

        }
        #endregion

        #region ButtonStart
        private void buttonstart_Click(object sender, EventArgs e)
        {
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

                #region Zeit starten
                //Zeit des Backups starten
                SZeit.Start();
                #endregion

                if (checkBoxaktuell.Checked)
                {
                    bRekursiv = true;
                    if (File.Exists(sZielpfad))
                    {
                        File.Replace(sQuellpfad, sZielpfad, sQuellpfad);
                    }
                }

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
            }

            #region Fehlermeldung
            //Wenn Fehler dann Fehlermeldung
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler!");
            }
            #endregion
        }
        #endregion

        #region Unterordner Kopieren == AN sonst alles
        private void RekursivOrdnerKopieren(string sQuelle, string sZiel, bool bUeberschreiben, bool bRekursiv)
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
        #endregion

        #region Macher ToolstripItem
        private void macherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by: Marvin Duscha\nCoded by: Artur Bobb\nTranslated by: Marvin Duscha und Artur Bobb", "Masterminds", MessageBoxButtons.OK);
        }
        #endregion

        #region Sidenote Toolstripitem
        private void sidenoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dieses Projekt ist nur gelungen durch eine enge Zusammenarbeit mit Codefieber.de / msdn.microsoft.com / dotnet-snippets.de uvm.",
                "Dankeschön", MessageBoxButtons.OK);
        }


        #endregion

        #region Übersetzungen

        //Englisch übersetzungen
        private void englischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelquelle.Text = "Source Directory:";
            labelZiel.Text = "Target Directory:";
            labeloptionen.Text = "Options:";
            checkBoxarchivierenohneup.Text = "Archive backup";
            checkBoxHochladen.Text = "Upload backup";
            buttonstart.Text = "Start backup";
            labelinfo.Text = "Informations";
            buttonupload.Text = "Upload";
            labelanzahldateien.Text = "Number of copied files";
            labelverstrichenezeit.Text = "Duration of backup";
            checkBoxArchivieren.Text = "Archive backup for upload and delete folders";
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
            labelquelle.Text = "Quellverzeichnis:";
            labelZiel.Text = "Zielverzeichnis:";
            labeloptionen.Text = "Optionen:";
            checkBoxarchivierenohneup.Text = "Backup archivieren";
            checkBoxHochladen.Text = "Backup hochladen";
            buttonstart.Text = "Backup beginnen";
            labelinfo.Text = "Informationen";
            buttonupload.Text = "Upload beginnen";
            labelanzahldateien.Text = "Anzahl kopierter Dateien:";
            labelverstrichenezeit.Text = "Dauer des Backups:";
            checkBoxArchivieren.Text = "Backup Archivieren für Upload und  Ordner Löschen";
            buttonArchivieren.Text = "Archivieren";
            labelAnzahl.Text = "Noch Keine";
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
            labelquelle.Text = "kildekatalogen:";
            labelZiel.Text = "målkatalogen:";
            labeloptionen.Text = "opsjoner:";
            checkBoxarchivierenohneup.Text = "arkiv sikkerhetskopier";
            checkBoxHochladen.Text = "Last opp sikkerhetskopier";
            buttonstart.Text = "Opprett sikkerhetskopier";
            labelinfo.Text = "informasjon";
            buttonupload.Text = "begynne sikkerhetskopier";
            labelanzahldateien.Text = "Antall kopierte filer:";
            labelverstrichenezeit.Text = "Varighet av sikkerhetskopier:";
            checkBoxArchivieren.Text = "arkiv sikkerhetskopier for laste opp og fil sletting";
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
                MessageBox.Show("Bitte Wähle eine Option aus die ,nicht leer ist, oder Mit Anmeldung, oder Ohne Anmeldung, ist aus");
            }
        }
        #endregion

        #region Button Archivieren
        private void buttonArchivieren_Click(object sender, EventArgs e)
        {
            string sZielpfad = textBoxziel.Text;
            string sQuellpfad = textBoxQuelle.Text;

            if (checkBoxArchivieren.Checked)
            {
                //Archivieren mit benutzung von Verweisen
                buttonArchivieren.Text = "Archivieren und Löschen";
                ZipFile.CreateFromDirectory(sQuellpfad, sZielpfad + ".zip", CompressionLevel.Optimal, true);
            }
        }
        #endregion

        #region Nachtmodus
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
        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bei Fragen oder Hilfe einfach folgende Klasse besuchen : GBS Grafschaft Bentheim BXT 2-1");
        }
        #endregion

        #region Faq
        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Wie Kriege ich Kontakt zu den Herstellern?\n Über den Hilfe-Reiter und dann Kontakt.\n\n2.Wie funktioniert das Programm/" +
                "wie sieht der Code aus? \nAuf Anfrage kann dieser hochgeladen werden und angesehen werden.\n\n3.Artur kannst du mir eben helfen?\n-Jannik, Luca, Dennis, Lukas", "FAQ");
        }
        #endregion
    }
}
