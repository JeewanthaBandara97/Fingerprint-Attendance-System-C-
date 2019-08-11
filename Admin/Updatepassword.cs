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
    public partial class Updatepassword : Form
    {
        public Updatepassword()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NSBM\Project Database\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin ll = new Admin();
            this.Hide();
            ll.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = " UPDATE Login SET USERNAME ='" + textBox1.Text + "',PASSWORD = '" + textBox2.Text + "'  WHERE USERNAME = '" + textBox1.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Success!!!");
        }
    }
}
