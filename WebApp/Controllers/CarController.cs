
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;

namespace WebApp.Controllers
{
    public class CarController : Controller

    {
        private readonly AddDbContext _context;
        public CarController(AddDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var carList=_context.Cars.ToList();
            return View(carList);
        }
    }
}
