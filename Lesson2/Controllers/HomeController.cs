using Lesson2.Models;
using Lesson2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lesson2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id = 1,
                    Title1 = "Zakir",
                    Title2 = "Eterna",
                    Desc = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",
                    BtnText = "Read More",
                    BtnUrl = "#",
                    Image = "slide-1.jpg"
                },
                 new Slider
                {
                    Id = 2,
                    Title1 = "Zakir",
                    Title2 = "Ipsum Dolor",
                    Desc = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",
                    BtnText = "Read More",
                    BtnUrl = "#",
                    Image = "slide-2.jpg"
                },
                  new Slider
                {
                    Id = 3,
                    Title1 = "Zakir",
                    Title2 = "Dime Lara",
                    Desc = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",
                    BtnText = "Read More",
                    BtnUrl = "#",
                    Image = "slide-3.jpg"
                }

            };

            List<Feature> features = new List<Feature>
            {
                new Feature{
                    Id=1,
                    Title ="Lorem Zakir",
                    Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",
                    Icon = "<i class=\"bi bi-card-checklist\"></i>"
                },
                new Feature{
                    Id=2,
                    Title ="Ipsum Zakir",
                    Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",
                    Icon = "<i class=\"bi bi-card-checklist\"></i>"
                },
                new Feature{
                    Id=3,
                    Title ="Dolor Zakir",
                    Desc = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",
                    Icon = "<i class=\"bi bi-card-checklist\"></i>"
                }
            };
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                Features = features
            };
            
            return View(homeVM);
        }
        public IActionResult About()
        {
            return View();
        }
        
    }
}
