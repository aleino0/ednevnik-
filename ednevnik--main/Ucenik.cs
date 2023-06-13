using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ednevnik_
{
    internal class Ucenik
    {
        string ime;
        string prezime;
        string spol;
        string godine;
        string razred;
        string mail;
        

        public Ucenik(string ime, string prezime, string spol, string godine, string razred, string mail)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.spol = spol;
            this.godine = godine;
            this.razred = razred;
            this.mail = mail;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Spol { get => spol; set => spol = value; }
        public string Godine { get => godine; set => godine = value; }
        public string Razred { get => razred; set => razred = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
