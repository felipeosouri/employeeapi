using Models;
using Common.Extensions;

namespace Dtos
{
    public class ContractTypeEmployeeDto : Employee
    {
        public decimal AnnualSalary => Amount.GetAnnualSalary(ContractType);
    }
}
