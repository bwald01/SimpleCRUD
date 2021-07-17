using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class
    {
        // GET: api/<CRUDController>
        [HttpGet]
        public IEnumerable<T> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CRUDController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return "value";
        }

        // POST api/<CRUDController>
        [HttpPost]
        public void Post([FromBody] T record)
        {
        }

        // PUT api/<CRUDController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CRUDController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
