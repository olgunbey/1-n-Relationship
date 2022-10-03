using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bire_Cok_Iliski
{
   public class PcMarkalar//principal entity 
    {
        public int MarkaID { get; set; }
        public string MarkaAD { get; set; }

        public ICollection<Kisiler> Kisiler { get; set; }
    }
}
