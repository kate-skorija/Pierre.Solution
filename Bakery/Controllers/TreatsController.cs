using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
  public class TreatsController : Controller
  {
    private readonly BakeryContext _db;

    public TreatsController(BakeryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
