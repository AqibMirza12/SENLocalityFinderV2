using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEN_Locality_Finder.Pages.Interfaces
{
    public interface ISENRepo<T> where T : class //using generics to make the link between tables
    {
        List<T> GetAll();
        T GetSingle();
        int Add(T AddSENCondition);
        T Update(T UpdateSENCondition);
        void Delete(int id);
    }
}
