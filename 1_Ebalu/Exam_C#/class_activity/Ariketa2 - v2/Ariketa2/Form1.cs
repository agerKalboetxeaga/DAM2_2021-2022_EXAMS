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
        List<Operazioa> operazioak = new List<Operazioa>();
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
            Operazioa operazioa = new Operazioa();
            operazioa.Label = label1.Text;
            operazioa.Zenbaki = float.Parse(txtZenbaki1.Text);
            operazioak.Add(operazioa);
            txtZenbaki1.Text = "";
            txtZenbaki1.Focus();

            switch (label1.Text.Last().ToString())
            {
                case "1":
                case "2":
                case "3":
                    int c = int.Parse(label1.Text.Last().ToString());
                    c++;
                    label1.Text = "Zenbaki "+ c.ToString();
                    break;
                case "4":
                    label1.Text = "Emaitza";
                    btnEgin.Enabled = false;
                    txtZenbaki1.Text = Operazioa.Kalkulatu(operazioak).ToString();
                    break;
            }
        }
        private void BtnGarbitu_Click(object sender, EventArgs e)
        {
            txtZenbaki1.Text = "";
            txtZenbaki1.Focus();
        }
    }
}
