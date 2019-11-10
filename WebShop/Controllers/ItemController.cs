using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        private CategoryManager _categories;
        private ItemManager _items;
        public ItemController(CategoryManager categoryManager, ItemManager itemManager)
        {
            _categories = categoryManager;
            _items = itemManager;
            
        }
        public IActionResult Index(int id)
        {
            //var manager = new ItemManager();
            //manager.Seed();

            //var categoryManager = new CategoryManager();
            //categoryManager.Seed();

            var items = _items.GetByCategory(id);
            var categories = _categories.GetAll();
            foreach (var cat in categories)
            {
                cat.ItemCount = _items.GetByCategory(cat.Id).Count;
                //....atlasa un uzstādā preču skaitu zem konkrētās kategorijas
            }

            var model = new CatalogModel()

            {
                Items = items,
                Categories = categories
            };
            return View(model);
        }

        public IActionResult Buy(int id)
        {
            var item = _items.Get(id);

            var basket = HttpContext.Session.GetUserBasket();
            if (basket == null)
            {
                basket = new List<int>();
            }
            basket.Add(id);

            HttpContext.Session.SetUserBasket(basket);

            return RedirectToAction("Index", "Item", new { id = item.CategoryId });
        }

        //1.Pievieno jaunu darbību Buy ar vienu parametru - id
        //2.atlasa lietotāja grozu no sesijas
        //2.1 Ja grozs nav definēts definē grozu kā jaunu sarakstu (new List<int>());
        //3. pievieno izvēlēto preces ID lietotāja grozam;
        //4. Saglabā lietotāja grozu sesijā.
        
            public IActionResult Basket()
            {
            List<Item> items = new List<Item>();
            List<int> basket = HttpContext.Session.GetUserBasket();
            if (basket != null)
            {
                //var manager = new ItemManager();
                //manager.Seed();

                foreach (var id in basket)
                {
                    items.Add(_items.Get(id));
                }
            }
            return RedirectToAction("Index", "Action");

            //return View(items);

            //1.Define jaunu sarakstu precēm;
            //2. Par katru preci kas ir lietotaja sesija atlasa tas datus un pievieno sarakstam;
            //3. Atgriež preču sarakstu uz View
        }
        public IActionResult Delete(int id)
        {
            return RedirectToAction();
        }
    }
}