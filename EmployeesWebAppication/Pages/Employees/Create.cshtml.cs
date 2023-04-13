using EmployeesWebAppication.Data;
using EmployeesWebAppication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesWebAppication.Pages.Employees
{
    [BindProperties]

    public class CreateModel : PageModel
    {

        private readonly EmployContext _db;

        public Employ Employees { get; set; }
        public CreateModel(EmployContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() {

            if (Employees.Emp_name == Employees.Emp_JobTitle) {
                ModelState.AddModelError(string.Empty, "Job name must not the name of employee");
            }
            if (ModelState.IsValid)
            {
                _db.Employees.AddAsync(Employees);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
            
        }
    }
}
