using Microsoft.AspNetCore.Mvc;
using demoMVC.Models;
namespace demoMVC.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person ps)
        {
            string strOutput = "xin chao " + ps.PersonId + "-" + ps.FullName + "-" +ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
        public ActionResult People() 
        {
            return View();
        }
    }
}
