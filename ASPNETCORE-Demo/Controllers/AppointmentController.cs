using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCORE_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETCORE_Demo.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

       
    }
}
