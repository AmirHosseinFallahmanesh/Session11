using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MainPageViewModel model = new MainPageViewModel()
            {
                News = new List<News>()
                {
                    new News() { Title="الودگی هوا کم شد",Description="هوا پاک شد"}
                },
            
                Categories = new List<Category>()
                {
                    new Category()
                    {
                        Name="علمی"
                    },
                     new Category()
                    {
                        Name="فزهنگی"
                    },

                }
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
