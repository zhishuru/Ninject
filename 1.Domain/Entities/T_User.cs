using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain
{
    public class T_User
    {
        public T_User()
        {
            this.Role = new List<T_Role>();
        }

        public string UserId { get; set; }
        public string LoginUser { get; set; }
        public string Name { get; set; }
        public string OrgCode { get; set; }
        public string PassWord { get; set; }
        public virtual T_Org Org { get; set; }
        public virtual ICollection<T_Role> Role { get; set; }
    }
}
