using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] arge)
        {
            Corner corner = new Corner();
            corner.ToRadians();

        }

    }
    class Corner
    {
        privat int gradus;
        privat int min;
        privat int sec;



        public Corner(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec= sec;
        }

        public static double ToRadians(this int gradus)
        {
            return (Math.PI / 180) * gradus;
        }
    }
}
