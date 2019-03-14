using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> data = new Dictionary<int, int>{ {210,140},{ 270,190},{290,250 },
                {310,270}, { 450, 340},{480, 360},{ 510, 420 }, { 520, 390 }};

            Dictionary<int, int> testData = new Dictionary<int, int> { { 370, 290 }, { 400, 310 } };
            LinearRegression<int> linearRegression = new LinearRegression<int>(data);
            linearRegression.Test(testData);

            Console.ReadKey();
        }
    }
}
