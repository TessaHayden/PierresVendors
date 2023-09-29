using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendors
  {
    private static List<Vendors> _instances = new List<Vendors> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<OrderItem> OrderList { get; set; }
    public Vendors(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      OrderList = new List<OrderItem> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendors> GetAll()
    {
      return _instances;
    }
    public static Vendors Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void AddOrder(OrderItem orderItem)
    {
      OrderList.Add(orderItem);
    }
  }
}