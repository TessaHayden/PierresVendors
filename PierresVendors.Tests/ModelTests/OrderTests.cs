using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresVendors.Models;

namespace PierresVendors.TestTools
{
  [TestClass]
  public class OrderTests : IDisposable{
    public void Dispose()
    {
      OrderItem.ClearAll();
    }
    [TestMethod]
    public void OrderItemConstructor_CreatesInstanceOfOrders_Order()
    {
      OrderItem newOrder = new OrderItem("Portland Bakery", "Croissants", 2, 12);
      Assert.AreEqual(typeof(OrderItem), newOrder.GetType());
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string vendorName = "Portland Bakery";
      string vendorType = "Restaurant and Bakery";
      int orderCost = 2;
      int orderQuantity = 12;
      OrderItem newOrder = new OrderItem(vendorName, vendorType, orderCost, orderQuantity);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string vendorName1 = "Portland Bakery";
      string vendorName2 = "Elephant Delicatessen";
      string vendorType1 = "Restaurant and Bakery";
      string vendorType2 = "Deli and cafe";
      int orderCost1 = 3;
      int orderQuantity1 = 12;
      int orderCost2 = 2;
      int orderQuantity2 = 24;
      OrderItem newOrder1 = new OrderItem(vendorName1, vendorType1, orderCost1, orderQuantity1);
      OrderItem newOrder2 = new OrderItem(vendorName2, vendorType2, orderCost2, orderQuantity2);
      OrderItem result = OrderItem.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}