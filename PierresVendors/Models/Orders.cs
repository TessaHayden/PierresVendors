using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class OrderItem
  {
    public string OrderName { get; set; }
    public string Type { get; set; }
    public int Cost { get; set; }
    public int Quantity { get; set; }
    public int Total { get; set; }
    public int Id { get; }
    private static List<OrderItem> _instances = new List<OrderItem> { };

    public OrderItem(string vendorName, string type, int cost, int quantity)
    {
      OrderName = vendorName;
      Quantity = quantity;
      Type = type;
      Cost = cost;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<OrderItem> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static OrderItem Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}