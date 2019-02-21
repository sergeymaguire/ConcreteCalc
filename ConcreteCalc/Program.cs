using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double dYdsOrd = getYardsOrdered();

            double dNetBill = CalcBill(dYdsOrd);
            Console.WriteLine("The net bill is: " + "$" + dNetBill);
            Console.ReadLine();

        }
        private static double CalcBill(double pdYdsOrd)
        {
            if (pdYdsOrd >= 8)
            {
                //Console.WriteLine("Your net bill is " + "$" + dNetBillScr);
                return 49.50 * pdYdsOrd;
            }
            else if (pdYdsOrd <= 3)
            {
                return pdYdsOrd * 55.50 + 25.00;
            }
            else
            {
                return pdYdsOrd * 55.50;
            }

        }

        private static double getYardsOrdered()
        {
            double dYdsOrd;
            Console.Write("Enter how much concrete you would like to buy: ");
            dYdsOrd = Double.Parse(Console.ReadLine());
            return dYdsOrd;
            //string sYdsOrd = Console.ReadLine();  
        }
    }
}
