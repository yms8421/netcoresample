using BilgeAdam.SelfSite.Contracts;
using BilgeAdam.SelfSite.DTOs;
using System;
using System.Collections.Generic;

namespace BilgeAdam.SelfSite.SQLServices
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
            var a = "SQL bağlantısı";
            return new List<EmployeeDTO>
            {
                new EmployeeDTO { Id = 1, FullName = "Nancy Davolio" },
                new EmployeeDTO { Id = 7, FullName = "Robert King" },
                new EmployeeDTO { Id = 9, FullName = "Anne Dodsworth" }
            };
        }
    }
}
