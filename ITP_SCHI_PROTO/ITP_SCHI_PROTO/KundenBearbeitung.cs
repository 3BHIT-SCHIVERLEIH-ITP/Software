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
    public partial class KundenBearbeitung : Form
    {
        private int aktualuser=0;
        public KundenBearbeitung()
        {
            InitializeComponent();
        }

        private void checkedListBox_Kundenview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = checkedListBox_Kundenview.SelectedIndex;
            aktualuser = i;            
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            TheParent.kunden_id = aktualuser;
            this.Visible = false;
            this.Dispose();

        }

        public Form1 TheParent { get; set; }
    }
}
