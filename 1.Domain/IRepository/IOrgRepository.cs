using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Domain.IRepository
{
    public interface IOrgRepository
    {
        IEnumerable<T_Org> GetAll();
        bool Add(T_Org model);
        bool Delete(T_Org model);
        bool Update(T_Org model);
    }
}
