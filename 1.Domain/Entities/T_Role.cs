using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain
{
   public  class T_Role
    {
       public T_Role()
        {
            this.T_Resources = new List<T_Resources>();
            this.T_User = new List<T_User>();
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<T_Resources> T_Resources { get; set; }
        public virtual ICollection<T_User> T_User { get; set; }
    }
}
