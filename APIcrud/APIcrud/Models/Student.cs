using System;
using System.Collections.Generic;

namespace APIcrud.Models;

public partial class Student
{
    public Guid Id { get; set; }

    public string? Sname { get; set; }

    public int? Sage { get; set; }

    public string? Email { get; set; }
}
