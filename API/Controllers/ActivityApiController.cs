using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/v1/ActivityApi")]
    [ApiController]
    public class ActivityApiController : ControllerBase
    {
        private readonly DataContext DbContext;
        public ActivityApiController(DataContext dbContext)
        {
            DbContext = dbContext;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivityList()
        {
            return await DbContext.Activities.ToListAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await DbContext.Activities.FindAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
