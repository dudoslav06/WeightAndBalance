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
    public partial class Flightinfo : UserControl
    {
        public Flightinfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //boxdate.Value.
            boxfltnumber.Text = "";
            boxorgin.Text = "";
            boxdestination.Text = "";
            boxregistration.Text = "";
            boxcrew.Text = "2";
            boxbf.Text = "";
            boxtaxi.Text = "";
            boxtrip.Text = "";

        }
    }
}
