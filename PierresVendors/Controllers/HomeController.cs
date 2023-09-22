using Microsoft.AspNetCore.Mvc;

namespace PierresVendors.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}