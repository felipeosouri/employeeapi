using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Persistence.Database;
using Repositories;
using System.Linq;
using Tests.Config;
namespace Tests
{
    [TestClass]
    public class EmployeeTest
    {
        private IEmployeeRepository _repository;
        private ApplicationDbContext _context;

        [TestInitialize]
        public void Init()
        {
            _context = ApplicationDbContextInMemory.Get();
            _repository = new EmployeeRepository(_context);
        }

        private Employee GetInstance(int id, decimal amount = 15)
        {
            return new Employee
            {
                EmployeeId = id,
                Name = "Juan Felipe",
                Surname = "Osorio Uribe",
                ContractType = "Hourly",
                Amount = amount
            };
        }
        [TestMethod]
        public void GetAllEmployees_Pass()
        {
            _context.Add(GetInstance(1));
            _context.SaveChanges();

            var employees = _repository.GetAll();

            Assert.IsTrue(employees.Count > 0);
        }
        [TestMethod]
        public void GetAllEmployeesMayorThat15()
        {            
            _context.Add(GetInstance(2, 20));
            _context.Add(GetInstance(3, 15));
            _context.SaveChanges();

            var employees = _repository.GetAll();
            employees = employees.Where(x => x.Amount == 15).ToList();
            Assert.IsTrue(employees.Count == 1);
        }
    }
}
