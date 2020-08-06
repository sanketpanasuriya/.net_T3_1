using System;
using System.Drawing;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorRactangle ractangle = new ColorRactangle("Blue", "Ractangle", 15, 12);
            ColorRactangle square = new ColorRactangle("Purple",15);

            Console.WriteLine("----Rectangle details------");
            ractangle.DisplayAllDetails();

            Console.WriteLine("----Square details------");
            square.DisplayAllDetails();
        }
    }
    class Shape {
        double a_width;
        double a_length;
        public Shape() {
            Width = Length = 0;
        }
        public Shape(double w, double l) {
            Width = w;
            Length = l;
        }

        public Shape(double y) {
            Width = Length = y;
        }

        public double Width {
            get {
                return a_width;
            }
            set {
                a_width = value;
            }
        }
        public double Length {
            get {
                return a_length;
            }
            set {
                a_length = value;
            }
        }
        public void Display() {
            Console.WriteLine("Width and Length are {0} and {1}", Width, Length);
        }
    }

    class RactangleStyle : Shape
    {
        string Style;
        public RactangleStyle(string s , double w, double h) : base(w,h)  
        {
            Style = s;
        }

        public RactangleStyle(double y) : base(y) {
            Style = "Square";
        }

        public void DisplayStyle() {
            Console.WriteLine("Rectangle style is {0}",Style);
        }
    }

    class ColorRactangle: RactangleStyle{
        string color;
        public ColorRactangle(string c, string s, double w, double l) : base(s,w,l) {
            color = c;
        }
        public ColorRactangle(string c, double y) : base(y) {
            color = c;
        }

        public void DisplayColor() {
            Console.WriteLine("Ractangle color is {0}",color);
        }

        public void DisplayAllDetails() {
            Display();
            DisplayStyle();
            DisplayColor();
        }
    }
}
