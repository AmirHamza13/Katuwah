//no show edit without working

using BeratenKatuwahDataAccess.DbModel;
using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BeratenKatuwahDataAccess.Managers
{
    public class EmployeeManager : BaseDataManager, IEmployeeService
    {
        public EmployeeManager(EmployeeDbContext model) : base(model)
        {
        }

        public int CreateEmployee(EmployeeModel employeeModel)
        {
            AddUpdateEntity(employeeModel);
            return employeeModel.Id;
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployee(object id)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IList<EmployeeModel> GetEmployeeList()
        {
            return dbModel.EmployeeModel.ToList();
        }

        public void UpdateEmployee(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }
    }
}

//show edit without working:
/*
using BeratenKatuwahDataAccess.DbModel;
using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BeratenKatuwahDataAccess.Managers
{
    public class EmployeeManager : BaseDataManager, IEmployeeService
    {
        public EmployeeManager(EmployeeDbContext model) : base(model)
        {
        }

        public int CreateEmployee(EmployeeModel employeeModel)
        {
            AddUpdateEntity(employeeModel);
            return employeeModel.Id;
        }

        public EmployeeModel GetEmployee(int employeeId)
        {
            return dbModel.EmployeeModel.FirstOrDefault(e => e.Id == employeeId);
        }

        public void UpdateEmployee(EmployeeModel employeeModel)
        {
            dbModel.Entry(employeeModel).State = EntityState.Modified;
            dbModel.SaveChanges();
        }

        public IList<EmployeeModel> GetEmployeeList()
        {
            return dbModel.EmployeeModel.ToList();
        }

        public EmployeeModel GetEmployee(object id)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}

*/
//show edit with working no action:
/*
using BeratenKatuwahDataAccess.DbModel;
using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BeratenKatuwahDataAccess.Managers
{
    public class EmployeeManager : BaseDataManager, IEmployeeService
    {
        public EmployeeManager(EmployeeDbContext model) : base(model)
        {
        }

        public int CreateEmployee(EmployeeModel employeeModel)
        {
            AddUpdateEntity(employeeModel);
            return employeeModel.Id;
        }

        public IList<EmployeeModel> GetEmployeeList()
        {
            return dbModel.EmployeeModel.ToList();
        }

        public EmployeeModel GetEmployeeById(int employeeId)
        {
            return FindEntity<EmployeeModel>(employeeId);
        }

        public void UpdateEmployee(EmployeeModel employeeModel)
        {
            AddUpdateEntity(employeeModel);
        }

        public EmployeeModel GetEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployee(object id)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
*/

