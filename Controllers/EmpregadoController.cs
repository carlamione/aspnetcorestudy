using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp
{
    public class EmpregadoController : Controller {

        //list
        public IActionResult Index () {
            return View();
        }
     }   
}