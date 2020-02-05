using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SEN_Locality_Finder.Primary
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimaryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PrimaryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Values
        [HttpGet]
        public IEnumerable<Primary_School> Return()
        {
            return this._context.Primary_Schools;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Primart/5
        [HttpGet("{id}", Name = "Return")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Primart
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Primart/5
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
