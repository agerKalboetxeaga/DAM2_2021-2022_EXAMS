using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ariketa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (Balidatu())
            {
                RadioButton rad = new RadioButton();
                rad.Text = this.Controls.OfType<GroupBox>()
                                      .FirstOrDefault().Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text;

                try 
                {
                    switch (rad.Text)
                    {
                        case "Kontaktua":
                            Kontaktua kontaktua = new Kontaktua(txtNan.Text, txtIzena.Text, txtAbizena.Text);
                            kontaktua.Emaila = txtEmail.Text;
                            MessageBox.Show(kontaktua.Gorde());
                            break;
                        case "Bezeroa":
                            Bezeroa bezeroa = new Bezeroa(txtNan.Text, txtIzena.Text, txtAbizena.Text, cmbKategoria.Text);
                            bezeroa.Emaila = txtEmail.Text;
                            MessageBox.Show(bezeroa.Gorde());
                            break;
                        case "Langilea":
                            if (LangileaBalidatu())
                            { 
                                Langilea langilea = new Langilea(txtNan.Text, txtIzena.Text, txtAbizena.Text, txtSegurtasunSoziala.Text);
                                langilea.Emaila = txtEmail.Text;
                                langilea.Soldata = float.Parse(txtSoldata.Text);
                                MessageBox.Show(langilea.Gorde());
                            }
                            else
                            {
                                MessageBox.Show("Langilearen datuak falta dira. Saiatu berriro");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ezin da alta egin. Saiatu beranduago: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Sarrerako daturen bat txarto dago. Saiatu berriro");
            }
        }
        private bool Balidatu()
        {
            bool erantzuna = true;
            if (txtNan.Text == "" || txtIzena.Text == "" || txtAbizena.Text == "")
            {
                erantzuna = false;
            }
            else
            {
                if (txtIzena.Text.Any(char.IsDigit) || txtAbizena.Text.Any(char.IsDigit))
                    erantzuna = false;
                else
                {
                    erantzuna = NanBalidatu();
                }
            }

            return erantzuna;
        }
        private bool NanBalidatu()
        {
            string nifRegEx = "^[0-9]{8}[A-Z]$";
            bool erantzuna = false;

            if (Regex.IsMatch(txtNan.Text, nifRegEx))
            {
                string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                var mod = int.Parse(txtNan.Text.Substring(0, 8)) % 23;
                if (control[mod] == txtNan.Text.Substring(8, 1))
                {
                    erantzuna = true;
                }
            }
            return erantzuna;
        }

        private void radGuztiak_CheckedChanged(object sender, EventArgs e)
        {
            if (Balidatu())
            {
                RadioButton rad = (RadioButton)sender;
                if (rad.Checked)
                {
                    switch (rad.Text)
                    {
                        case "Kontaktua":
                                panel1.Enabled = false;
                                panel2.Enabled = false;
                                break;
                        case "Bezeroa":
                                panel1.Enabled = true;
                                panel2.Enabled = false;
                                break;
                        case "Langilea":
                                panel1.Enabled = false;
                                panel2.Enabled = true;
                            break;
                    }
                }
            }

        }
        private bool LangileaBalidatu()
        {
            bool erantzuna = true;
            try
            {
                float.Parse(txtSoldata.Text);
            }
            catch (Exception ex)
            {
                erantzuna = false;
            }
            string ssRegEx = "^[0-9]{20}$";
            if (!Regex.IsMatch(txtSegurtasunSoziala.Text, ssRegEx))
            {
                erantzuna = false;
            }
            return erantzuna;
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
