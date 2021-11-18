using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AginteKoadroa
{
    public partial class Form1 : Form
    {
        SalmentaDBDataSet salmentaDBDataSet = new SalmentaDBDataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SalmentaDBDataSetTableAdapters.BezeroaTableAdapter bezeroaTableAdapter = new SalmentaDBDataSetTableAdapters.BezeroaTableAdapter();

            bezeroaTableAdapter.Fill(this.salmentaDBDataSet.Bezeroa);

            chart1.DataSource = this.salmentaDBDataSet.Bezeroa
                .GroupBy(b => b.NanSaltzailea)
                .ToDictionary(g => g.Key, g => g.Count());

            chart1.Series[0].YValueMembers = "Value";
            chart1.Series[0].XValueMember = "Key";
            chart1.DataBind();

            SalmentaDBDataSetTableAdapters.SalmentaTableAdapter salmentaTableAdapter = new SalmentaDBDataSetTableAdapters.SalmentaTableAdapter();

            salmentaTableAdapter.Fill(this.salmentaDBDataSet.Salmenta);

            chart2.DataSource = this.salmentaDBDataSet.Salmenta
                .GroupBy(b => b.NanBezeroa)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.Zenbatekoa));

            chart2.Series[0].YValueMembers = "Value";
            chart2.Series[0].XValueMember = "Key";
            chart2.DataBind();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
