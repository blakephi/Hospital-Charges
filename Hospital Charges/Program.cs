using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Charges
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dailyCharge = 350;
            int daysIn;
            int medCharges;
            int surgicalCharges;
            int labFees;
            int rehabCharges;
        }

        public static int CalcStayCharges (int daily, int days)
        {
            int stayCharges = 0;

            stayCharges = daily * days;

            return stayCharges;
        }
    }
}
