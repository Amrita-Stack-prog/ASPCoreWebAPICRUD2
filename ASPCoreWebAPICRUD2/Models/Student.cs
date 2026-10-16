using System;
using System.Collections.Generic;

namespace ASPCoreWebAPICRUD2.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? FatherSName { get; set; }

    public int? Age { get; set; }
}
