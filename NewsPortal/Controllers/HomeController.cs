using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Models;
using NewsPortalLogic;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        private TopicManager _topics;
        private NewsManager _news;
        public HomeController(TopicManager topicManager, NewsManager newsManager)
        {
            _topics = topicManager;
            _news = newsManager;

        }
        public IActionResult Index()
        {
            //var lastNews = _news.Where();
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        
    }
}
