using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.IRepository
{
   public  interface IMenuRepository
    {
       IEnumerable<T_Resources> GetAll();
       bool Add(T_Resources menu);
       bool Delete(T_Resources menu);
       bool Update(T_Resources menu);
    }
}
