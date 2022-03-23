using System;

namespace Line_Comparison
{
    internal class Program
    {
        public static void UC1(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Welcome to Line Comparison Program");
          

            double result, sum;
            sum = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            result = Math.Sqrt(sum);
            Console.WriteLine("The length is :"+ result);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter X co-ordinates: (x1 and y1)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Y co-ordinates: (x2 and y2)");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Program.UC1(x1, y1, x2, y2);
        }
    }
}
