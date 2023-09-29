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
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      OrderItem order = OrderItem.Find(orderId);
      Vendors vendor = Vendors.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", order);
      model.Add("vendors", vendor);
      return View(model);
    }
    
  }
}