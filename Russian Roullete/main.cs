using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
    class main
    {
        public int chance = 2;// 2 chances for shoot away
        public int TotalShoot = 6;//total number of shoots 
        public int LOadSpin;


        public int gunloadshoot()
        {
            int Totalscore = 0;
            if (TotalShoot > 0 && LOadSpin == 1 && chance == 2)
            {

                Totalscore = 10;//if you win the first time


            }
            if (TotalShoot > 0 && LOadSpin == 1 && chance == 1)
            {

                Totalscore = 5;//if you win the second time

            }

            else if (TotalShoot > 0 && LOadSpin != 1)
            {
                Totalscore = 0;
                TotalShoot = TotalShoot - 1;
                if (LOadSpin == 6)
                {
                    LOadSpin = 1;
                }
                else
                {
                    LOadSpin++;
                }




            }
            return Totalscore;
        }
    }
}
