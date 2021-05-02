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
            // 0-11 - containers id

            ContainersFile.Containerdata[0] = int.Parse(boxcontid1.Text);
            ContainersFile.Containerdata[1] = int.Parse(boxcontid2.Text);
            ContainersFile.Containerdata[2] = int.Parse(boxcontid3.Text);
            ContainersFile.Containerdata[3] = int.Parse(boxcontid4.Text);
            ContainersFile.Containerdata[4] = int.Parse(boxcontid5.Text);
            ContainersFile.Containerdata[5] = int.Parse(boxcontid6.Text);
            ContainersFile.Containerdata[6] = int.Parse(boxcontid7.Text);
            ContainersFile.Containerdata[7] = int.Parse(boxcontid8.Text);
            ContainersFile.Containerdata[8] = int.Parse(boxcontid9.Text);
            ContainersFile.Containerdata[9] = int.Parse(boxcontid10.Text);
            ContainersFile.Containerdata[10] = int.Parse(boxcontid11.Text);
            ContainersFile.Containerdata[11] = int.Parse(boxcontid11.Text);
            // 12 - 23 - weight
            ContainersFile.Containerdata[12] = int.Parse(boxcontweight1.Text);
            ContainersFile.Containerdata[13] = int.Parse(boxcontweight2.Text);
            ContainersFile.Containerdata[14] = int.Parse(boxcontweight3.Text);
            ContainersFile.Containerdata[15] = int.Parse(boxcontweight4.Text);
            ContainersFile.Containerdata[16] = int.Parse(boxcontweight5.Text);
            ContainersFile.Containerdata[17] = int.Parse(boxcontweight6.Text);
            ContainersFile.Containerdata[18] = int.Parse(boxcontweight7.Text);
            ContainersFile.Containerdata[19] = int.Parse(boxcontweight8.Text);
            ContainersFile.Containerdata[20] = int.Parse(boxcontweight9.Text);
            ContainersFile.Containerdata[21] = int.Parse(boxcontweight10.Text);
            ContainersFile.Containerdata[22] = int.Parse(boxcontweight11.Text);
            ContainersFile.Containerdata[23] = int.Parse(boxcontweight12.Text);
            
            MessageBox.Show("Saved succesfull", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SortContainers();
            //System.Windows.Forms.Label label2;
            

    }

    public void SortContainers()
        {

            int x;

            int positionA = -6;
            int positionB = -5;
            int positionC = -4;
            int positionD = -3;
            int positionE = -2;
            int positionF = -1;
            int positionG = 1;
            int positionH = 2;
            int positionI = 3;
            int positionJ = 4;
            int positionK = 5;
            int positionL = 6;




            var coga = positionA * (ContainersFile.Containerdata[12]);
            var cogb = positionB * (ContainersFile.Containerdata[13]);
            var cogc = positionC * (ContainersFile.Containerdata[14]);
            var cogd = positionD * (ContainersFile.Containerdata[15]);
            var coge = positionE * (ContainersFile.Containerdata[16]);
            var cogf = positionF * (ContainersFile.Containerdata[17]);

            int cogg = positionG * (ContainersFile.Containerdata[18]);
            int cogh = positionH * (ContainersFile.Containerdata[19]);
            int cogi = positionI * (ContainersFile.Containerdata[20]);
            int cogj = positionJ * (ContainersFile.Containerdata[21]);
            int cogk = positionK * (ContainersFile.Containerdata[22]);
            int cogl = positionL * (ContainersFile.Containerdata[24]);

            int sumMassOfContainer = (ContainersFile.Containerdata[12]) + (ContainersFile.Containerdata[13] + (ContainersFile.Containerdata[14]) + (ContainersFile.Containerdata[15]) + (ContainersFile.Containerdata[16]) + (ContainersFile.Containerdata[17]) + (ContainersFile.Containerdata[18]) + (ContainersFile.Containerdata[19]) + (ContainersFile.Containerdata[20]) + (ContainersFile.Containerdata[21]) + (ContainersFile.Containerdata[22]) + (ContainersFile.Containerdata[23]));

            int cog = ((coga + cogb + cogc + cogd + coge + cogf + cogg + cogh + cogi + cogj + cogk + cogl) / sumMassOfContainer) - 2;

            if (cog > -1 && cog < 1)
            {
                return;
            }
            else
            {

                if (cog > -1)
                {
                    for (int i = 12; i < 24; i++)
                    {
                        for (int j = 12; j < 24; j++)
                        {
                            if ((ContainersFile.Containerdata[i]) > (ContainersFile.Containerdata[j]))
                            {
                                x = ContainersFile.Containerdata[j];
                                ContainersFile.Containerdata[j] = ContainersFile.Containerdata[i];
                                ContainersFile.Containerdata[i] = x;
                                if (cog > -1 && cog < 1)
                                {
                                    break;
                                }
                            }
                        }
                    }

                }

            }
        }
    }

}
