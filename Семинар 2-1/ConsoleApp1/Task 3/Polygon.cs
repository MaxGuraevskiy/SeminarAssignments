using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Polygon
    {
        int sidesNumber;
        double radius;

        public Polygon(int sidesNumber = 3, double radius = 1)
        {
            this.sidesNumber = sidesNumber;
            this.radius = radius;
        }

        public double Perimeter {
            get {
                double term = Math.Tan(Math.PI / sidesNumber);
                return 2 * sidesNumber * radius * term;
            }
        }

        public double Area {
            get {
                return Perimeter * radius / 2;
            }
        }

        public string PolygonData()
        {
            return $"N={sidesNumber}; R={radius}; P={Perimeter}; S={Area}";
        }
    }
}
