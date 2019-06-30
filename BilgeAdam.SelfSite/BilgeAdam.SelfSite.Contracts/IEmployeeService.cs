using BilgeAdam.SelfSite.DTOs;
using System.Collections.Generic;

namespace BilgeAdam.SelfSite.Contracts
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetEmployees();
    }
}
