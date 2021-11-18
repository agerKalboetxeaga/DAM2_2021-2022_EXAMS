using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2
{
    class Operazioa
    {
        float zenbaki1;
        float zenbaki2;
        float zenbaki3;
        float zenbaki4;
        public float Zenbaki1
        {
            get { return zenbaki1; }
            set { zenbaki1 = value; }
        }
        public float Zenbaki2
        {
            get { return zenbaki2; }
            set { zenbaki2 = value; }
        }
        public float Zenbaki3
        {
            get { return zenbaki3; }
            set { zenbaki3 = value; }
        }
        public float Zenbaki4
        {
            get { return zenbaki4; }
            set { zenbaki4 = value; }
        }
        public float Kalkulatu()
        {
            return (zenbaki1 + 2 * zenbaki2 + 3 * zenbaki3 + 4 * zenbaki4) / 4;
        }
    }
}
