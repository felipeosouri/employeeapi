using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Repositories;
using Tests.Config;
namespace Tests
{
    [TestClass]
    public class EmployeeTest
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeTest(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [TestMethod]
        public void GetAllEmployees()
        {
            //var context = ApplicationDbContextInMemory.Get();

            //var employeeId = 1;
            //var name = "Juan Felipe";
            //var surname = "Osorio Uribe";
            //var contractType = "Hourly";
            //var amount = 10;

            //context.Employees.Add(new Employee
            //{
            //    EmployeeId = employeeId,
            //    Name = name,
            //    Surname = surname,
            //    ContractType = contractType,
            //    Amount = amount
            //});

            //context.SaveChanges();

            var employees = _repository.GetAll();
        }
    }
}
