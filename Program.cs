using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>
        {
            new Point(5, 10),
            new ColoredPoint(20, 30, "Красный"),
            new Trehmernaya(50, 60, 70)
        };
            foreach (var point in points)
            {
                point.Show();    
                point.Draw();   
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}