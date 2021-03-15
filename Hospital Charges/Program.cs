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

            System.Console.WriteLine("Please enter the following information for your hospital stay.");
            System.Console.Write("\nNumber of days spent in the hospital: ");
            daysIn = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Total charges for medicine: $");
            medCharges = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Total surgical charges: $");
            surgicalCharges = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Total lab fees: $");
            labFees = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Total physical rehab charges: $");
            rehabCharges = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("\nUsing the information you input, what would you like to do?");
            System.Console.WriteLine("1. Calculate total base charges for the hospital stay");
            System.Console.WriteLine("2. Calculate total miscellaneous (medication, surgical, lab and rehab) charges");
            System.Console.WriteLine("3. Calculate total charges including the base and miscellaneous charges");
            System.Console.WriteLine("4. List results from all of the above");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                System.Console.WriteLine("\nBase stay charges: $" + CalcStayCharges(dailyCharge, daysIn));
            }
            else if (option == 2)
            {
                System.Console.WriteLine("\nTotal miscellaneous charges: $" + CalcMiscCharges(medCharges, surgicalCharges,
                                                                            labFees, rehabCharges));
            }
            else if (option == 3)
            {
                System.Console.WriteLine("\nTotal overall charges: $" + CalcTotalCharges(dailyCharge, daysIn, medCharges,
                                                                      surgicalCharges, labFees, rehabCharges));
            }
            else if (option == 4)
            {
                System.Console.WriteLine("\nBase stay charges: $" + CalcStayCharges(dailyCharge, daysIn));
                System.Console.WriteLine("Total miscellaneous charges: $" + CalcMiscCharges(medCharges, surgicalCharges,
                                                                            labFees, rehabCharges));
                System.Console.WriteLine("Total overall charges: $" + CalcTotalCharges(dailyCharge, daysIn, medCharges,
                                                                      surgicalCharges, labFees, rehabCharges));
            }
        }

        public static int CalcStayCharges (int daily, int days)
        {
            int stayCharges = 0;

            stayCharges = daily * days;

            return stayCharges;
        }

        public static int CalcMiscCharges (int meds, int surgical, int lab, int rehab)
        {
            int miscCharges = 0;

            miscCharges = meds + surgical + lab + rehab;

            return miscCharges;
        }

        public static int CalcTotalCharges (int daily, int days, int meds, int surgical, int lab, int rehab)
        {
            int totalCharges = 0;

            totalCharges = CalcStayCharges(daily, days) + CalcMiscCharges(meds, surgical, lab, rehab);

            return totalCharges;
        }
    }
}
