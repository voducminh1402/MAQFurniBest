using System.Collections.Generic;
using MAQFurni.Models;
public class OrderViewModel {
    public List<User> Users {get; set;}
    public List<Order> Orders {get; set;}
    public List<ShippingStatus> ShippingStatuses {get; set;}
}