using System;

namespace BilgeAdam.SelfSite.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
