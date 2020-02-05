using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SEN_Locality_Finder.SENConditions
{
    [Route("api/[controller]")]
    [ApiController]
    public class SENConditionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SENConditionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Values
        [HttpGet]
        public IEnumerable<SEN_Condition> ReturnSENConditions()
        {
            return this._context.SEN_Conditions;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/SENConditions/5
        [HttpGet("{id}", Name = "ReturnSENConditions")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SENConditions
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/SENConditions/5
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
