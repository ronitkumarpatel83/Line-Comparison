using System;

namespace Line_Comparison
{
    internal class Program
    {
        public static void UC1(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Welcome to Line Comparison Program ");
          

            double result, sum;
            sum = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            result = Math.Sqrt(sum);
            Console.WriteLine("The length is :"+ result);
            Console.ReadLine();
        }
        public static void UC2(int a1, int b1, int a2, int b2)
        {
            int len1, len2;
            if (a1 == a2)
            {
                Console.WriteLine(b1.Equals(b2));
            }
            else
            {
                len1 = b1 - a1;
                len2 = b2 - a2;
                Console.WriteLine(len1.Equals(len2));
                Console.ReadLine();
            }
        }
        public static void UC3(int l1, int m1, int l2, int m2)
        {
            int le1, le2;
            if (l1 == l2)
            {
                int comp = m1.CompareTo(m2);
                if (comp == 0)
                {
                    Console.WriteLine("Both line are equals");
                }
                else if (comp >= 0)
                {
                    Console.WriteLine("Second line is Smaller than first");
                }
                else
                {
                    Console.WriteLine("Second line is bigger than First");
                }
            }
            else
            {
                le1 = m1 - l1;
                le2 = m2 - l2;
                int comp = le1.CompareTo(le2);
                if (comp == 0)
                {
                    Console.WriteLine("Both line are equals");
                }
                else if (comp >= 0)
                {
                    Console.WriteLine("Second line is Smaller than first");
                }
                else
                {
                    Console.WriteLine("Second line is bigger than First");
                }
                Console.ReadLine();
            }

        }
        abstract class Comparison // Creating abstract class
        {
            public abstract void LineComparison(double a, double b); //Abstract Method
        }
        class Line : Comparison // Inherite Comparison class 
        {
            public double x1, y1, x2, y2, lineLength;
            public void Input() // Class method
            {
                Console.WriteLine("\nEnter first point X coordinate x1: ");
                x1 = Convert.ToDouble(Console.ReadLine()); // reads x - coordinate of starting point for line 1
                Console.WriteLine("Enter first point Y coordinate y1: ");
                y1 = Convert.ToDouble(Console.ReadLine()); // reads y - coordinate of starting point for line 1
                Console.WriteLine("\nEnter second point X coordinate x2: ");
                x2 = Convert.ToDouble(Console.ReadLine()); // reads x - coordinate of end point for line 1
                Console.WriteLine("Enter second point Y coordinate y2: ");
                y2 = Convert.ToDouble(Console.ReadLine()); // reads y - coordinate of end point for line 1
            }
            public double LineLengthComputation(double x1, double y1, double x2, double y2) // Class Method
            {
                double powerx = Math.Pow((x2 - x1), 2);
                double powery = Math.Pow((y2 - y1), 2);
                lineLength = Math.Sqrt((powerx + powery)); // Finding  Length of line
                return lineLength; // return length of line
            }
            public override void LineComparison(double lineLength1, double lineLength2) // Overriding abstract Method of inherited class
            {
                Console.WriteLine("\n\nComparison between lines....");
                int result;
                Console.Write("\n\nFirst Line is Equal To Second Line : ");
                Console.WriteLine(lineLength1.Equals(lineLength2));
                result = lineLength1.CompareTo(lineLength2); // Comparing two lines
                if (result > 0)
                    Console.WriteLine($"\n So First line is greater than Second line");

                else if (result < 0)
                    Console.WriteLine($"\n So First line is less than Second line");
                else
                    Console.WriteLine($"\nSo First Line and Second Line Both are Equal");
            }
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
           
            Console.WriteLine("To Check Both Line Equals or not by Equals method");
            Console.WriteLine("Enter start and end points of First line: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            Program.UC2(a1, b1, a2, b2);

            Console.WriteLine("To Compare Both Line by CompareTo method");
            Console.WriteLine("Please Enter the first line coordinates");
            int l1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int l2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            Program.UC3(l1, m1, l2, m2);

            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("\nFor First Line......");
            Line line1 = new Line(); // Creating object for line 1
            line1.Input(); // Call the function input to provide line 1 points
            double lineLength1 = line1.LineLengthComputation(line1.x1, line1.y1, line1.x2, line1.y2); // Storing line 1 length
            Console.WriteLine($"\nLength of line using two points ({line1.x1},{line1.y1}) and ({line1.x2},{line1.y2}) is : {lineLength1}");
            Console.WriteLine("\n\nFor Second Line......");
            Line line2 = new Line(); // Creating object for line 1
            line2.Input();// Call the function input to provide line 1 points
            double lineLength2 = line2.LineLengthComputation(line2.x1, line2.y1, line2.x2, line2.y2); // Storing line 2 length
            Console.WriteLine($"\nLength of line using two points ({line2.x1},{line2.y1}) and ({line2.x2},{line2.y2}) is : {lineLength2}");
            line1.LineComparison(lineLength1, lineLength2); // Calling Compare method 
            Console.ReadLine();
        }
    }
}
