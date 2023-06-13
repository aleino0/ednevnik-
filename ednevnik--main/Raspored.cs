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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ednevnik_
{
    public partial class Raspored : Form
    {
        public Raspored()
        {
            InitializeComponent();

            if (!Directory.Exists("C:\\eDnevnik-\\eRasporedi"))
            {
                Directory.CreateDirectory("C:\\eDnevnik-\\eRasporedi");
            }

        }

        private void ocjene_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
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

        private void novi_raspored_Click(object sender, EventArgs e)
        {
            if (ime_rasporeda == null)
            {
                MessageBox.Show("treba upisati ime rasporeda", "pogrešan upis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string ime = ime_rasporeda.Text;
                File.Create("C:\\eDnevnik-\\eRasporedi\\" + ime + ".csv");
                Process.Start("C:\\eDnevnik-\\eRasporedi\\" + ime + ".csv");
                razredi.Items.Add(ime);
            }
        }

        private void razredi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    raspored_disp.AppendText(@"C:\eDnevnik-\eRasporedi\" + razredi.SelectedItem.ToString() + ".csv");
                    
                    myStream.Close();
                }
            }






            //raspored_disp.AppendText(@"C:\eDnevnik-\eRasporedi\" + razredi.SelectedItem.ToString() + ".csv");


            /*String[] bla = File.ReadAllText(@"C:\eDnevnik-\eRasporedi\" + razredi.SelectedItem + ".csv").Split('|');


            for (int i = 0; i < bla.Length; i++)
            {
                raspored_disp.AppendText(bla[i] + Environment.NewLine);
            }*/

            //raspored_disp.LoadFile(@"C:\eDnevnik-\eRasporedi\" + razredi.SelectedItem + ".csv");
        }

    }
}
/* 
            String fileRaspored = @"C:\Users\linar\Documents\Raspored.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
*/