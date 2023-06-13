using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ednevnik_
{
    public partial class Ispiti : Form
    {
        public Ispiti()
        {
            InitializeComponent();
        }


        private void ocjene_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
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

    }
}

