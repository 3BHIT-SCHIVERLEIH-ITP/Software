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
        bool finish;
        public KundenBearbeitung()
        {
            InitializeComponent();
            loadUP();
        }

        private void loadUP()
        {
            MySqlConnection connection = new MySqlConnection("SERVER=localhost;" +
                           "DATABASE=itp_proto;" +
                           "UID=itp;" +
                           "PASSWORD=rent;");
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader r;
            command.CommandText = "select vorname, nachname, adresse from kunde;";
            connection.Open();
            r = command.ExecuteReader();
            while (r.Read())
            {
                string row = "";
                for (int i = 0; i < r.FieldCount; i++)
                    if (i == r.FieldCount - 1)
                    {
                        row += r.GetValue(i).ToString();
                    }
                    else
                    {
                        row += r.GetValue(i).ToString() + ", ";
                    }
                //Console.WriteLine(row);
                checkedListBox_Kundenview.Items.Add(row, false);
            }
            r.Close();
        }
        private void PasswordDialog_Load(object sender, EventArgs e) {
  
  	    }
        private void cmdOK_Click(object sender, EventArgs e) {
  	        //Eingabe übernehmen
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
            this.finish = true;
            this.Dispose();
        }

        public Form1 TheParent { get; set; }
    }
}
