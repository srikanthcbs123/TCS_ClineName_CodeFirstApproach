namespace TCS_ClineName_CodeFirstApproach
{
    public interface IDepartmentRepository
    {
        Task<List<Departement>> GetDepartments();
        Task<Departement> GetDepartmentById(int deptid);
        Task<int> AddDepartments(Departement deptdetail);
        Task<bool> DeleteDepartmentById(int deptid);
        Task<bool> UpdateDepartment(Departement deptdetail);
    }
}
