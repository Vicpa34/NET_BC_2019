using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TRIALLogic;

namespace TRIAL_web_html.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int id)
        {
            var manager = new CategoryManager();
            manager.Seed();
            var category = manager.GetAll();

            return View(category);
        }
    }
}