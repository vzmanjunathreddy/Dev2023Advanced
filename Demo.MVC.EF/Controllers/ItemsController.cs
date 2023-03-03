using Demo.MVC.EF.Interfaces;
using Demo.MVC.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.EF.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IFoodOrdersService _foodOrdersService;

        public ItemsController(IFoodOrdersService foodOrdersService)
        {
            _foodOrdersService = foodOrdersService;
        }

        public async Task<ActionResult> Index(string category, CustomerViewModel customerViewModel)
        {
            IEnumerable<ItemsDTO> items = null;

            var data = await _foodOrdersService.GetAllItemsItems();

            if (category == null && customerViewModel.Hotelmenu == null)
                return View(data);

            if (customerViewModel != null && customerViewModel.Hotelmenu?.Count() > 0)
            {
                var menuSelected = customerViewModel.Hotelmenu;

                items = data.Where(x => menuSelected.Contains(x.Category)).ToList();
            }
            else
            {
                items = data.Where(x => x.Category.ToLower() == category.ToLower()).ToList();
            }
                
                
            return View(items);
        }


        public ActionResult Details(int id)
        {
            var itemsDTO = _foodOrdersService.GetItemById(id);

            return View(itemsDTO);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
