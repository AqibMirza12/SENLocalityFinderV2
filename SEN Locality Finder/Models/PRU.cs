using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEN_Locality_Finder.Pages.Interfaces;

namespace SEN_Locality_Finder.Models
{
    public class PRU : IPRURepo<PRU>
    {
        AppDbContext mycontext = new AppDbContext();

        public int Add(PRU AddPRU)
        {
            mycontext.Add(AddPRU);
            return mycontext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PRU> GetAll()
        {
            throw new NotImplementedException();
            //return mycontext.PRU.ToList(); //needs an explicit conversion
        }

        public PRU GetSingle()
        {
            throw new NotImplementedException();
        }

        public PRU Update(PRU UpdatePRU)
        {
            throw new NotImplementedException();
        }
    }
}
