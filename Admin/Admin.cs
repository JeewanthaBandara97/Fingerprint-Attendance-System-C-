using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_New
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin vv = new Admin();
            this.Hide();
            vv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance vv = new Attendance();
            this.Hide();
            vv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leave ll = new Leave();
            this.Hide();
            ll.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FingerprintReaders ff = new FingerprintReaders();
            this.Hide();
            ff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tools tt = new Tools();
            this.Hide();
            tt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help hh = new Help();
            this.Hide();
            hh.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            this.Hide();
            em.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Home hh = new Home();
            this.Hide();
            hh.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Viewadmin va = new Viewadmin();
            this.Hide();
            va.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Addadmin ada = new Addadmin();
            this.Hide();
            ada.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Updatepassword up = new Updatepassword();
            this.Hide();
            up.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Deleteadmin dd = new Deleteadmin();
            this.Hide();
            dd.Show();
        }
    }
}
