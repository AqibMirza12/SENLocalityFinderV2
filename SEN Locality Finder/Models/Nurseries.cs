using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Pages.Interfaces; 

namespace SEN_Locality_Finder.Models
{
    public class Nurseries : INurseriesRepo<Nursery>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(Nursery AddNursery)
        {
            mycontext.Add(AddNursery);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Nursery> GetAll()
        {
            return mycontext.Nurseries.ToList(); //works
        }

        public Nursery GetSingle()
        {
            throw new NotImplementedException();
        }

        public Nursery Update(Nursery UpdateNursery)
        {
            throw new NotImplementedException();
        }
    }
}
