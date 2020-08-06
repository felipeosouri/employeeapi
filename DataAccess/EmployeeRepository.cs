using Dtos;
using Persistence.Database;
using Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public List<ContractTypeEmployeeDto> GetAll()
        {
            var data = _context.Employees.Select(d =>  new ContractTypeEmployeeDto
            { 
                EmployeeId = d.EmployeeId,
                Name = d.Name,
                Surname = d.Surname,
                ContractType = d.ContractType,
                Amount = d.Amount
            });

            return data.ToList();
        }
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
