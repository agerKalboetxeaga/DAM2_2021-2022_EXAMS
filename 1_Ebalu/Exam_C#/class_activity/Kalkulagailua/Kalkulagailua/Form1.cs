using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGehi_Click(object sender, EventArgs e)
        {
            Kalkulagailua kalkulagailua = new Kalkulagailua();
            kalkulagailua.Zenbaki1 = float.Parse(textBox1.Text);
            kalkulagailua.Zenbaki2 = float.Parse(textBox2.Text);

            MessageBox.Show((kalkulagailua.Gehiketa()).ToString());
        }

        private void btnKen_Click(object sender, EventArgs e)
        {
            Kalkulagailua kalkulagailua = new Kalkulagailua();
            kalkulagailua.Zenbaki1 = float.Parse(textBox1.Text);
            kalkulagailua.Zenbaki2 = float.Parse(textBox2.Text);

            MessageBox.Show((kalkulagailua.Kenketa()).ToString());
        }

        private void btnBider_Click(object sender, EventArgs e)
        {
            Kalkulagailua kalkulagailua = new Kalkulagailua();
            kalkulagailua.Zenbaki1 = float.Parse(textBox1.Text);
            kalkulagailua.Zenbaki2 = float.Parse(textBox2.Text);

            MessageBox.Show((kalkulagailua.Biderketa()).ToString());
        }

        private void btnZati_Click(object sender, EventArgs e)
        {
            Kalkulagailua kalkulagailua = new Kalkulagailua();
            kalkulagailua.Zenbaki1 = float.Parse(textBox1.Text);
            kalkulagailua.Zenbaki2 = float.Parse(textBox2.Text);

            MessageBox.Show((kalkulagailua.Zatiketa()).ToString());
        }
    }
}
