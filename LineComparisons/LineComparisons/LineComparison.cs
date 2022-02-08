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
   }
}
