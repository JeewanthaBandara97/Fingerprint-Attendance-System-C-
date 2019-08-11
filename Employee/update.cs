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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NSBM\Project Database\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Close();
            Employee mm = new Employee();
            this.Hide();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = " UPDATE Employee SET EMPID ='" + textBox1.Text + "',NAME = '" + textBox2.Text + "',CONTACTNO = '" + textBox3.Text + "',EMAIL ='" + textBox4.Text + "',NIC ='" + textBox5.Text + "' ,ADDRESS ='" + textBox6.Text + "',DOB ='" + textBox7.Text + "',DEPARTMENT ='" + textBox8.Text + "',DOJ ='" + textBox9.Text + "',POSITION ='" + textBox10.Text + "'   WHERE EMPID = '" + textBox1.Text + "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Success!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
        }
    }
}
