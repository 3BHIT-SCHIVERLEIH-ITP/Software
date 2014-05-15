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
        public CreateUser(string s)
        {
            InitializeComponent();
            myConnectionString = s;
        }
        public void db_newUser()
        {
            
            MySqlConnection connect = new MySqlConnection(myConnectionString);
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "Select max(?id) from abrechnung;";
            command.Parameters.Add("?id", MySqlDbType.VarChar).Value = "id";
            MySqlDataReader Reader;

            command.CommandText = "Select max(id) from kunde;";
            connect.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            int id = 201;
            id = Int32.Parse(Reader.GetValue(0).ToString());
            id++;
            connect.Close();


            command.Connection.Close();
            command = new MySqlCommand();
            command.CommandText = "Insert into kunde Values("+id+",'"+vtbox.Text+"','"+ntbox.Text+"','"+atbox.Text+"','"+ktbox.Text+"','" + ctbox.Text +"')";
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
            db_newUser();
            this.Dispose();
            this.Visible = false;
        }

    }
}
