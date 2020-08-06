using System.Collections.Generic;
using System.Threading.Tasks;
using Dtos;

namespace Repositories
{
    public interface IEmployeeRepository
    {
        void Delete<T>(T entity) where T : class;
        void Add<T>(T entity) where T : class;
        Task<bool> SaveAll();
        List<ContractTypeEmployeeDto> GetAll();
    }
}
