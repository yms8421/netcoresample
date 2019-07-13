using BilgeAdam.SelfSite.Contracts;
using BilgeAdam.SelfSite.DTOs;
using System;
using System.Collections.Generic;

namespace BilgeAdam.SelfSite.SQLServices
{
    public class EmployeeService : IEmployeeService
    {
        private List<EmployeeDTO> employees;
        public EmployeeService()
        {
            RequestCount = Guid.NewGuid();
            employees = new List<EmployeeDTO>
            {
                new EmployeeDTO { Id = 1, FullName = "Nancy Davolio" },
                new EmployeeDTO { Id = 7, FullName = "Robert King" },
                new EmployeeDTO { Id = 9, FullName = "Anne Dodsworth" }
            };
        }
        public Guid RequestCount { get; set; }

        public void AddEmployee(EmployeeDTO dto)
        {
            employees.Add(dto);
        }

        public List<EmployeeDTO> GetEmployees()
        {
            var a = "SQL bağlantısı";
            return employees;
        }
    }
}
