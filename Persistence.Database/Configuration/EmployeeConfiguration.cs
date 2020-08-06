using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using static Common.Enums.Enums;

namespace Persistence.Database.Configuration
{
    public class EmployeeConfiguration
    {
        public EmployeeConfiguration(EntityTypeBuilder<Employee> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(80);
            entityBuilder.Property(x => x.Surname).IsRequired().HasMaxLength(80);
            entityBuilder.Property(x => x.ContractType).IsRequired().HasMaxLength(20);
            entityBuilder.Property(x => x.Amount).IsRequired().HasColumnType("decimal(18,2)");

            //Contract Type
            Array values = Enum.GetValues(typeof(ContractType));
            Random randomContractType = new Random();            

            //Employees by default
            var employees = new List<Employee>();
            var randomAmount = new Random();

            for (int i = 1; i <= 10; i++)
            {
                ContractType contractType = (ContractType)values.GetValue(randomContractType.Next(values.Length));

                employees.Add(new Employee
                {
                    EmployeeId = i,
                    Name = $"Employee {i}",
                    Surname = $"Surname Employee {i}",
                    ContractType = contractType.ToString(),
                    Amount = randomAmount.Next(10, 1000)
                });
            }

            entityBuilder.HasData(employees);
        }
    }
}
