using DotNetCoreApi.Repository;
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
    public abstract class CrudController<T> : ControllerBase where T : class
    {
        Repository<T> _repository;
        public CrudController(string connectionString)
        {
            _repository = new Repository<T>(connectionString);
        }

        [HttpGet("{id}")]
        public async Task<T> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        // GET: api/<CRUDController>
        [HttpGet]
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        [HttpPost]
        public async Task<int?> CreateAsync([FromBody] T record)
        {
                return await _repository.InsertAsync(record);
        }

        [HttpPost("Guid")]
        public async Task<int?> CreateWithGuidAsync([FromBody] T record)
        {
            return await _repository.InsertAsync(record);
        }

        [HttpPut]
        public async Task<int> UpdateAsync([FromBody] T record)
        {
            return await _repository.UpdateAsync(record);
        }

        [HttpDelete]
        public async Task<int> DeleteAsync([FromBody] T record)
        {
            return await _repository.DeleteAsync(record);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
