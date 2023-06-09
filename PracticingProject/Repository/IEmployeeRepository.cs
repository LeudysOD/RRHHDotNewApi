using Microsoft.EntityFrameworkCore;
using PracticingProject.Entities;

namespace PracticingProject.Repository
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employe>> GetAll();
        public Task<Employe> GetById(int id);
        public void Create(Employe employe);
        public void Update(Employe employe);
        public void Delete(int id);
        public void SaveChanges();
    }
}

