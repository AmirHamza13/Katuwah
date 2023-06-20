////show1 edit with working:
/*
using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Purchase.Pages.Employee
{
    public class EmployeeListModel : PageModel
    {
        [BindProperty]
        public IList<EmployeeModel> EmployeeList { get; set; }
        public int EmployeeId { get; set; }
        private readonly IEmployeeService m_Employee;
        public EmployeeListModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;

        }


        public void OnGet()
        {
            try
            {
                EmployeeList = m_Employee.GetEmployeeList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
*/
////show edit with working no action:

using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Purchase.Pages.Employee
{
    public class EmployeeListModel : PageModel
    {
        private readonly IEmployeeService m_Employee;

        public EmployeeListModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;
        }

        public IList<EmployeeModel> EmployeeList { get; set; }

        public void OnGet()
        {
            try
            {
                EmployeeList = m_Employee.GetEmployeeList();
            }
            catch (Exception ex)
            {
                // Handle any exceptions appropriately
                throw;
            }
        }

        // Action method to handle the delete operation
        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                // Delete the employee with the given ID
                m_Employee.DeleteEmployee(id);
                return Ok();
            }
            catch (Exception ex)
            {
                // Handle any exceptions appropriately
                return StatusCode(500, ex.Message);
            }
        }

        private IActionResult Ok()
        {
            throw new NotImplementedException();
        }
    }
}

//show edit with working no action:
/*
using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Purchase.Pages.Employee
{
    public class EmployeeListModel : PageModel
    {
        private readonly IEmployeeService m_Employee;

        public EmployeeListModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;
        }

        public IList<EmployeeModel> EmployeeList { get; set; }

        public void OnGet()
        {
            try
            {
                EmployeeList = m_Employee.GetEmployeeList();
            }
            catch (Exception ex)
            {
                // Handle any exceptions appropriately
                throw;
            }
        }

        // Action method to handle the delete operation
        [HttpPost]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                // Delete the employee with the given ID
                m_Employee.DeleteEmployee(id);
                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                // Handle any exceptions appropriately
                return Ok(new { success = false, message = ex.Message });
            }
        }

        private IActionResult Ok(object value)
        {
            throw new NotImplementedException();
        }
    }
}
*/