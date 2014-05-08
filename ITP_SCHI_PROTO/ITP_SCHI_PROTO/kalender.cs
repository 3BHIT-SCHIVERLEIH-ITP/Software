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
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                TheMother.TheParent.datum = monthCalendar1.SelectionStart;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(""+ex.ToString());
                this.Text = "tt";
            }
                this.Dispose(true);
        }
        public Form1 TheParent { get; set; }
        public KundenBearbeitung TheMother { get; set; }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //TheParent.datum = monthCalendar1.SelectionStart;
        }
    }
}
