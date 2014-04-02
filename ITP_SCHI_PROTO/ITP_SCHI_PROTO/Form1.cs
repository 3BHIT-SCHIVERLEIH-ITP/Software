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
            loadUP();
        }
        private void loadUP()
        {   
            //ski anzahl button text
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "SELECT count(id) FROM artikel Where istSKI is true";
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            button_SK_anz.Text = Reader.GetValue(0).ToString();
            connection.Close();
            //ausgeborgt
            command.CommandText = "SELECT count(*) FROM abrechnung join artikel on aid = artikel.id Where artikel.istSKI = true AND ausgeborgtbis > current_date() AND zurueckgegeben = false;";
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            button_SK_rent.Text = Reader.GetValue(0).ToString();
            connection.Close();
            //overrent
            command.CommandText = "SELECT count(*) FROM abrechnung join artikel on aid = artikel.id Where artikel.istSKI = true AND ausgeborgtbis < current_date() AND zurueckgegeben = false;";
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            button_SK_overrent.Text = Reader.GetValue(0).ToString();
            connection.Close();
            //ski ende

            //snowboard
            command.CommandText = "SELECT count(*) FROM artikel Where istSKI is false";
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            button_SK_anz.Text = Reader.GetValue(0).ToString();
            connection.Close();
            //ausgeborgt
            command.CommandText = "SELECT count(*) FROM abrechnung join artikel on aid = artikel.id Where artikel.istSKI = false AND ausgeborgtbis > current_date() AND zurueckgegeben = false;";
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            button_SB_rent.Text = Reader.GetValue(0).ToString();
            connection.Close();
            //overrent
            command.CommandText = "SELECT count(*) FROM abrechnung join artikel on aid = artikel.id Where artikel.istSKI = false AND ausgeborgtbis < current_date() AND zurueckgegeben = false;";
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            button_SB_overrent.Text = Reader.GetValue(0).ToString();
            connection.Close();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button_SK_anz_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT  marke, count(*) FROM artikel Where istSKI is true group by marke";
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

        private void button_SK_rent_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select aid, artikel.marke, kid, kunde.nachname, ausgeborgtbis from abrechnung join artikel on aid = artikel.id join kunde on kid = kunde.id where artikel.istSKI = true AND ausgeborgtbis > current_date();";
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
                tbox_LOG_bottom.Text = tbox_LOG_bottom.Text + row + "\r\n";
            }
        }

        private void button_SK_overrent_Click(object sender, EventArgs e)
        {

        }


    }
}
