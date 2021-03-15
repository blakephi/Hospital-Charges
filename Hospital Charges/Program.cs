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

            System.Console.WriteLine("Please enter the following information for you hospital stay.");
            System.Console.WriteLine("Number of days spent in the hospital: ");
            daysIn = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Total charges for medicine: ");
            medCharges = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Total surgical charges: ");
            surgicalCharges = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Total lab fees: ");
            labFees = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Total physical rehab charges: ");
            rehabCharges = Convert.ToInt32(Console.ReadLine());
        }

        public static int CalcStayCharges (int daily, int days)
        {
            int stayCharges = 0;

            stayCharges = daily * days;

            return stayCharges;
        }
    }
}
