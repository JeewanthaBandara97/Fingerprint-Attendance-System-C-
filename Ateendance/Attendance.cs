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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

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
    }
}
