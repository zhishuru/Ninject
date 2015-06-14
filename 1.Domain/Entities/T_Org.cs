using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain
{
   public class T_Org
    {
        public string Orgcode { get; set; }
        public string Name { get; set; }
        public string ParentCode { get; set; }
        public int? Orgtype { get; set; }
    }
}
