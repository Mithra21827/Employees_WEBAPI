using EmployeesWebAppication.Data;
using EmployeesWebAppication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesWebAppication.Pages.Employees
{
    [BindProperties]

    public class DeleteModel : PageModel
    {

        private readonly EmployContext _db;

        public Employ Employees { get; set; }
        public DeleteModel(EmployContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Employees = _db.Employees.Find(id);
        }

        public async Task<IActionResult> OnPost() {

            if (Employees != null) {
                _db.Employees.Remove(Employees);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
            
        }
    }
}
