using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulding_PillarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pillar p1= new Pillar("p00",DateTime.Now,"h0","v0");
             Pillar p2 = new Pillar("p01",DateTime.Now,"h0","v1");
             Pillar p3 = new Pillar("p02", DateTime.Now, "h0", "v2");

            Pillar p4 = new Pillar("p10", DateTime.Now, "h1", "v0");
            Pillar p5 = new Pillar("p11", DateTime.Now, "h1", "v1");
            Pillar p6 = new Pillar("p12", DateTime.Now, "h1", "v2");

            Pillar p7 = new Pillar("p20", DateTime.Now, "h2", "v0");
            Pillar p8 = new Pillar("p21", DateTime.Now, "h2", "v1");
            Pillar p9 = new Pillar("p22", DateTime.Now, "h2", "v2");

            Building b1 = new Building();
            b1.pillarMatrix =new Pillar[3,3] { {p1,p2,p3 }, { p4,p5,p6},{p7,p8,p9 } };


            Console.ReadLine();
        }
    }

}
