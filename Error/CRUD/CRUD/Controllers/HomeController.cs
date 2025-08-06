using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers;

public class HomeController : Controller
{
    private readonly eCommerceContext DbContext;
    public HomeController(eCommerceContext NewContext, IWebHostEnvironment newenv)
    {
        this.DbContext = NewContext;
    }

    public IActionResult Index()
    {
        var products = DbContext.tbl_products.ToList();
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
