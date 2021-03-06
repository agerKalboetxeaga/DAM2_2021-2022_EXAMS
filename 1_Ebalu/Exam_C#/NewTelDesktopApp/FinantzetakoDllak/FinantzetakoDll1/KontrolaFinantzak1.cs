using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinantzetakoDll1
{
    public partial class KontrolaFinantzak1 : UserControl
    {
        NewTelDataSet kontrolDataSet = new NewTelDataSet();
        public KontrolaFinantzak1()
        {
            InitializeComponent();
            NewTelDataSetTableAdapters.purchase_orderTableAdapter salmentaTableAdapter = new NewTelDataSetTableAdapters.purchase_orderTableAdapter();

            salmentaTableAdapter.Fill(this.kontrolDataSet.purchase_order);
            chart4.DataSource = kontrolDataSet.purchase_order
                .GroupBy(p => p.create_date.ToShortDateString())
                .Select(i => new { create_date = i.Key, guztira = i.Sum(p => p.amount_total) });

            chart4.Series[0].YValueMembers = "guztira";
            chart4.Series[0].XValueMember = "create_date";
            chart4.DataBind();
        }
    }
}

