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
    public partial class CreateUser : Form
    {
        private string myConnectionString = "SERVER=localhost;" + "DATABASE=itp_proto;" + "UID=itp;" + "PASSWORD=rent;";
        public CreateUser()
        {
            InitializeComponent();
        }
        public void db_newUser()
        {
            MySqlCommand command = new MySqlCommand();
            MySqlConnection connect = new MySqlConnection(myConnectionString);
            command.CommandText = "Select max(?id) from abrechnung;";
            command.Parameters.Add("?id", MySqlDbType.VarChar).Value = "id";
            connect.Open();
            MySqlDataReader Reader = command.ExecuteReader();
            int id = 0;
            while (Reader.Read())
            {
                id = int.Parse(Reader.GetValue(0).ToString());
                id++;
            }
            command.Connection.Close();
            command.CommandText = "Insert into kunde Values(?id,'?vname','?nname','?adr','?debit','?code')";
            command.Parameters.Add("?id", MySqlDbType.Int16).Value = id;
            command.Parameters.Add("?vname", MySqlDbType.VarChar).Value = vtbox.Text;
            command.Parameters.Add("?nname", MySqlDbType.VarChar).Value = ntbox.Text;
            command.Parameters.Add("?adr", MySqlDbType.VarChar).Value = atbox.Text;
            command.Parameters.Add("?debit", MySqlDbType.VarChar).Value = ktbox.Text;
            command.Parameters.Add("?code", MySqlDbType.VarChar).Value = ctbox.Text;
            command.Connection = connect;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
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
