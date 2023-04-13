using EmployeesWebAppication.Data;
using EmployeesWebAppication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace EmployeesWebAppication.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly EmployContext _db;

        public IEnumerable<Employ> Employees { get; set; }
        public IndexModel(EmployContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
             Employees = _db.Employees;
        }
    }
}
