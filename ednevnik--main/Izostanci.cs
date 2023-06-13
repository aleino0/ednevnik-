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
    public partial class Izostanci : Form
    {
        public Izostanci()
        {
            InitializeComponent();
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

        private void raspored_Click(object sender, EventArgs e)
        {
            Raspored frm = new Raspored();
            DialogResult rez = frm.ShowDialog();
        }
    }
}
