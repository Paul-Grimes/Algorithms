using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Access;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variance
            double[] myArray = { 89.0, 76.6, 95.4, 79.8, 88.4, 99.5, 102.0, 76.5, 94.5 };
            StringBuilder seedNumber = new StringBuilder();
            Console.WriteLine("Seeded Numbers");

            foreach (int item in myArray)
            {
                seedNumber.Append(item.ToString() + ", ");
            }
            Console.WriteLine(seedNumber.ToString().TrimEnd(", ".ToCharArray()));

            var controller = new Control();

            Console.WriteLine("Variance:");
            Console.WriteLine(controller.Variance(myArray));

            //Standard Divation
            Console.WriteLine("Standard Deviation:");
            Console.WriteLine(controller.StandardDeviation(myArray));

            Console.ReadLine();

        }
    }
}
