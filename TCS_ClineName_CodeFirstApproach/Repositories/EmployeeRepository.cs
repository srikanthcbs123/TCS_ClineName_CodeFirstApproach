
using Microsoft.EntityFrameworkCore;
using TCS_ClineName_CodeFirstApproach.DbConnect;

namespace TCS_ClineName_CodeFirstApproach.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _employeeContext;
        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext= employeeContext;
        }
        public async Task<int> AddEmployes(Employee empdetail)
        {
            await _employeeContext.employees.AddAsync(empdetail);//add the record by using addasync
            _employeeContext.SaveChanges();//it will commit/save the data perminently in table
            return 1;
        }

        public async Task<bool> DeleteEmployesById(int empid)
        {

            Employee rm =  _employeeContext.employees.SingleOrDefault(e => e.empid == empid);
            if (rm != null)
            {//Here Remove() method is used for removing the data from database.

                _employeeContext.employees.Remove(rm);
                _employeeContext.SaveChanges();
                return true;
            }
            else return false;
        }

        public async Task<Employee> GetEmployeeById(int empid)
        {
            var rm = await _employeeContext.employees.Where(e => e.empid == empid).FirstOrDefaultAsync();

            if (rm == null)
                return null;
            else
                return rm;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var result = _employeeContext.employees.ToList();
            if (result.Count == 0)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public async Task<bool> UpdateEmploye(Employee empdetail)
        {

            _employeeContext.Update(empdetail);
            await _employeeContext.SaveChangesAsync();
            return true;

        }
    }
}
