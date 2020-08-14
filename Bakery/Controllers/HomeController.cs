using Bakery.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Bakery.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    private readonly BakeryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public HomeController(UserManager<ApplicationUser> userManager, BakeryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      ViewBag.Treats = _db.Treats.ToList();
      return View();
    }
  }
}