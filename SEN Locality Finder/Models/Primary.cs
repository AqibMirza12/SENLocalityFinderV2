using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Interface_Iteration;
using SEN_Locality_Finder.Pages.Interfaces;

namespace SEN_Locality_Finder.Models
{
    public class Primary : IPrimaryRepo<Primary_School>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(Primary_School AddPrimarySchool)
        {
            mycontext.Add(AddPrimarySchool);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }

        public List<Primary_School> GetAll()
        {
            return mycontext.Primary_Schools.ToList();
        }

        public Primary_School GetSingle()
        {
            throw new NotImplementedException();
        }

        public Primary_School Update(Primary_School UpdatePrimarySchool)
        {
            throw new NotImplementedException();
        }
    }
}
