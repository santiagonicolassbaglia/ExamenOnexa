using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMutant.Controllers
{
    public class ApiMutansCs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
