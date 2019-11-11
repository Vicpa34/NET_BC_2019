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
            IEnumerable <News> news =_news.GetAll();
            news = news.OrderByDescending(n => n.CreatedOn);
                news = news.Take(6);
            
            ViewData["Message"] = "Your application description page.";

            var model = new IndexViewModel();
            model.news = news;
            return View (model);
        }

        public IActionResult Topics([FromQuery]int categoryId)
        {
            IEnumerable<News> news = _news.GetAll();
            news = news.OrderByDescending(n => n.CreatedOn);
            news = news.Where(n => n.CategoryId == categoryId);
            news = news.Take(6);


            ViewData["Message"] = "Your application description page.";

            var model = new IndexViewModel();
            model.news = news;
            model.ShowCategories = true;
            model.topics = _topics.GetAll(); 
            return View("Index", model);
        }

        public IActionResult OneNew([FromQuery]int id)
        {
            var model = new NewViewModel();
            model.news = _news.Get(id);

            return View(model);

        }
            
        
    }
}
