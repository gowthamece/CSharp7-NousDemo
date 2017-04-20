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
            //Local Functions
            void Multiply(int x, int y)
            {
                WriteLine($"{x} * {y}={x * y}");
            }
            void Add(int x, int y)
            {
                WriteLine($"{x}+{y}={x + y}");
            }
            Multiply(10, 20);
            Add(10, 20);
             PrintBinaryLiterals(0b00001010);

            //Pattern Matching
            void PatternMatching()
            {
                var x = "Hello";
                
                string result = x is string ? "Yes" : "No";
                //string result1 = x is string a ? a : "No";
                WriteLine($"{result}");

            }

            PatternMatching();
            void SwitchPattern(object Shape)
            {

                switch (Shape)
                {
                    case Rectangle s when (s.Length == s.Height):
                        WriteLine($"Area of the Square={s.Height * s.Height }");
                        break;
                    case Rectangle r:
                        WriteLine($"Area of the rectangle={r.Height * r.Length}");
                        break;
                    case Circle c:
                        WriteLine($"Area of the the circle = {3.14 * c.Radius * c.Radius}");
                        break;
                    default:
                        WriteLine("unknown Shapes");
                        break;
                }


            }
            Circle _Circle = new Circle(10);
            SwitchPattern(_Circle);
            Rectangle _Rectangle = new Rectangle(10, 20);
            SwitchPattern(_Rectangle);

            ReadLine();


        }
        public int AddTest(int x, int y)
        {
            int result = x + y;
            return result;
        }

        //Tuples example 
        
        (int value, string message) TuplesFunction(int R)
        {
            var temp = (R, "I'm Tuples");
            return temp;
        }


           //binary literals 
       public static void PrintBinaryLiterals(int x)
        {
            WriteLine($"Binary Value in Decimal={x}");
        }






    }
    public class Circle
    {
        public Circle(int radius)
        {
            this.Radius = radius;

        }
        public int Radius { get; set; }
    }

    class Rectangle
    {
        Circle _Circle = new Circle(10);

        public Rectangle(int Length, int Height)
        {
            this.Length = Length;
            this.Height = Height;
        }
        public int Length { get; set; }
        public int Height { get; set; }
    }


}
