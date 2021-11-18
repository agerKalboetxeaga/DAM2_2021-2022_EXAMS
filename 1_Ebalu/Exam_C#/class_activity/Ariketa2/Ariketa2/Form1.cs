using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ariketa2
{
    public partial class Form1 : Form
    {
        Operazioa operazioa = new Operazioa();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtZenbaki1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TestuaKonprobatu(txtZenbaki1, e);
        }
        private void TxtZenbaki2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TestuaKonprobatu(txtZenbaki2, e);
        }
        private void TxtZenbaki3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TestuaKonprobatu(txtZenbaki3, e);
        }
        private void TxtZenbaki4_KeyPress(object sender, KeyPressEventArgs e)
        {
            TestuaKonprobatu(txtZenbaki4, e);
        }
        private void TestuaKonprobatu(TextBox txt, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)   		 // ez bada zenbakia
             && e.KeyChar != Convert.ToChar(Keys.Back)   // ez bada atzera 		
             && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
             && e.KeyChar != Convert.ToChar(",")     // ez bada koma
             || e.KeyChar == Convert.ToChar("."))
            {
                e.Handled = true;		 // ebentoa kontrolatu
                return;			 // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(","))
                {

                    if (txt.Text.IndexOf(",") >= 0)
                    {
                        e.Handled = true;
                        return;
                    }
                    else
                    {
                        if (txt.Text.Length == 0)
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }

        private void BtnEgin_Click(object sender, EventArgs e)
        {
            
            if (Balidazioa())
            {
                txtEmaitza.Text = operazioa.Kalkulatu().ToString();
                txtEmaitza.Enabled = true;
            }
        }
        private bool Balidazioa()
        {
            try
            { 
                operazioa.Zenbaki1 = float.Parse(txtZenbaki1.Text);
                operazioa.Zenbaki2 = float.Parse(txtZenbaki2.Text);
                operazioa.Zenbaki3 = float.Parse(txtZenbaki3.Text);
                operazioa.Zenbaki4 = float.Parse(txtZenbaki4.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zenbakiak sartu behar dira");
                return false;
            }
        }

        private void BtnGarbitu_Click(object sender, EventArgs e)
        {
            txtZenbaki1.Text = "";
            txtZenbaki2.Text = "";
            txtZenbaki3.Text = "";
            txtZenbaki4.Text = "";
            txtEmaitza.Text = "";
            txtEmaitza.Enabled = false;
            txtZenbaki1.Focus();
        }
    }
}
