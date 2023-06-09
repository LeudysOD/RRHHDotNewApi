using PracticingProject.Dtos;
using PracticingProject.Entities;
using PracticingProject.Repository;

namespace PracticingProject.Services
{
    public interface IEmployeeService
    {
        public  Task<IEnumerable<EmployeDto>> GetAll();

        public Task<EmployeDto> GetById(int id);

        public void Create(EmployeDto employe);


        public void Update(EmployeDto employe);

        public void Delete(int id);


    }
}
