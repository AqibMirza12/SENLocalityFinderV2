using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SEN_Locality_Finder.PupilReferralUnit
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SpecialController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Values
        [HttpGet]
        public IEnumerable<Special_School> ReturnSpecialSchools()
        {
            return this._context.Special_Schools;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/PRU/5
        [HttpGet("{id}", Name = "ReturnSpecialSchools")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PRU
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PRU/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
