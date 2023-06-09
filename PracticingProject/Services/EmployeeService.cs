using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PracticingProject.Dtos;
using PracticingProject.Entities;
using PracticingProject.Repository;

namespace PracticingProject.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmployeDto>> GetAll() => _mapper.Map<IEnumerable<EmployeDto>>(await _employeeRepository.GetAll());
       
        public async Task<EmployeDto> GetById(int id) => _mapper.Map<EmployeDto>(await _employeeRepository.GetById(id));
        
        public async void Create(EmployeDto employe)
        {
            _employeeRepository.Create(_mapper.Map<Employe>(employe));
            _employeeRepository.SaveChanges();
        }

        public void Update(EmployeDto employe)
        {
            _employeeRepository.Update(_mapper.Map<Employe>(employe));
            _employeeRepository.SaveChanges();
        }
        public void Delete(int id)
        {
            _employeeRepository.Delete(id);
            _employeeRepository.SaveChanges();
        }

    }
}
