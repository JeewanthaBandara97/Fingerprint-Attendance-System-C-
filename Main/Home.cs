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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin vv = new Admin();
             
            vv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance vv = new Attendance();
             
            vv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leave ll = new Leave();
            
            ll.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FingerprintReaders ff = new FingerprintReaders();
            
            ff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tools tt = new Tools();
             
            tt.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help hh = new Help();
            
            hh.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
             
            em.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Fi aa = new Fi();
            this.Hide();
            aa.Show();
        }
    }
}
