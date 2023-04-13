using EmployeesWebAppication.Data;
using EmployeesWebAppication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesWebAppication.Pages.Employees
{
    [BindProperties]

    public class UpdateModel : PageModel
    {

        private readonly EmployContext _db;

        public Employ Employees { get; set; }
        public UpdateModel(EmployContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Employees = _db.Employees.Find(id);
        }

        public async Task<IActionResult> OnPost() {
            if (Employees != null) {
                _db.Employees.Update(Employees);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
            
        }
    }
}
