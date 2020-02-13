using Microsoft.AspNetCore.Mvc;
using AspNetCoreApp.Models.DB;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreApp
{
    public class DepartamentoController : Controller {

        private RH RHContext; 
        public DepartamentoController(RH rh) {
            RHContext = rh;
        }

        //list
        public IActionResult Index () {
            List<Departamento> departamentos = RHContext.Departamentos.ToList();
            return View(departamentos);
        }
     }   
}