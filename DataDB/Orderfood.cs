using System;
using System.Collections.Generic;

namespace OnlineFood.DataDB;

public partial class Orderfood
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FoodItem { get; set; } = null!;

    public int Quantity { get; set; }
}
