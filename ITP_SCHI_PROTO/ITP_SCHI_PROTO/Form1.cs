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
        public int kunden_id=-1;
        private int op = -1;
        public DateTime datum;
        private string myConnectionString = "SERVER=localhost;" +
                            "DATABASE=itp_proto;" +
                            "UID=itp;" +
                            "PASSWORD=rent;";
        public Form1()
        {
            InitializeComponent();
            loadUP();
        }
        private void loadUP()
        {
            //ski anzahl button text
            #region normaler SQL text
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            #endregion
            #region button beschriftung
            command.CommandText = "SELECT count(*) FROM artikel Where istSKI = true;";
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
            button_SB_anz.Text = Reader.GetValue(0).ToString();
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
            #endregion
            connection.Close();


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        #region 6 buttons up click
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
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select aid, artikel.marke, kid, kunde.nachname, ausgeborgtbis from abrechnung join artikel on aid = artikel.id join kunde on kid = kunde.id where artikel.istSKI = true AND ausgeborgtbis < current_date() AND zurueckgegeben = false;";
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

        private void button_SB_anz_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT  marke, count(*) FROM artikel Where istSKI is false group by marke";
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
                tbox_LOG_bottom.Text = tbox_LOG_bottom.Text + row + "\r\n";
            }
        }

        private void button_SB_rent_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select aid, artikel.marke, kid, kunde.nachname, ausgeborgtbis from abrechnung join artikel on aid = artikel.id join kunde on kid = kunde.id where artikel.istSKI = false AND ausgeborgtbis > current_date();";
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

        private void button_SB_overrent_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select aid, artikel.marke, kid, kunde.nachname, ausgeborgtbis from abrechnung join artikel on aid = artikel.id join kunde on kid = kunde.id where artikel.istSKI = false AND ausgeborgtbis < current_date() AND zurueckgegeben = false;";
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
        #endregion

        private void mysql_edit()
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "Select max(id) from abrechnung;";
            int kid = 0;
            int aid = 0;
            string g = "";
            //Boolean gete = false;
            if (this.kunden_id != -1)
            {
                kid = this.kunden_id;
                aid = int.Parse(textBox1.Text);
                if (op == 1)
                {
                    command.CommandText = "Select max(?id) from abrechnung;";
                    command.Parameters.Add("?id", MySqlDbType.VarChar).Value = "id";
                    connection.Open();
                    Reader = command.ExecuteReader();
                    int id=0;
                    while (Reader.Read())
                    {
                        id = int.Parse(Reader.GetValue(0).ToString());
                        id++;
                    }
                    command.Connection.Close();
                    command.CommandText = "Update abrechnung set zurueckgegeben=true where kid like ?kid and aid like ?aid";
                    command.Parameters.Add("?id", MySqlDbType.Int16).Value = id;
                    command.Parameters.Add("?date", MySqlDbType.Date).Value = convert_date(datum);
                    command.Parameters.Add("?kid", MySqlDbType.Int16).Value = kid;
                    command.Parameters.Add("?aid", MySqlDbType.Int16).Value = aid;
                    command.Connection = connection;
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    
                }
                else
                {
                    if (op == 2)
                    {
                        //g = "Insert into abrechnung VALUES (" + id + ",'" + convert_date(this.datum) + "'," + kid + "," + aid + ",false);";

                        command.CommandText = "Select max(id) from abrechnung;";
                        connection.Open();
                        Reader = command.ExecuteReader();
                        Reader.Read();
                        int id=201;
                        id =  Int32.Parse( Reader.GetValue(0).ToString());
                        id++;
                        connection.Close();
                        command = new MySqlCommand();
                        command.CommandText = "INSERT INTO abrechnung VALUES(?id,?date,?kid,?aid,false)";
                        command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                        command.Parameters.Add("?date", MySqlDbType.Date).Value = convert_date(datum);
                        command.Parameters.Add("?kid", MySqlDbType.Int32).Value = kid;
                        command.Parameters.Add("?aid", MySqlDbType.Int32).Value = aid;
                        command.Connection = connection;
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();

                    }

                }
                
            }
            loadUP();
            //Auslesen der Änderungen und Übernehmen
        }
        private String convert_date(DateTime dt)
        {
            String datume = "";
            datume += dt.Year;
            if (dt.Month.ToString().Length < 2)
                datume += "-0" + dt.Month;
            else
                datume += "-" + dt.Month;
            datume += "-" + dt.Day;
            return datume;
        }
        private void button_SK_modi_Click(object sender, EventArgs e)
        {
            if (op == 2)
            {
                tbox_LOG_bottom.Text = "Rent till: " + convert_date(datum) + ", Kundenid: " + kunden_id + ", Artikelid: " + textBox1.Text;
                mysql_edit();
            }
            else
            {
                tbox_LOG_bottom.Text = "Kundenid: " + kunden_id + ", Artikelid: " + textBox1.Text;
            }
        }
        private void kchosen(){
                if (!(radioButton1.Checked == false && radioButton2.Checked == false))
                {
                    if (radioButton1.Checked == true)
                    {
                        mysql_edit(true);//Zurueckgeben
                    }
                    else
                    {
                        mysql_edit(false);//Ausborgen
                    }
                    this.kunden_id = -1;
                }
            }
        private void mysql_edit(bool b)
        {
            if (b)
            {
                String s = "UPADTE abrechnung SET zurueckgegeben=true where kid like " + this.kunden_id + " and aid like " + textBox1.ToString() + ";";
                mslq(s);
            }
            if (!b)
            {
                kalender kb = new kalender();
                kb.TheParent = this;
                kb.Show();
                String s = "Insert into abrechnung VALUES ((select (max(id)+1) from abrechnung),'2014-04-21'," + this.kunden_id + "," + textBox1.ToString() + ",false);";
                mslq(s);
            }
        }
        private Object mslq(String s)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = s;
            connection.Open();
            Reader = command.ExecuteReader();
            Reader.Read();
            s = Reader.GetValue(0).ToString();
            connection.Close();
            return s;
        }
        #region radiobuttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.op = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.op = 2;
            }
        }
        #endregion
        private void button_SK_Scan_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KundenBearbeitung kb = new KundenBearbeitung();
            kb.TheParent = this;
            kb.Show();
        }

        private void Form1_Loadup(object sender, EventArgs e)
        {
            this.loadUP();
        }


    }
}
