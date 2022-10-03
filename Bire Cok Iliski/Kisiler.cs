using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bire_Cok_Iliski
{
   public class Kisiler //dependent entity
    {
        public int KisilerID { get; set; }
        public string KISIAD { get; set; }
        public int PCMarkaID { get; set; }
        public PcMarkalar PcMarkalar { get; set; }
    }
}
