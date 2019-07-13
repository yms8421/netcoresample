using BilgeAdam.SelfSite.Contracts;
using BilgeAdam.SelfSite.DTOs;
using System;
using System.Collections.Generic;

namespace BilgeAdam.SelfSite.EFServices
{
    public class EmployeeService : IEmployeeService
    {
        private List<EmployeeDTO> employees;
        public EmployeeService()
        {
            RequestCount = Guid.NewGuid();
            employees = new List<EmployeeDTO>
            {
                new EmployeeDTO { Id = 1, FullName = "Nancy Davolio", Country = "England", HireDate = new DateTime(2014, 2, 18) },
                new EmployeeDTO { Id = 7, FullName = "Robert King", Country = "United States" }
            };
        }
        public Guid RequestCount { get; set; }

        public void AddEmployee(EmployeeDTO dto)
        {
            employees.Add(dto);
        }

        public List<EmployeeDTO> GetEmployees()
        {
            var a = "EF bağlantısı";
            return employees;
        }
    }
}
