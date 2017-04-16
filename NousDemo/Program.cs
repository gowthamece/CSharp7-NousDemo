using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NousDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            var (value, message) = p.TuplesFunction(10);
            WriteLine($"Tuples Value1 : {value}, Value2 :{message}");
            int a = 10;
            if (a == 10)
            {
                WriteLine(10);
            }
            else
            {
                WriteLine(a);
            }

            ReadLine();


        }
        public int AddTest(int x, int y)
        {
            int result = x + y;
            return result;
        }
        (int value, string message) TuplesFunction(int R)
        {
            var temp = (R, "I'm Tuples");
            return temp;
        }





    }

}
