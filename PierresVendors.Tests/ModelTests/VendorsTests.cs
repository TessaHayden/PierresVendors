using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.TestsTools
{
  [TestClass]
  public class VendorsTests : IDisposable
  {
    public void Dispose()
    {
      Vendors.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesIntstanceOfVendor_Vendor()
    {
      Vendors newVendor = new Vendors("Portland Bakery", "Bakery and restaurant");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }
    [TestMethod]
    public void GetAllVendors_ReturnsVendorsName_GetAll()
    {
      string name = "Portland Bakery";
      string description = "Bakery and Restaurant";
      Vendors newVendor = new Vendors(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Portland Bakery";
      string description = "Bakery and Restaurant";
      Vendors newVendor = new Vendors(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorsList()
    {
      string name1 = "Portland Bakery";
      string name2 = "Elephant Delicatessen";
      Vendors newVendor1 = new Vendors(name1, "null");
      Vendors newVendor2 = new Vendors(name2, "null");
      List<Vendors> newList = new List<Vendors> { newVendor1, newVendor2 };
      List<Vendors> result = Vendors.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendors()
    {
      string name1 = "Portland Bakery";
      string name2 = "Elephant Delicatessen";
      Vendors newVendor1 = new Vendors(name1, "null");
      Vendors newVendor2 = new Vendors(name2, "null");
      Vendors result = Vendors.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVenodr_OrderList()
    {
      string vendorName = "Portland Bakery";
      int quantity = 36;
      string type = "donuts";
      int cost = 2;
      OrderItem newOrder = new OrderItem(vendorName, type, quantity, cost);
      List<OrderItem> newList = new List<OrderItem> { newOrder };
      string name = "Portland Bakery";
      Vendors newVendors = new Vendors(name, "null");
      newVendors.AddOrder(newOrder);
      List<OrderItem> result = newVendors.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}