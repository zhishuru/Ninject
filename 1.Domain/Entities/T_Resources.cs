using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain
{
   public class T_Resources
    {
       public T_Resources()
        {
            this.Role = new List<T_Role>();
        }

        public int Rid { get; set; }
        public string Resources { get; set; }
        public string Url { get; set; }
        public int? Type { get; set; }
        public int? ParentrId { get; set; }
        public int? TIndex { get; set; }
        public string Name { get; set; }

        public virtual ICollection<T_Role> Role { get; set; }
    }
}
