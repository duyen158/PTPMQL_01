using Microsoft.AspNetCore.Mvc;
using demoMVC.Models;
namespace demoMVC.controller
{
    public class EmployeeController: Controller
    {

        public ActionResult Index() 
        {
            return View();
        }
        public ActionResult Id() 
        {
            return View();
        }
    }
}