using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ITPPROTO
{
    public partial class KundenBearbeitung : Form
    {
        private int aktualuser=0;
        public KundenBearbeitung()
        {
            InitializeComponent();
            loadUP();
        }
        private void loadUP()
        {
            MySqlDataReader r = (MySqlDataReader)mslq("select vorname, nachname, adresse from kunde;");
            String[] w = new String[r.FieldCount]
        }
        private Object mslq(String s)
        {
            MySqlConnection connection = new MySqlConnection("SERVER=localhost;" +
                            "DATABASE=itp_proto;" +
                            "UID=itp;" +
                            "PASSWORD=rent;");
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = s;
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            s = Reader.GetValue(0).ToString();
            connection.Close();
            return Reader;
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
