using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Pages.Interfaces;

namespace SEN_Locality_Finder.Models
{
    public class SEN : ISENRepo<SEN_Condition>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(SEN_Condition AddSENCondition)
        {
            mycontext.Add(AddSENCondition);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SEN_Condition> GetAll()
        {
            return mycontext.SEN_Conditions.ToList(); //works
        }

        public SEN_Condition GetSingle()
        {
            throw new NotImplementedException();
        }

        public SEN_Condition Update(SEN_Condition UpdateSENCondition)
        {
            throw new NotImplementedException();
        }
    }
}
