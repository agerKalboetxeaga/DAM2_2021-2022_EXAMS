using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    class Kontaktua
    {
        string nan;
        string izena;
        string abizena;
        string emaila;

        public Kontaktua(string nan)
        {
            this.nan = nan;
        }
        public Kontaktua(string nan, string izena, string abizena)
        {
            this.nan = nan;
            this.izena = izena;
            this.abizena = abizena;
        }
        public string Nan
        {
            get { return nan; }
            set { nan = value; }
        }
        public string Izena
        {
            get { return izena; }
            set { izena = value; }
        }
        public string Abizena
        {
            get { return abizena; }
            set { abizena = value; }
        }
        public virtual string Emaila
        {
            get { return emaila; }
            set { emaila = value; }
        }

        public string IzenOsoa
        {
            get { return izena + " " + abizena; }
        }

        public virtual string Gorde()
        {
            return "Kontaktua ondo gorde da";
        }
    }
}
