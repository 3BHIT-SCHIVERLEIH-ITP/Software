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
    public partial class ResultSelect : Form
    {

        private int current_id = 0;

        MySqlConnection connection = new MySqlConnection("SERVER=localhost;" +
                           "DATABASE=itp_proto;" +
                           "UID=itp;" +
                           "PASSWORD=rent;");

        public ResultSelect()
        {
            InitializeComponent();
            loadUP();
        }
        public ResultSelect(string sc)
        {
            InitializeComponent();
            loadUP();
            connection = new MySqlConnection(sc);
        }
        private void loadUP()
        {
            Object[][] gg;
            
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader r;
            command.CommandText = "select distinct(kunde.id) from abrechnung inner join kunde on kid = kunde.id;";
            connection.Open();
            r = command.ExecuteReader();
            int j = r.RecordsAffected;
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
                checkedListBox_kunde.Items.Add(row, false);
            }
            r.Close();
        }
        private void checkedListBox_kunde_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_id = checkedListBox_kunde.SelectedIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //neue FORM anzeigen
            
        }
    }
}
