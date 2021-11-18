using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2
{
    class Operazioa
    {
        string label;
        float zenbaki;

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        public float Zenbaki
        {
            get { return zenbaki; }
            set { zenbaki = value; }
        }

        public static float Kalkulatu(List<Operazioa> operazioak)
        {
            return (operazioak[0].Zenbaki + operazioak[1].Zenbaki*2 + operazioak[2].Zenbaki*3 + operazioak[3].Zenbaki*4)/4;
        }
    }
}
