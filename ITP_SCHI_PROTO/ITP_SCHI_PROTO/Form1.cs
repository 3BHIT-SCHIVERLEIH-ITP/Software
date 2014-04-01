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
    public partial class Form1 : Form
    {
        private string myConnectionString = "SERVER=localhost;" +
                            "DATABASE=itp_proto;" +
                            "UID=root;" +
                            "PASSWORD=toor;";
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_SK_anz_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT count(*), marke FROM artikel Where istSKI is true group by marke";
            MySqlDataReader Reader;
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string row = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    if (i == Reader.FieldCount - 1)
                    {
                        row += Reader.GetValue(i).ToString();
                    }
                    else
                    {
                        row += Reader.GetValue(i).ToString() + ", ";
                    }
                //Console.WriteLine(row);
                tbox_LOG_bottom.Text = tbox_LOG_bottom.Text + row+ "\r\n";
            }
            connection.Close();
        }


    }
}
