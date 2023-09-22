using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class OrderItem
  {
    public int Quantity { get; set; }
    public string Type { get; set; }
    public int Id { get; }
    private static List<OrderItem> _instances = new List<OrderItem> { };

    public OrderItem(string type, int quantity)
    {
      Type = type;
      Quantity = quantity;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}