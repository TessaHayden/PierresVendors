using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendors vendor = Vendors.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendors/{vendorId}/orders/{ordersId}")]
    public ActionResult Show(int vendorId, int ordersId)
    {
      OrderItem order = OrderItem.Find(ordersId);
      Vendors vendor = Vendors.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", order);
      model.Add("vendors", vendor);
      return View(model);
    }
    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      OrderItem.ClearAll();
      return View();
    }
    
  }
}