using SynetecAssessmentApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Services
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> GetEmployeeAsync(int selectedEmployeeId);
    }
}
