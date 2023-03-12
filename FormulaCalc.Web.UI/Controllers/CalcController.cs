using Microsoft.AspNetCore.Mvc;

namespace FormulaCalc.Web.UI.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
