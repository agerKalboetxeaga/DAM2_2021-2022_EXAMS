using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    class Bezeroa : Kontaktua
    {
        string kategoria;

        public Bezeroa(string nan, string kategoria) : base(nan)
        {
            this.kategoria = kategoria;
        }
        public Bezeroa(string nan, string izena, string abizena, string kategoria) : base(nan, izena, abizena)
        {
            this.kategoria = kategoria;
        }

        public string Kategoria
        {
            get { return kategoria; }
            set { kategoria = value; }
        }
        public override string Gorde()
        {
            return "Bezeroa ondo gorde da";
        }
    }

}
