using ProjectFClean.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace ProjectFClean.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectFCleanDB1 _db;

        public HomeController()
        {
            _db = new ProjectFCleanDB1();
        }
        public class HomeIndexViewModel
        {
            public List<Housekeeper> ListHousekeeper { get; set; }
            public List<Service> ListService { get; set; }
        }
        public ActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                ListHousekeeper = _db.Housekeeper.ToList(),
                ListService = _db.Service.ToList()
            };


            return View(viewModel);
        }
        public ActionResult Details(int HID = 0)
        {
            Housekeeper housekeeper = _db.Housekeeper.Find(HID);
            if (housekeeper == null)
            {
                return HttpNotFound();
            }
            return View("DetailsHouseKeeper", housekeeper);
        }


        [HttpGet]
        public PartialViewResult Search(string gender, string location, string name, string service)
        {
            // Lọc danh sách HouseKeeper dựa trên các tham số tìm kiếm
            IQueryable<Housekeeper> housekeepers = _db.Housekeeper;

            if (!string.IsNullOrEmpty(gender))
            {
                housekeepers = housekeepers.Where(h => h.Gender == gender);
            }

            if (!string.IsNullOrEmpty(location))
            {
                housekeepers = housekeepers.Where(h => h.Distrinct == location);
            }

            if (!string.IsNullOrEmpty(name))
            {
                housekeepers = housekeepers.Where(h => h.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(service))
            {
                // Kiểm tra xem housekeeper có chứa kỹ năng service trong danh sách kỹ năng của mình hay không
                housekeepers = housekeepers.Where(h => h.Skill.Contains(service));
            }

            List<Housekeeper> searchResult = housekeepers.ToList();

            return PartialView("_HousekeeperList", searchResult);
        }

        public PartialViewResult Sort(int sortOption)
        {
            // Get the list of housekeepers from the database
            var housekeepers = _db.Housekeeper.ToList();

            // Perform sorting based on sortOption
            switch (sortOption)
            {
                case 1: // Price Ascending
                    housekeepers = housekeepers.OrderBy(h => h.Price).ToList();
                    break;
                case 2: // Price Decreasing
                    housekeepers = housekeepers.OrderByDescending(h => h.Price).ToList();
                    break;
                case 3: // Experience Decreasing
                    housekeepers = housekeepers.OrderByDescending(h => h.Experiment).ToList();
                    break;
                default:
                    // Default sorting (if necessary)
                    break;
            }

            // Return the sorted list as a partial view
            return PartialView("_HousekeeperList", housekeepers);
        }

        public ActionResult Sorts(int sortOption)
        {
            // Get the list of housekeepers from the database
            var housekeepers = _db.Housekeeper.ToList();

            // Perform sorting based on sortOption
            switch (sortOption)
            {
                case 1: // Price Ascending
                    housekeepers = housekeepers.OrderBy(h => h.Price).ToList();
                    break;
                case 2: // Price Decreasing
                    housekeepers = housekeepers.OrderByDescending(h => h.Price).ToList();
                    break;
                case 3: // Experience Decreasing
                    housekeepers = housekeepers.OrderByDescending(h => h.Experiment).ToList();
                    break;
                default:
                    // Default sorting (if necessary)
                    break;
            }

            // Return the sorted list as a partial view
            return PartialView("_HousekeeperList", housekeepers);
        }
    }
}
