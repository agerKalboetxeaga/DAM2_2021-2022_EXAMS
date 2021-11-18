using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalmentaDLL
{
    public partial class Grafikoa : UserControl
    {
        SalmentaDBDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter = new SalmentaDBDataSetTableAdapters.DataTable1TableAdapter();
        SalmentaDBDataSet salmentaDBDataSet = new SalmentaDBDataSet();
        public Grafikoa()
        {
            InitializeComponent();
            dataTable1TableAdapter.Fill(this.salmentaDBDataSet.DataTable1);

            /*DataTable bertan metodo berria eginda
            /*chart1.DataSource = dataTable1TableAdapter.GetDataBy().Select();*/

            /*Eskuz egiten*/
            chart1.DataSource = salmentaDBDataSet.DataTable1
                .GroupBy(d => d.Izena)
                .Select(g => new { Izena = g.Key, Gehitu = g.Sum(d => d.Zenbatekoa)});
            /**/

            chart1.Series[0].YValueMembers = "Gehitu";
            chart1.Series[0].XValueMember = "Izena";
            chart1.DataBind();

        }
    }
}
