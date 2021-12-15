using OnlineStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnslineShop.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        private IItemRepository repository;
        public ItemController(IItemRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.Items);
        }
    }
}