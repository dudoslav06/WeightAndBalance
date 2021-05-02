using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAndBalance
{
    class ContainersFile
    {

        public static int[] Containerdata { get; set; } = new int[24];

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

            int coga = positionA * Containerdata[12];
            int cogb = positionB * Containerdata[13];
            int cogc = positionC * Containerdata[14];
            int cogd = positionD * Containerdata[15];
            int coge = positionE * Containerdata[16];
            int cogf = positionF * Containerdata[17];
            
            int cogg = positionG * Containerdata[18];
            int cogh = positionH * Containerdata[19];
            int cogi = positionI * Containerdata[20];
            int cogj = positionJ * Containerdata[21];
            int cogk = positionK * Containerdata[22];
            int cogl = positionL * Containerdata[23];

            int sumMassOfContainer = (Containerdata[12]) + (Containerdata[13] + (Containerdata[14]) + (Containerdata[15]) + (Containerdata[16]) + (Containerdata[17]) + (Containerdata[18]) + (Containerdata[19]) + (Containerdata[20]) + (Containerdata[21]) + (Containerdata[22]) + (Containerdata[23]));
            
            int cog = ((coga + cogb + cogc + cogd + coge + cogf + cogg + cogh + cogi + cogj + cogk + cogl) / sumMassOfContainer) - 2;

            if (cog > -1 && cog < 1)
            {
                return;
            }
            else
            {
                
                if (cog >-1)
                {
                    for (int i = 12; i < 23; i++)
                    {
                        for (int j = 12; j < 23; j++)
                        {
                            if ((Containerdata[i]) > (Containerdata[j]))
                            {
                                x = Containerdata[j];
                                Containerdata[j] = Containerdata[i];
                                Containerdata[i] = x;
                                if (cog > - 1 && cog <1)
                                {
                                    break;
                                }
                            }
                        }
                    }
                    
                }

            }



        }




        //String[] containerdata = new string[24];
        //// 0-11 - containers id
        //containerdata[0] = boxcontid1.Text;
        //    containerdata[1] = boxcontid2.Text;
        //    containerdata[2] = boxcontid3.Text;
        //    containerdata[3] = boxcontid4.Text;
        //    containerdata[4] = boxcontid5.Text;
        //    containerdata[5] = boxcontid6.Text;
        //    containerdata[6] = boxcontid7.Text;
        //    containerdata[7] = boxcontid8.Text;
        //    containerdata[8] = boxcontid9.Text;
        //    containerdata[9] = boxcontid10.Text;
        //    containerdata[10] = boxcontid11.Text;
        //    containerdata[11] = boxcontid12.Text;
        //    // 12 - 23 - weight
        //    containerdata[12] = boxcontweight1.Text;
        //    containerdata[13] = boxcontweight2.Text;
        //    containerdata[14] = boxcontweight3.Text;
        //    containerdata[15] = boxcontweight4.Text;
        //    containerdata[16] = boxcontweight5.Text;
        //    containerdata[17] = boxcontweight6.Text;
        //    containerdata[18] = boxcontweight7.Text;
        //    containerdata[19] = boxcontweight8.Text;
        //    containerdata[20] = boxcontweight9.Text;
        //    containerdata[21] = boxcontweight10.Text;
        //    containerdata[22] = boxcontweight11.Text;
        //    containerdata[23] = boxcontweight12.Text;
    }
}
