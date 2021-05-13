using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Vecsis.Controllers
{
    public class PaginaWebClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




    }
}
