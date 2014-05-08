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
    public partial class CreateUser : Form
    {
        private string myConnectionString = "SERVER=localhost;" + "DATABASE=itp_proto;" + "UID=itp;" + "PASSWORD=rent;";
        public CreateUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public Form1 TheParent { get; set; }
        public KundenBearbeitung TheBrother { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
