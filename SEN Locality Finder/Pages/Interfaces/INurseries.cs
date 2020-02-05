using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEN_Locality_Finder.Pages.Interfaces
{
    public interface INurseriesRepo<T> where T : class //using generics to make the link between tables
    {
        List<T> GetAll();
        T GetSingle();
        int Add(T AddNursery);
        T Update(T UpdateNursery);
        void Delete(int id);
    }
}
