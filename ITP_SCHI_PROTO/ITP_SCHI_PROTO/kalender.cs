using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPPROTO
{
    public partial class kalender : Form
    {
        public kalender()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
        public Form1 TheParent { get; set; }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            TheParent.datum = monthCalendar1.SelectionStart;
        }
    }
}
