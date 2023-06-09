using Microsoft.EntityFrameworkCore;
using PracticingProject.Context;
using PracticingProject.Entities;

namespace PracticingProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Employe>> GetAll() => await _context.Employes.Where(x => !x.IsDeleted).ToListAsync();

        public async Task<Employe> GetById(int id) => await _context.Employes.FindAsync(id);

        public async void Create(Employe employe) => await _context.Employes.AddAsync(employe);

        public void Update(Employe employe) => _context.Employes.Update(employe);

        public void Delete(int id)
        {
            var employee = _context.Employes.Find(id);
            employee!.IsDeleted = true;
            _context.Update(employee);
        }

        public void SaveChanges() => _context.SaveChanges();
    }
}
