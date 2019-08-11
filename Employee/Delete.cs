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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NSBM\Project Database\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
     
        }

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
            String query = "DELETE FROM Employee WHERE EMPID ='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Success!!!");
        }
    }
}
