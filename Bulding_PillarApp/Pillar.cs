using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulding_PillarApp
{
    internal class Pillar
    {
        
        // This comment is only to demo ull Request in Azure DevOps
        public Pillar(string name,DateTime iDate,string hbeam,string vbeam) {

        pillarName= name.ToLower();
            installationDate= iDate;
            horizontalBeam= hbeam;
            verticalBeam= vbeam;
            
        
        
        }


        public string pillarName;
        public DateTime installationDate;
        public string horizontalBeam;
        public string verticalBeam;


    }
}
