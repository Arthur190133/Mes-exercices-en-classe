using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_5
{
    class Program
    {

        static void table(ref string Total_value)
        {

            int Current_value;

            for (Current_value = 5; Current_value <= 500; Current_value+= 5)
            {
                Total_value = Total_value + Current_value + ", ";
            }
        }
        static void Main(string[] args)
        {

            string Total_value;


            Total_value = "0, ";
            table(ref Total_value);

            Console.WriteLine(Total_value);
            Console.ReadLine();
        }
    }
}
