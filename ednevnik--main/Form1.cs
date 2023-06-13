using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace ednevnik_
{
    public partial class Form1 : Form
    {
        public static string currPredmet;
        public static string currUcenik;

        public Form1()
        {
            InitializeComponent();


            if (!Directory.Exists("C:\\eDnevnik-"))
            {
                Directory.CreateDirectory("C:\\eDnevnik-");
            }

            if (!Directory.Exists("C:\\eDnevnik-\\ocjene"))
            {
                Directory.CreateDirectory("C:\\eDnevnik-\\ocjene");
            }
        }


        private void predmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            currPredmet = predmeti.SelectedItem.ToString();

            predmet frm = new predmet();
            DialogResult rez = frm.ShowDialog();
        }

        private void ispiti_Click(object sender, EventArgs e)
        {
            Ispiti frm = new Ispiti();
            DialogResult rez = frm.ShowDialog();
        }

        private void izostanci_Click(object sender, EventArgs e)
        {
            Izostanci frm = new Izostanci();
            DialogResult rez = frm.ShowDialog();
        }

        private void raspored_Click(object sender, EventArgs e)
        { 
            Raspored frm = new Raspored();
            DialogResult rez = frm.ShowDialog();
        }


        private void dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Ucenik ucenik = new Ucenik(ucIme.Text, ucPrezime.Text, ucSpol.Text, ucGod.Text, ucRazred.Text, ucMail.Text);
                ucenici.Items.Add(ucIme.Text + " " + ucPrezime.Text);

                string ime = Convert.ToString(ucIme.Text);
                string prezime = Convert.ToString(ucPrezime.Text);
                string file = ime + " " + prezime;

                Directory.CreateDirectory(@"C:\eDnevnik-\ocjene\" + file);
                string oUceniku = @"C:\\eDnevnik-\\ocjene\\\" + file + "\\o uceniku.csv";

                if (System.IO.File.Exists(oUceniku))
                {
                    string FileHeader = ("First Name" + "," + "Last Name" + System.Environment.NewLine);
                    System.IO.File.WriteAllText(oUceniku, FileHeader);
                }
                Random rnd = new Random();
                int id = rnd.Next(00000001, 99999999);


                string FileDeail = "Ime: " + ucIme.Text + ";\nPrezime: " + ucPrezime.Text + ";\nSpol: " + ucSpol.Text
                    + ";\nGodine: " + ucGod.Text + ";\nRazred:" + ucRazred.Text + ";\ne-mail: " + ucMail.Text
                    + ";\nid: " + id;
                System.IO.File.AppendAllText(oUceniku, FileDeail);
                ucIme.Text = " ";
                ucPrezime.Text = " ";

                ucIme.Clear();
                ucPrezime.Clear();
                ucSpol.Clear();
                ucGod.Clear();
                ucRazred.Clear();
                ucMail.Clear();
            }
            catch (Exception greska)
            { MessageBox.Show(greska.Message, "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
        }

        private void ucenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            currUcenik = ucenici.SelectedItem.ToString();
        }
    }
}
