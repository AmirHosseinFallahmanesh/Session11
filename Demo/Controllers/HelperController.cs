using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student student,string country)
        {
            return View();
        }


        public IActionResult List()
        {
            return View();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }
        public string Address { get; set; }

        public bool AcceptPolicy { get; set; }
        public string Gender { get; set; }
    }
}