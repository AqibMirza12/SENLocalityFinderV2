using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Pages.Interfaces;
namespace SEN_Locality_Finder.Models
{
    public class Academies : IAcademyRepository<Academy>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(Academy AddAcademy)
        {
            mycontext.Add(AddAcademy);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Academy> GetAll()
        {
            return mycontext.Academies.ToList(); //works
        }

        public Academy GetSingle()
        {
            throw new NotImplementedException();
        }

        public Academy Update(Academy UpdateAcademy)
        {
            throw new NotImplementedException();
        }
    }
}
