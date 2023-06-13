using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ednevnik_
{
    public partial class predmet : Form
    {
        public predmet()
        {
            InitializeComponent();
            fPredmet_ime.Text = Form1.currPredmet;


            if (!Directory.Exists("C:\\eDnevnik-\\ocjene"))
            {
                Directory.CreateDirectory("C:\\eDnevnik-\\ocjene");
            }

            if (!File.Exists("C:\\eDnevnik-\\ocjene\\" + Form1.currUcenik + "\\" + Form1.currPredmet))
            {
                File.Create("C:\\eDnevnik-\\ocjene\\" + Form1.currUcenik + "\\" + Form1.currPredmet);
            }
        }

        private void predmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            fPredmet_ime.Text = predmeti.SelectedItem.ToString();

            if (!File.Exists("C:\\eDnevnik-\\ocjene\\" + Form1.currUcenik + "\\" + predmeti.SelectedItem + ".csv"))
            {
                File.Create("C:\\eDnevnik-\\ocjene\\" + Form1.currUcenik + "\\" + predmeti.SelectedItem + ".csv");
            }
        }
    }
}
