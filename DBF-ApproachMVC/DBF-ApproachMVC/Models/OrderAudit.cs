using System;
using System.Collections.Generic;

namespace DBF_ApproachMVC.Models;

public partial class OrderAudit
{
    public int AuditId { get; set; }

    public int? OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateTime? AuditDate { get; set; }
}
