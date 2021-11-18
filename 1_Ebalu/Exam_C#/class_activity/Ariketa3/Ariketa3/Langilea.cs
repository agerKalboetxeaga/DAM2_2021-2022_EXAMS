using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa3
{
    class Langilea : Kontaktua
    {
        float soldata;
        string segurtasunSoziala;

        public Langilea(string nan, string segurtasunSoziala) : base(nan)
        {
            this.segurtasunSoziala = segurtasunSoziala;
        }

        public Langilea(string nan, string izena, string abizena, string segurtasunSoziala) : base(nan, izena, abizena)
        {
            this.segurtasunSoziala = segurtasunSoziala;
        }

        public override string Emaila
        {
            get { return base.Emaila; }
            set
            {
                if (value.Substring(value.Length - 8, 8) == "@uni.eus")
                { base.Emaila = value; }
                else
                {
                    Exception ex = new Exception("Emailaren domeinua @uni.eus izan behar da");
                    throw ex;
                }

            }
        }
        public float Soldata
        {
            get { return soldata; }
            set { soldata = value; }
        }
        public string SegurtasunSoziala
        {
            get { return SegurtasunSoziala; }
            set { segurtasunSoziala = value; }
        }

        public override string Gorde()
        {
            return "Langilea ondo gorde da";
        }
    }
}
