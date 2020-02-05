using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Pages.Interfaces;

namespace SEN_Locality_Finder.Models
{
    public class College : ICollegeRepository<College>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(College AddCollege)
        {
            mycontext.Add(AddCollege);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<College> GetAll()
        {
            throw new NotImplementedException();
            //return mycontext.Colleges.ToList()); //needs an explicit conversion
        }

        public College GetSingle()
        {
            throw new NotImplementedException();
        }

        public College Update(College UpdateCollege)
        {
            throw new NotImplementedException();
        }
    }
}
