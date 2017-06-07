using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_46
{
    class Program
    {
        static void Main(string[] args)
        {   
            //This creates/istatiates the object of the Triangle Class
            Triangle t1 = new Triangle();
            
            //Message displayed to user
            Console.WriteLine("Enter the length of one side for the triangle : ");
            //Converts the user input into a string
            string Side1Length = Console.ReadLine();

            Console.WriteLine("Enter the second length of one side of the triangle : ");
            string Side2Length = Console.ReadLine();

            Console.WriteLine("Enter the third length of the last side of the triangle : ");
            string Side3Length = Console.ReadLine();

            //Converts the String by Parsing the data and returning a double and storing in the object.
            t1.Side1Length = Double.Parse(Side1Length);
            t1.Side2Length = Double.Parse(Side2Length);
            t1.Side3Length = Double.Parse(Side3Length);

            //Message sent to user, along with data supplied by user and calculations recieved from methods within the class
            Console.WriteLine("Your triangle will have sides {0}, {1}, {2}.",t1.Side1Length, t1.Side2Length, t1.Side3Length);
            Console.WriteLine("Area: " + t1.getFormattedArea());
            Console.WriteLine("Perimeter: " + t1.getFormattedPerimeter());

          
        }
    }
}
