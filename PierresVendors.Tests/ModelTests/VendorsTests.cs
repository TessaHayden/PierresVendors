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
      Vendors newVendor = new Vendors("Portland Bakery");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }
  }
}