using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Service;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        
        // GET: api/Customers
        [HttpGet]
        [Route("GetEmployees")]
        public async Task<HttpResponseMessage> GetCustommers()
        {
            var result = await _employeeService.GetEmployees();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // GET: api/Customers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
