using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly BakeryContext _db;

    public CategoriesController(BakeryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
  }
}
