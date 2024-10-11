using Employee_MVC_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_MVC_App.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<Employee> LE = new List<Employee>();
        static EmployeeController()
        {
            Employee E1 = new Employee() { Id = 1, Name = "ravalika", Designation = "Student", PhnNo = 8247, Email = "rava@", Salary = 123556 };
            Employee E2 = new Employee() { Id = 2, Name = "raju", Designation = "employee", PhnNo = 9502, Email = "raju@", Salary = 556654 };
            LE.Add(E1);
            LE.Add(E2);
        }

        public IActionResult Index()
        {
            return View(LE);
        }
        public IActionResult GetEmployee(int empid)
        {
            Employee Obj = LE.Where(e => e.Id == empid).FirstOrDefault();
            if(Obj!=null)
            {
                return View(Obj);
            }
            return NotFound();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee Obj)
        {
            if (ModelState.IsValid)
            {
                if (Obj != null)
                {
                    LE.Add(Obj);
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Details(int id)
        {
            Employee E = LE.Where(c => c.Id == id).FirstOrDefault();
            return View(E);
        }
        //public IActionResult DeleteEmp(int id)
        //{
        //    Employee E = LE.Where(c => c.Id == id).FirstOrDefault();
        //    LE.Remove(E);
        //    return View(E);
        //}
        public IActionResult UpdateEmp(int id)
        {
            var emp = LE.Where(c => c.Id == id).FirstOrDefault();
            return View(emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateEmp(Employee E1)
        {
            if (E1 != null)
            {
                var e = LE.Where(c => c.Id == E1.Id).FirstOrDefault();
                e.Name = E1.Name;
                e.Salary = E1.Salary;
            }
            return RedirectToAction("Index"); 
        }
        [HttpGet]
        public IActionResult DeleteEmp(int id)
        {
            var e = LE.Where(c => c.Id == id).FirstOrDefault();
            if (e != null)
            {
                return View(e);
            }
            return NotFound(); 
        }
        [HttpPost,ActionName("DeleteEmp")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var e = LE.Where(c => c.Id == id).FirstOrDefault();
            if(e!=null)
            {
                LE.Remove(e);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
