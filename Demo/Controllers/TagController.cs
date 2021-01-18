using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class TagController : Controller
    {
        public IActionResult Index(string name,int age)
        {
            return View();
        }
    }
}