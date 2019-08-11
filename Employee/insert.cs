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
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NSBM\Project Database\Database.mdf;Integrated Security=True;Connect Timeout=30");


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO Employee(EMPID,NAME,CONTACTNO,EMAIL,NIC,ADDRESS,DOB,DEPARTMENT,DOJ,POSITION) VALUES('" + textBox1.Text + "' ,'" + textBox2.Text + "' ,'" + textBox3.Text + "' ,'" + textBox4.Text + "' ,'" + textBox5.Text + "' ,'" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "'  )";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            
            ////////////////////////////////////////////////////////////////////////////
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please fill required fields");
                return;
            }

            else if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty || textBox6.Text == string.Empty || textBox7.Text == string.Empty || textBox8.Text == string.Empty || textBox9.Text == string.Empty)
            {
                MessageBox.Show("Please fill the details");
            }
            else
            {
                MessageBox.Show("Insert Success!!!");
            }

            ////////////////////////////////////////////////////////////////////////////
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee mm = new Employee();
            this.Hide();
            mm.Show();

        }

        private void insert_Load(object sender, EventArgs e)
        {

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
