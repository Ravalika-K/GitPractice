using System;
using System.Collections.Generic;

namespace DBF_ApproachMVC.Models;

public partial class Order
{
    public int? OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateOnly? OrderDate { get; set; }
}
