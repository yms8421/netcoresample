using BilgeAdam.SelfSite.Contracts;
using BilgeAdam.SelfSite.DTOs;
using System;
using System.Collections.Generic;

namespace BilgeAdam.SelfSite.EFServices
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {
            RequestCount = Guid.NewGuid();
        }
        public Guid RequestCount { get; set; }

        public List<EmployeeDTO> GetEmployees()
        {
            var a = "EF bağlantısı";
            return new List<EmployeeDTO>
            {
                new EmployeeDTO { Id = 1, FullName = "Nancy Davolio", Country = "England", HireDate = new DateTime(2014, 2, 18) },
                new EmployeeDTO { Id = 7, FullName = "Robert King", Country = "United States" }
            };
        }
    }
}
