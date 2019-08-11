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
    public partial class CANCELLEAVE : Form
    {
        public CANCELLEAVE()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\NSBM\Project Database\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Leave ll = new Leave();
            this.Hide();
            ll.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "DELETE FROM Leave WHERE LEAVEID ='" + textBox2.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Canceled Leave!!!");
        }

        private void CANCELLEAVE_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
       
        }
    }
}
