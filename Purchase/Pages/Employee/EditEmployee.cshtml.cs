/*using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Purchase.Pages.Employee
{
    public class EditEmployeeModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
*/

//no show edit without working:
/*
using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Purchase.Pages.Employee
{
    public class EditEmployeeModel : PageModel
    {
        [BindProperty]
        public EmployeeModel EmployeeModel { get; set; }

        private readonly IEmployeeService m_Employee;
        public EditEmployeeModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;
        }

        public IActionResult OnGet(int employeeId)
        {
            EmployeeModel = m_Employee.GetEmployee(employeeId);

            if (EmployeeModel == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                m_Employee.UpdateEmployee(EmployeeModel);

                TempData["Message"] = "Employee updated successfully";
                return RedirectToPage("/Employee/EditEmployee", new { employeeId = EmployeeModel.Id });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
*/

//show edit without working

using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Purchase.Pages.Employee
{
    public class EditEmployeeModel : PageModel
    {
        [BindProperty]
        public EmployeeModel EmployeeModel { get; set; }

        private readonly IEmployeeService m_Employee;
        public EditEmployeeModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;
        }

        public void OnGet(int employeeId)
        {
            EmployeeModel = m_Employee.GetEmployeeById(employeeId);
        }

        public IActionResult OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                m_Employee.UpdateEmployee(EmployeeModel);

                TempData["Message"] = "Employee updated successfully";
                return RedirectToPage("/Employee/EmployeeList");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

//show edit with working
/*
using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Purchase.Pages.Employee
{
    public class EditEmployeeModel : PageModel
    {
        private readonly IEmployeeService m_Employee;
        public EditEmployeeModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;
        }

        [BindProperty]
        public EmployeeModel EmployeeModel { get; set; }

        public IActionResult OnGet(int id)
        {
            EmployeeModel = m_Employee.GetEmployeeById(id);
            if (EmployeeModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            m_Employee.UpdateEmployee(EmployeeModel);

            TempData["Message"] = "Employee updated successfully";
            return RedirectToPage("/Employee/EmployeeList");
        }
    }
}
*/