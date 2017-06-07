using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_46
{
    class Triangle
    {
        //These Variables identify the basic criteria for the Triangle object
        private double side1Length;
        private double side2Length;
        private double side3Length;
        private double area;
        private double perimeter;

        //The Getters & Setters are the properties type can be accessed by constructors
        //and are available to be referenced as public.

        public double Side1Length
        {
            get
            {
                return side1Length;
            }
            set
            {
                side1Length = value;
            }
        }
        public double Side2Length
        {
            get
            {
                return side2Length;
            }
            set
            {
                side2Length = value;
            }
        }
        public double Side3Length
        {
            get
            {
                return side3Length;
            }
            set
            {
                side3Length = value;
            }
        }
        //this constructor initiates a value for each property
        public Triangle()
        {
            side1Length = 0;
            side2Length = 0;
            side3Length = 0;
            
           
        }
       
        //this constructor enables the user to input the value of the property
        public Triangle(double Input1Length, double Input2Length, double Input3Length)
        {
            side1Length = Input1Length;
            side2Length = Input2Length;
            side3Length = Input3Length;
        }
        //the getArea Property below performs GETS the data to calculate the Area of a Triangle
        public double getArea
        {
            get { return .5 * side1Length * side2Length; }
        }
        //the getPerimeter Property performs GETS the data inputted by user for Perimeter of Triangle
        public double getPerimeter
        {
            get { return side1Length + side2Length + side3Length; }
        }
        //This method gets the information obtained, Returns the STRING of Area 
        public string getFormattedArea()
        {
            return (getArea.ToString());
        }
        //This method gets the information obtained, Returns the STRING of Perimeter
        public string getFormattedPerimeter()
        {
            return (getPerimeter.ToString());
        }

               
        }
    }
