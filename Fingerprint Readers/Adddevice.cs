using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project_New
{
    public partial class Adddevice : Form
    {
        public Adddevice()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NSBM\Project Database\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FingerprintReaders ff = new FingerprintReaders();
            this.Hide();
            ff.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox7.Text = String.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO device(DEVICEID,DEVICENAME,MACHINENO,COMTYPE,IPADDRESS,PORT) VALUES('" + textBox1.Text + "' ,'" + textBox2.Text + "' ,'" + textBox3.Text + "' ,'" + textBox4.Text + "' ,'" + textBox5.Text + "' ,'" + textBox7.Text + "'  )";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            ////////////////////////////////////////////////////////////////////////////
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please fill required fields");
                return;
            }

            else if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty )
            {
                MessageBox.Show("Please fill the details");
            }
            else
            {
                MessageBox.Show("Insert Success!!!");
            }

            ////////////////////////////////////////////////////////////////////////////
        }
    }
}
