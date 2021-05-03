using SynetecAssessmentApi.Domain;
using SynetecAssessmentApi.Dtos;
using SynetecAssessmentApi.Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeDto> GetEmployeeAsync(int selectedEmployeeId)
        {
            var match = await _employeeRepository.FindSingleAsync(x => x.Id == selectedEmployeeId);

            if(match == null)
            {
                return null;
            }

            return new EmployeeDto { 
              Fullname = match.Fullname,
              JobTitle = match.JobTitle
            };
        }
    }
}
