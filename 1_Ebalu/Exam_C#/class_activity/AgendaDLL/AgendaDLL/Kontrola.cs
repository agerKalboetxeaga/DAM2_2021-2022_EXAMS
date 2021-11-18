using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDLL
{
    public partial class Kontrola : UserControl
    {
        public Kontrola()
        {
            InitializeComponent();
            this.kontaktuaTableAdapter.Fill(this.agendaDataSet.Kontaktua);

        }
    }
}
