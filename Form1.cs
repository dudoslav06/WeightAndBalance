using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightAndBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            home1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void btnflightdata_Click(object sender, EventArgs e)
        {
            flightinfo1.BringToFront();
        }

        private void btnaddload_Click(object sender, EventArgs e)
        {
            addLoad1.BringToFront();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            wb1.BringToFront();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            help1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
