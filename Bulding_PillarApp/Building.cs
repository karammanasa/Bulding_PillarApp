using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulding_PillarApp
{
    internal class Building
    {

        public Building() { }
        public int numberOfFloors = 4;
        //name,pillars,address,colour
        public string name;
        public string address;
        public string colour;
        
      
        public Pillar[,] pillarMatrix = new Pillar[3,3];

        


    }
}
