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
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }

        private void Botoiak(object sender, EventArgs e)
        {
            try {
            kalkulagailua.Zenbaki1 = float.Parse(textBox1.Text);
            kalkulagailua.Zenbaki2 = float.Parse(textBox2.Text);
                switch ((sender as Button).Text)
                {
                    case "+":
                        MessageBox.Show(kalkulagailua.Gehiketa().ToString());
                        break;
                    case "-":
                        MessageBox.Show(kalkulagailua.Kenketa().ToString());
                        break;
                    case "*":
                        MessageBox.Show(kalkulagailua.Biderketa().ToString());
                        break;
                    case "/":
                        MessageBox.Show(kalkulagailua.Zatiketa().ToString());
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Zenbakiak sartu behar dituzu!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)         // ez bada zenbakia
    && e.KeyChar != Convert.ToChar(Keys.Back)   // ez bada atzera 		
    && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
     && e.KeyChar != Convert.ToChar(","))       // ez bada koma
            {
                e.Handled = true;                // ebentoa kontrolatu
                return;                         // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(","))  // koma bada
                {
                    if (textBox1.Text.IndexOf(",") >= 0)  // jada badago koma bat
                    {
                        e.Handled = true;		//ebentoa kontrolatu
                        return;					//bueltatu
                    }
                    else
                    {
                        if (textBox1.Text.Length == 0)  // lehenengo  koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }

        }
    }
}
