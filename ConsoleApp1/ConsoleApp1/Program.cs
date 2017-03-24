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
            Console.WriteLine(" Please enter a color for your rectangle: ");
            Rectangle.color = Console.ReadLine();
    

            Console.Write("Please enter the length that you want your rectangle: ");
            string lengthPut = Console.ReadLine();
            int recLength = Convert.ToInt32(lengthPut);

            Console.Write("Please enter the width that you want your rectangle to be: ");
            string widthPut = Console.ReadLine();
            int recWidth = Convert.ToInt32(widthPut);

            Rectangle rec1 = new Rectangle();
            rec1.length = recLength;
            rec1.width = recWidth;
            int firstareea = rec1.FindArea();

            Console.WriteLine("The area of your" + Rectangle.color + "rectangle is " + firstareea);

            Console.Write("Now enter the length of your second rectangle: ");
            string lengthPut2 = Console.ReadLine();
            int recLength2 = Convert.ToInt32(lengthPut2);

            Console.Write("Enter the width that you want your second rectange to be: ");
            string widthPut2 = Console.ReadLine();
            int recWidth2 = Convert.ToInt32(widthPut2);

            Rectangle rec2 = new Rectangle();
            rec2.length = recLength2;
            rec2.width = recWidth2;
            int secondareea = rec2.FindArea();

            int totalArea = firstareea + secondareea;

            Console.WriteLine("Your total area is: " +  totalArea);
            Console.ReadKey();
        }

    class Rectangle
    {
            public int length;
            public int width;
            public static string color;

        public int FindArea()
            {
                int area = length * width;
                return area;

            
            }
        
        }
    }
}
