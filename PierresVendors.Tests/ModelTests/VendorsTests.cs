using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.TestTools
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
  }
}