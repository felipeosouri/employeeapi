using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employees =  _repository.GetAll();

            return Ok(employees);
        }
    }
}