using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web.Mvc;

public class EmployeeController : Controller
{
    private readonly ApplicationDbContext _context = new ApplicationDbContext();

    public ActionResult Index()
    {
        var employees = _context.Employees.ToList();
        return View(employees);
    }
}
