using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Pages.Interfaces;

namespace SEN_Locality_Finder.Models
{
    public class SpecialSchools : ISpecialRepo<Special_School>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(Special_School AddSpecialSchool)
        {
            mycontext.Add(AddSpecialSchool);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Special_School> GetAll()
        {
            return mycontext.Special_Schools.ToList(); //works
        }

        public Special_School GetSingle()
        {
            throw new NotImplementedException();
        }

        public Special_School Update(Special_School UpdateSpecialSchool)
        {
            throw new NotImplementedException();
        }
    }
}
