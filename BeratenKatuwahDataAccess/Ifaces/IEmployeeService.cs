using BeratenKatuwahDomain.Employee;

namespace BeratenKatuwahDataAccess.Ifaces
{
    public interface IEmployeeService
    {
        int CreateEmployee(EmployeeModel employeeModel);
        void DeleteEmployee(int id);
        EmployeeModel GetEmployee(int employeeId);
        EmployeeModel GetEmployee(object id);
        EmployeeModel GetEmployeeById(int employeeId);
        IList<EmployeeModel> GetEmployeeList();
        void UpdateEmployee(EmployeeModel employeeModel);
    }
}


