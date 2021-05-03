using System.ComponentModel.DataAnnotations;

namespace SynetecAssessmentApi.Dtos
{
    public class CalculateBonusDto
    {
        public int TotalBonusPoolAmount { get; set; }
        [Required]
        public int SelectedEmployeeId { get; set; }
    }
}
