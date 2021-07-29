using DotNetCoreApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : CrudController<Customer>
    {
        CustomerController(IConfiguration configuration) : base(configuration.GetConnectionString("SimpleCrud"))
        {
            
        }
    }
}
