﻿using System;
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

            System.Console.WriteLine("\nUsing the information you inputted, what would you like to do?");
            System.Console.WriteLine("1. Calculate total base charges for the hospital stay");
            System.Console.WriteLine("2. Calculate total miscellaneous (medication, surgical, lab and rehab) charges");
            System.Console.WriteLine("3. Calculate total charges including the base and miscellaneous charges");
            System.Console.WriteLine("4. List results from all of the above");
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
