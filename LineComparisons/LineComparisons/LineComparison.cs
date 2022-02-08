using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisons
{
    public class LineComparison
    {
        public void LengthofLine()
        {
            Console.WriteLine("Enter value for x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double LengthofLine = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of line is:" + LengthofLine);
        }

        //UC-2
        public void EqualityofLines()
        {
            Console.WriteLine("Enter value for x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter value for j1: ");
            int j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for j2: ");
            int j2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for k1: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for k2: ");
            int k2 = Convert.ToInt32(Console.ReadLine());

            double LengthofLine1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            double LengthofLine2 = Math.Sqrt((j2 - j1) ^ 2 + (k2 - k1) ^ 2);
            Console.WriteLine("Length of Line1 : " + LengthofLine1);
            Console.WriteLine("Length of Line2 : " + LengthofLine2);

            if (LengthofLine1.Equals(LengthofLine2))
            {
                Console.WriteLine("Two lines are equal ");
            }
            else
            {
                Console.WriteLine("Two lines are Not equal");
            }
        }
            //UC-3
        public void CompareLines()
        {
            Console.WriteLine("Enter value for x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter value for j1: ");
            int j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for j2: ");
            int j2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for k1: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for k2: ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            double LengthofLine1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            double LengthofLine2 = Math.Sqrt((j2 - j1) ^ 2 + (k2 - k1) ^ 2);
            Console.WriteLine("Length of Line1 : " + LengthofLine1);
            Console.WriteLine("Length of Line2 : " + LengthofLine2);
                double Result = LengthofLine1.CompareTo(LengthofLine2);
                Console.WriteLine(Result);
            if (Result == 0)
            {
                Console.WriteLine("Two Lines are equal ");
            }
            else if (Result < 0.0)
            {
                Console.WriteLine("Line one is Smaller thean Line Two");
            }
            else
            {
                Console.WriteLine("Lines one is Greater then Line two");
            }
        }
        //UC-4
        public void OopsConcept()
        {
            Console.WriteLine("Enter value for x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter value for j1: ");
            int j1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for j2: ");
            int j2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for k1: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for k2: ");
            int k2 = Convert.ToInt32(Console.ReadLine());

            double LengthofLine1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            double LengthofLine2 = Math.Sqrt((j2 - j1) ^ 2 + (k2 - k1) ^ 2);
            Console.WriteLine("Length of Line1 : " + LengthofLine1);
            Console.WriteLine("Length of Line2 : " + LengthofLine2);

            if (LengthofLine1.Equals(LengthofLine2))
            {
                Console.WriteLine("Two lines are equal ");
            }
            else
            {
                Console.WriteLine("Two lines are Not equal");
            }
            double Result = LengthofLine1.CompareTo(LengthofLine2);
            Console.WriteLine(Result);
            if (Result == 0)
            {
                Console.WriteLine("Two Lines are equal ");
            }
            else if (Result < 0.0)
            {
                Console.WriteLine("Line one is Smaller thean Line Two");
            }
            else
            {
                Console.WriteLine("Lines one is Greater then Line two");
            }
        }
    }
}

