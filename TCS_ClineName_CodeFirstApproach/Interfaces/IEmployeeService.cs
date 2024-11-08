﻿

namespace TCS_ClineName_CodeFirstApproach
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetEmployees();
        Task<EmployeeDto> GetEmployeeById(int empid);
        Task<int> AddEmployes(EmployeeDto empdetail);
        Task<bool> DeleteEmployesById(int empid);
        Task<bool> UpdateEmploye(EmployeeDto empdetail);
    }
}
