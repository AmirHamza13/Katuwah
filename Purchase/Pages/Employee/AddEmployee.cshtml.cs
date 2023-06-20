//show edit without working

using BeratenKatuwahDataAccess.Ifaces;
using BeratenKatuwahDomain.Employee;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Purchase.Pages.Employee
{
    public class AddEmployeeModel : PageModel
    {
        [BindProperty]
        public EmployeeModel EmployeeModel { get; set; }

        private readonly IEmployeeService m_Employee;
        public AddEmployeeModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;

        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }



                m_Employee.CreateEmployee(EmployeeModel);

                TempData["Message"] = "Employee added successfully";
                return RedirectToPage("/Employee/AddEmployee", new EmployeeModel());
            }
            catch (Exception ex)
            {
                throw;
            }
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
    public class AddEmployeeModel : PageModel
    {
        private readonly IEmployeeService m_Employee;

        public AddEmployeeModel(IEmployeeService employeeService)
        {
            m_Employee = employeeService;
        }

        [BindProperty]
        public EmployeeModel EmployeeModel { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                int employeeId = m_Employee.CreateEmployee(EmployeeModel); // Generate and get the ID for the newly added employee

                TempData["Message"] = "Employee added successfully with ID: " + employeeId;

                // Redirect to the "EditEmployee" page for the newly added employee
                return RedirectToPage("/Employee/EditEmployee", new { id = employeeId });
            }
            catch (Exception ex)
            {
                // Handle any exceptions appropriately
                throw;
            }
        }
    }
}


*/