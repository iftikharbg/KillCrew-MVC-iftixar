using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_FRONTEND.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_FRONTEND.Controllers
{
    public class ContactController : Controller
    {
       

       

        public IActionResult Contact()
        {
            return View();
        }



    }
}
