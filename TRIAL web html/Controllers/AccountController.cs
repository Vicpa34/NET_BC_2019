using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRIAL_web_html.Models;
using TRIALLogic;

namespace TRIAL_web_html.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {

            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();
                if (manager.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("error", "Email alredy exists!");
                }
                else
                {
                    manager.Create(new TRIALLogic.User()
                    {
                        Email = model.Email,
                        Password = model.Password
                    });
                    TempData["message"] = "Account created!";
                    return RedirectToAction("SignIn");
                }
            }

                return View();
            
        }
    }
}