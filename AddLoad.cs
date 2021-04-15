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
    public partial class AddLoad : UserControl
    {
        public AddLoad()
        {
            InitializeComponent();
        }

        private void boxcontid1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxcontweight1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclearload_Click(object sender, EventArgs e)
        {
            Clearboxes();
        }

        public void Clearboxes()
        {
            TextBox[] all = new TextBox[24];
            all[0] = boxcontid1;
            all[1] = boxcontid2;
            all[2] = boxcontid3;
            all[3] = boxcontid4;
            all[4] = boxcontid5;
            all[5] = boxcontid6;
            all[6] = boxcontid7;
            all[7] = boxcontid8;
            all[8] = boxcontid9;
            all[9] = boxcontid10;
            all[10] = boxcontid11;
            all[11] = boxcontid12;
            all[12] = boxcontweight1;
            all[13] = boxcontweight2;
            all[14] = boxcontweight3;
            all[15] = boxcontweight4;
            all[16] = boxcontweight5;
            all[17] = boxcontweight6;
            all[18] = boxcontweight7;
            all[19] = boxcontweight8;
            all[20] = boxcontweight9;
            all[21] = boxcontweight10;
            all[22] = boxcontweight11;
            all[23] = boxcontweight12;

            DialogResult result = MessageBox.Show("Are you sure to clear all?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (TextBox b in all)
                {
                    b.Text = "";
                }
            }
            else
            {
                return;
            }
        }

        private void btnsaveload_Click(object sender, EventArgs e)
        {
            String[] containerdata = new string[24];
            // 0-11 - containers id
            containerdata[0] = boxcontid1.Text;
            containerdata[1] = boxcontid2.Text;
            containerdata[2] = boxcontid3.Text;
            containerdata[3] = boxcontid4.Text;
            containerdata[4] = boxcontid5.Text;
            containerdata[5] = boxcontid6.Text;
            containerdata[6] = boxcontid7.Text;
            containerdata[7] = boxcontid8.Text;
            containerdata[8] = boxcontid9.Text;
            containerdata[9] = boxcontid10.Text;
            containerdata[10] = boxcontid11.Text;
            containerdata[11] = boxcontid12.Text;
            // 12 - 23 - weight
            containerdata[12] = boxcontweight1.Text;
            containerdata[13] = boxcontweight2.Text;
            containerdata[14] = boxcontweight3.Text;
            containerdata[15] = boxcontweight4.Text;
            containerdata[16] = boxcontweight5.Text;
            containerdata[17] = boxcontweight6.Text;
            containerdata[18] = boxcontweight7.Text;
            containerdata[19] = boxcontweight8.Text;
            containerdata[20] = boxcontweight9.Text;
            containerdata[21] = boxcontweight10.Text;
            containerdata[22] = boxcontweight11.Text;
            containerdata[23] = boxcontweight12.Text;
            MessageBox.Show("Saved succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Weighting(containerdata);
        }

        private void Weighting(string[] containerdata)
        {
            
        }
    }
}
