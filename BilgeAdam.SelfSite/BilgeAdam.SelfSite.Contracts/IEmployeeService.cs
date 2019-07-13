using BilgeAdam.SelfSite.DTOs;
using System;
using System.Collections.Generic;

namespace BilgeAdam.SelfSite.Contracts
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetEmployees();
        Guid RequestCount { get; set; }
        void AddEmployee(EmployeeDTO dto);
    }
}
