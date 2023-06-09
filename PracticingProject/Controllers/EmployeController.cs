using Microsoft.AspNetCore.Mvc;
using PracticingProject.Dtos;
using PracticingProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticingProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeDto>> GetAll() => await _employeeService.GetAll();

        [HttpGet("{id}")]
        public async Task<EmployeDto> Get(int id) => await _employeeService.GetById(id);

        [HttpPost]
        public void Post(EmployeDto employe) => _employeeService.Create(employe);

        [HttpPut]
        public void Update(EmployeDto employe) => _employeeService.Update(employe);

        [HttpDelete("{id}")]
        public void Delete(int id) => _employeeService.Delete(id);
    }
}
