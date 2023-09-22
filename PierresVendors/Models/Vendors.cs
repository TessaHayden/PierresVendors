using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendors
  {
    private static List<Vendors> _instances = new List<Vendors> { };
    public string Name { get; set; }
    public int Id { get; }
    public List<OrderItem> Orders { get; set; }
    public Vendors(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<OrderItem> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}