using SynetecAssessmentApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Services
{
    public interface IBonusPoolService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync();
        Task<BonusPoolCalculatorResultDto> CalculateAsync(int bonusPoolAmount, int selectedEmployeeId);
    }
}
