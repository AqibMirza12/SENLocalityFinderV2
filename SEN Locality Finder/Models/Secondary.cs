using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Pages.Interfaces;

namespace SEN_Locality_Finder.Models
{
    public class Secondary : ISecondaryRepo<Secondary_School>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(Secondary_School AddSecondarySchool)
        {
            mycontext.Add(AddSecondarySchool);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }

        public List<Secondary_School> GetAll()
        {
            return mycontext.Secondary_Schools.ToList();
        }

        public Secondary_School GetSingle()
        {
            throw new NotImplementedException();
        }

        public Secondary_School Update(Secondary_School UpdateSecondarySchool)
        {
            throw new NotImplementedException();
        }
    }
}
