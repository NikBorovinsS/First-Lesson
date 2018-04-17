//Author: Мария Дегтяренко
//Task: Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны
//многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_4
{
    class Point
    {
        private int xCoord;
        private int yCoord;
        private string name;

        public int XCoord
        {
            get { return xCoord;}
        }

        public int YCoord
        {
            get { return yCoord; }
        }

        public string Name
        {
            get { return name; }
        }

        public Point (int x, int y, string nm)
        {
            xCoord = x;
            yCoord = y;
            name = nm;
                        
        }
        

    }

    class Figure
    {
        private Point[] points;
        
        public Point[] Points
        {
            get { return points; }
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] {point1,point2,point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public double LenghtSide(Point A, Point B)
        {
            return Math.Sqrt((B.XCoord - A.XCoord) * (B.XCoord - A.XCoord) + (B.YCoord - A.YCoord)*(B.YCoord - A.YCoord));
        }

        public void PerimeterCalculator()
        {
            double perimeter=0;
            for (int i = 0; i<Points.Length-1; i++)
            {
                perimeter += LenghtSide(Points[i], points[i + 1]);
            }
            perimeter += LenghtSide(Points[0], Points.Last());
            
            Console.WriteLine("\nPerimeter = "+perimeter);
        }

        public void ShowName()
        {
            foreach (Point p in Points)
            {
                Console.Write(p.Name);
            }

        }

    }

    class Classes_4
    {
        static void Main(string[] args)
        {
            Figure triangle = new Figure(new Point(1, 5, "K"), new Point(1, 1, "L"), new Point(6, 1, "M"));
            Console.Write("Figure 1: ");
            triangle.ShowName();
            triangle.PerimeterCalculator();

            Figure square = new Figure(new Point (0,2,"A"), new Point(2, 2, "B"), new Point(2, 0, "C"), new Point(0,0,"D"));
            Console.Write("\nFigure 2: ");
            square.ShowName();
            square.PerimeterCalculator();

            Figure pentagon = new Figure(new Point(0, 1, "A"), new Point(6, 1, "B"), new Point(6, 5, "C"), new Point(3, 6, "D"), new Point(0,5, "F"));
            Console.Write("\nFigure 3: ");
            pentagon.ShowName();
            pentagon.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
