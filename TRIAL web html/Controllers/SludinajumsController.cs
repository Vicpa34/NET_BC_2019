using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TRIAL_web_html.Models;
using TRIALLogic;

namespace TRIAL_web_html.Controllers
{

    public class SludinajumsController : Controller
    {       
        SludinajumsManager manager = new SludinajumsManager();
        public IActionResult Index(int Id)
        {            
            manager.Seed();
            var sludinajumi = manager.GetByCategory(Id);

            return View(sludinajumi);
        }

        public IActionResult Sludinajums()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sludinajums(SludinajumsModel model)
        {

            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Sludinajumi");
            }
        }

        public IActionResult Kategorija(SludinajumsModel model)
        {

            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Sludinajumi");
            }

        }
        public IActionResult View(int id)
        {
            var sludinajums = manager.Get(id);

            return View(sludinajums);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
