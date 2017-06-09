using System.Collections.Generic;
using System.Web.Mvc;
using ClashKO.Models;

namespace ClashKO.Controllers
{
    public class ClanController : Controller
    {
        // GET: Clan
        public ActionResult Index()
        {
            var viewModel = new Clan
            {
                Members = new List<Person>
                {
                    new Person{Name = "Mark"},
                    new Person{Name = "Donny"}
                }
            };

            return View(viewModel);
        }
    }
}