using System;
using System.Collections.Generic;

namespace curdApi.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Sname { get; set; }

    public string? Semail { get; set; }

    public int? Sage { get; set; }
}
