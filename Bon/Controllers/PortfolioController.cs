using Microsoft.AspNetCore.Mvc;


namespace Bon.Controllers
{
    public class PortfolioController : Controller //note to self: always end it in .Controller
    {
        public IActionResult BonView() //note to self: should match the view even when renamed, should be under that specfic folder too
        {
          
            return View();
        }
    }
}
