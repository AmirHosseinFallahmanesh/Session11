using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Components
{
    public class AdvertisementViewComponent:ViewComponent
    {

        List<Advertise> data;
        public AdvertisementViewComponent()
        {
            data = new List<Advertise>()
                {
                    new Advertise(){Title="تیلیغ بایا"}
                };
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View(data);

        }


    }
}
