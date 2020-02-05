using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SEN_Locality_Finder.Secondary
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecondaryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SecondaryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Values
        [HttpGet]
        public IEnumerable<Secondary_School> ReturnDB()
        {
            return this._context.Secondary_Schools;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Secondary/5
        [HttpGet("{id}", Name = "ReturnDB")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Secondary
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Secondary/5
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
