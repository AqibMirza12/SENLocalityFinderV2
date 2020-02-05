using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEN_Locality_Finder.Pages.Interfaces
{
    public interface IPrimaryRepo<T> where T : class //using generics to make the link between tables
    {
        List<T> GetAll();
        T GetSingle();
        int Add(T AddPrimarySchool);
        T Update(T UpdatePrimarySchool);
        void Delete(int id);
    }
}
