using BilgeAdam.SelfSite.DTOs;

namespace BilgeAdam.SelfSite.Models
{
    public class EmployeeViewModel : EmployeeDTO
    {
        public bool HasHireDate { get { return HireDate.HasValue; } }
        public string FormattedHireDate
        {
            get
            {
                if (HasHireDate)
                {
                    return HireDate.Value.ToString("dd/MM/yyyy");
                }
                return "Tarih Yok";
            }
        }
    }
}
