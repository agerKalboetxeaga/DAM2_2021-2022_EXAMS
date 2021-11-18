using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulagailua
{
    class Kalkulagailua
    {
        float zenbaki1;
        float zenbaki2;
        public float Zenbaki1
        {
            get
            {
                return zenbaki1;
            }
            set
            {
                zenbaki1 = value;
            }
        }
        public float Zenbaki2
        {
            get
            {
                return zenbaki2;
            }
            set
            {
                zenbaki2 = value;
            }
        }
        public float Gehiketa()
        {
            return zenbaki1 + zenbaki2;
        }
        public float Kenketa()
        {
            return zenbaki1 - zenbaki2;
        }
        public float Biderketa()
        {
            return zenbaki1 * zenbaki2;
        }
        public float Zatiketa()
        {
            return zenbaki1 / zenbaki2;
        }
    }
}
